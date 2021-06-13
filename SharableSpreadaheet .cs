using System;
using System.Threading;
using System.Collections.Generic;
using System.IO;


namespace SpreadsheetApp
{
    class SharableSpreadaheet
    {
        Dictionary<object, String> Table = new Dictionary<object, string>();
        int Rows;
        int Cols;
        Mutex rmut = new Mutex();
        Semaphore wsam = new Semaphore(1, 1);
        SemaphoreSlim sam;
        int counter = 0;
        int max = 10000;
        public SharableSpreadaheet(int nRows, int nCols)
        {
            this.Rows = nRows + 1;
            this.Cols = nCols + 1;
            this.sam = new SemaphoreSlim(1, 10000);
            for (int row = 1; row < Rows; row++)
            {
                for (int col = 1; col < Cols; col++)
                {
                    (int row, int col) Cell = (row, col);
                    Table[Cell] = "|    ";
                }
            }
        }
        public void s_read()
        {
            rmut.WaitOne();//reads need to wait
            counter++;
            if (counter == 1)//check if the thread is first reader
            {
                rmut.ReleaseMutex();//relase mut1 for others readers
                wsam.WaitOne(); // writers need to wait
            }
            else
            {
                rmut.ReleaseMutex();//relase mut1 for others readers
            }
        }
        public void e_read()
        {
            rmut.WaitOne();//reads need to wait
            counter--;
            if (counter == 0)//check if the thread is last reader
            {
                rmut.ReleaseMutex();//relase mut1 for others readers
                wsam.Release(); //no more readers here
            }
            else
            {
                rmut.ReleaseMutex();//relase mut1 for others readers
            }
        }
        public String getCell(int row, int col)
        {
            // return the string at [row,col]
            // this action is a read only action, therefore we are not limiting the number of users that can access in any time.
            s_read();
            (int row, int col) cell = (row, col);
            e_read();
            return Table[cell];
        }

        public bool setCell(int row, int col, String str)
        {
            // set the string at [row,col]
            //this function we want to defend.
            //in any case, only one user can use this function with the same cell location.
            //we want to let the user set values concurrently as long as they dont try to set the same resource.
            //as for this moment, we have a naive implementation of synchronization in the set method.
            wsam.WaitOne();
            rmut.WaitOne();
            (int row, int col) cell = (row, col);
            Table[cell] = str;
            //Console.WriteLine("{0} is leaving the protected area", Thread.CurrentThread.ManagedThreadId);
            //Console.WriteLine("{0} has released the mutex", Thread.CurrentThread.ManagedThreadId);
            rmut.ReleaseMutex();
            wsam.Release();
            return true;
        }
        public bool searchString(String str, ref int row, ref int col)
        {
            // search the cell with string str, and return true/false accordingly.
            // stores the location in row,col.
            // return the first cell that contains the string (search from first row to the last row)
            s_read();
            sam.WaitAsync();
            for (int i = 1; i < Rows; i++)
            {
                for (int j = 1; j < Cols; j++)
                {
                    (int row, int col) cell = (i, j);
                    if (Table[cell] == str)
                    {
                        row = i;
                        col = j;
                        sam.Release();
                        e_read();
                        return true;
                    }
                }
            }
            sam.Release();
            e_read();
            return false;
        }
        public bool exchangeRows(int row1, int row2)
        {
            // exchange the content of row1 and row2
            wsam.WaitOne();
            rmut.WaitOne();
            for (int i = 1; i < Cols; i++)
            {
                // get the value of the current cell
                (int row, int col) cellRow1 = (row1, i);
                (int row, int col) cellRow2 = (row2, i);
                string value = Table[cellRow1];
                Table[cellRow1] = Table[cellRow2];
                Table[cellRow2] = value;
            }
            rmut.ReleaseMutex();
            wsam.Release();
            return true;

        }
        public bool exchangeCols(int col1, int col2)
        {
            // exchange the content of col1 and col2
            wsam.WaitOne();
            rmut.WaitOne();
            for (int i = 1; i < Rows; i++)
            {
                // get the value of the current cell
                (int row, int col) cellRow1 = (i, col1);
                (int row, int col) cellRow2 = (i, col2);
                string value = Table[cellRow1];
                Table[cellRow1] = Table[cellRow2];
                Table[cellRow2] = value;
            }
            rmut.ReleaseMutex();
            wsam.Release();
            return true;
        }
        public bool searchInRow(int row, String str, ref int col)
        {
            // perform search in specific row
            s_read();
            sam.WaitAsync();
            for (int j = 1; j < Cols; j++)
            {
                (int row, int col) cell = (row, j);
                if (Table[cell] == str)
                {
                    col = j;
                    sam.Release();
                    e_read();
                    return true;
                }
            }
            sam.Release();
            e_read();
            return false;
        }
        public bool searchInCol(int col, String str, ref int row)
        {
            // perform search in specific col
            s_read();
            sam.WaitAsync();
            for (int i = 1; i < Rows; i++)
            {
                (int row, int col) cell = (i, col);
                if (Table[cell] == str)
                {
                    row = i;
                    sam.Release();
                    e_read();
                    return true;
                }
            }
            sam.Release();
            e_read();
            return false;
        }
        public bool searchInRange(int col1, int col2, int row1, int row2, String str, ref int row, ref int col)
        {
            // perform search within spesific range: [row1:row2,col1:col2] 
            //includes col1,col2,row1,row2
            s_read();
            sam.WaitAsync();
            for (int i = row1; i < row2 + 1; i++)
            {
                for (int j = col1; j < col2 + 1; j++)
                {
                    (int row, int col) cell = (i, j);
                    if (Table[cell] == str)
                    {
                        row = i;
                        col = j;
                        sam.Release();
                        e_read();
                        return true;
                    }
                }
            }
            sam.Release();
            e_read();
            return false;
        }
        public bool addRow(int row1)
        {
            wsam.WaitOne();
            rmut.WaitOne();
            try
            {
                if (row1 == Rows - 1)
                {
                    for (int j = 1; j < Cols; j++)
                    {
                        (int row, int col) lastRowCell = (row1 + 1, j);
                        Table[lastRowCell] = "";
                    }
                    Rows++;
                    rmut.ReleaseMutex();
                    wsam.Release();
                    return true;
                }
                else if (row1 > Rows - 1)
                {
                    Console.WriteLine("\n\n***** Invalid Number *****\n\n");
                    rmut.ReleaseMutex();
                    wsam.Release();
                    return false;
                }
                else
                {
                    (int row, int col) cell;
                    for (int i = Rows - 1; i > row1; i--)
                    {
                        for (int j = 1; j < Cols; j++)
                        {
                            if (i == row1 + 1)
                            {
                                cell = (i, j);
                                (int row, int col) nextCell = (i + 1, j);
                                Table[nextCell] = Table[cell];
                                Table[cell] = "";
                            }
                            else
                            {
                                cell = (i, j);
                                (int row, int col) nextCell = (i + 1, j);
                                Table[nextCell] = Table[cell];
                            }
                        }
                    }
                    Rows++;
                    rmut.ReleaseMutex();
                    wsam.Release();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("there was an error");
                rmut.ReleaseMutex();
                wsam.Release();
                return false;
            }
        }
        public bool addCol(int col1)
        {
            wsam.WaitOne();
            rmut.WaitOne();
            try
            {
                if (col1 == Cols - 1)
                {
                    for (int i = 1; i < Rows; i++)
                    {
                        (int row, int col) lastColCell = (i, col1 + 1);
                        Table[lastColCell] = "";
                    }
                    Cols++;
                    rmut.ReleaseMutex();
                    wsam.Release();
                    return true;
                }
                else if (col1 > Cols - 1)
                {
                    Console.WriteLine("\n\n***** Invalid Number *****\n\n");
                    rmut.ReleaseMutex();
                    wsam.Release();
                    return false;
                }
                else
                {
                    (int row, int col) cell;
                    for (int j = Cols - 1; j > col1; j--)
                    {
                        for (int i = 1; i < Rows; i++)
                        {
                            if (j == col1 + 1)
                            {
                                cell = (i, j);
                                (int row, int col) nextCell = (i, j + 1);
                                Table[nextCell] = Table[cell];
                                Table[cell] = "";
                            }
                            else
                            {
                                cell = (i, j);
                                (int row, int col) nextCell = (i, j + 1);
                                Table[nextCell] = Table[cell];
                            }
                        }
                    }
                    Cols++;
                    rmut.ReleaseMutex();
                    wsam.Release();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("there was an error");
                rmut.ReleaseMutex();
                wsam.Release();
                return false;
            }

        }
        public void getSize(ref int nRows, ref int nCols)
        {
            s_read();
            sam.WaitAsync();
            nRows = Rows - 1;
            nCols = Cols - 1;
            sam.Release();
            e_read();
        }
        public bool setConcurrentSearchLimit(int nUsers)
        {
            // this function aims to limit the number of users that can perform the search operations concurrently.
            // The default is no limit. When the function is called, the max number of concurrent search operations is set to nUsers. 
            // In this case additional search operations will wait for existing search to finish.
            wsam.WaitOne();
            rmut.WaitOne();
            if (max - sam.CurrentCount <= nUsers)
            {
                sam = new SemaphoreSlim(max - sam.CurrentCount, nUsers);
                max = nUsers;
                rmut.ReleaseMutex();
                wsam.Release();
                return true;
            }
            rmut.ReleaseMutex();
            wsam.Release();
            return false;
        }

        public bool save(String fileName)
        {
            // save the spreadsheet to a file fileName.
            // you can decide the format you save the data. There are several options.

            wsam.WaitOne();
            rmut.WaitOne();
            using (StreamWriter ofile = new StreamWriter(fileName))
            {
                for (int i = 1; i < Rows; i++)
                {

                    String saved = "";
                    for (int j = 1; j < Cols; j++)
                    {
                        (int row, int col) cell = (i, j);
                        if (j+1 == Cols)
                        {
                            saved += Table[cell];
                        }
                        else
                        {
                            saved += Table[cell] + ",";
                        }
                        
                    }
                    ofile.WriteLine(saved);
                }
            }
            rmut.ReleaseMutex();
            wsam.Release();
            return true;
        }
        public bool load(String fileName)
        {
            // load the spreadsheet from fileName
            // replace the data and size of the current spreadsheet with the loaded data
            s_read();
            sam.WaitAsync();
            StreamReader file = new StreamReader(fileName + ".csv");
            var lines = new List<string[]>();
            int lineCounter = 0;
            Dictionary<object, String> newTable = new Dictionary<object, string>();

            while (!file.EndOfStream)
            {
                string[] Line = file.ReadLine().Split(',');
                lines.Add(Line);
                lineCounter++;
            }
            for (int i = 0; i < lineCounter; i++)
            {
                for (int j = 0; j < lines[0].Length; j++)
                {
                    (int row, int col) cell = (i + 1, j + 1);
                    newTable[cell] = lines[i][j];
                }
            }
            Table = newTable;
            Rows = lineCounter + 1;
            Cols = lines[0].Length + 1;
            sam.Release();
            e_read();
            return true;
        }


    }
}



