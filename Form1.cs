using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace SpreadsheetApp
{
    public partial class Form1 : Form
    {
        public static int InitRows;
        public static int InitCols;
        public static bool IsLoadOnce = false;
        SharableSpreadaheet ssp = new SharableSpreadaheet(1, 1);


        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.RespondTextBox.Text = "Please Choose File to Load";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //search string
            //DataTable table = RenderTable(InitRows,InitCols);
            //dataGridView1.DataSource = table;

            string str = this.InputTextBox.Text;
            if (str == "")
            {
                return;
            }
            int row = 0;
            int col = 0;
            bool flag = ssp.searchString(str, ref row, ref col);
            if (flag)
            {
                this.RespondTextBox.Text = "string has found! in cell: (" + row + "," + col + ")";
                this.InputTextBox.Text = "";
                dataGridView1.Rows[row - 1].Cells[col - 1].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            }
            else
            {
                this.RespondTextBox.Text = "string has not found!";
            }
        }

        private void button1_Click(object sender, EventArgs e) //exchange rows
        {
            string loc = this.InputTextBox.Text;
            Regex rx = new Regex(@"(\d+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(loc);
            if (loc == "" || matches.Count == 0)
            {
                this.RespondTextBox.Text = "invalid input, please enter: row1,row2. example: 1,2";
                return;
            }
            int row1 = Convert.ToInt32(matches[0].Value);
            int row2 = Convert.ToInt32(matches[1].Value);

            int Row = 0;
            int Col = 0;
            ssp.getSize(ref Row, ref Col);

            if (row1 < 0 || row1 > Row || row2 < 0 || row2 > Row)
            {
                this.RespondTextBox.Text = "cell not in table!";
                return;
            }
            ssp.exchangeRows(row1, row2);
            DataTable table = RenderTable();
            dataGridView1.DataSource = table;
            this.RespondTextBox.Text = "Rows Has Change Succusfully";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataTable RenderTable()
        {
            DataTable table = new DataTable();
            int cols = 0;
            int rows = 0;
            ssp.getSize(ref rows, ref cols);

            for (int j = 1; j < cols + 1; j++)
            {
                table.Columns.Add(j.ToString());
            }

            for (int i = 1; i < rows + 1; i++)
            {
                object[] param = new object[cols];
                for (int j = 0; j < cols; j++)
                {
                    param[j] = ssp.getCell(i, j + 1);
                }
                table.Rows.Add(param);
            }
            return (table);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var fileName = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);
                    ssp.load(fileName);
                    this.RespondTextBox.Text = fileName;
                    DataTable table = RenderTable();
                    dataGridView1.DataSource = table;
                }
            }

            catch
            {
                MessageBox.Show("Error Ocurrod!! Please insert file name without type.");
            }
        }
        //string TableSize = this.InputTextBox.Text;

        //if (IsLoadOnce)
        //{
        //    CleanTable(ssp);
        //}
        //IsLoadOnce = true;

        //Regex rx = new Regex(@"(\d+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        //MatchCollection matches = rx.Matches(TableSize);
        //if (TableSize == "" || matches.Count == 0)
        //{
        //    this.RespondTextBox.Text = "please enter the size of the SpreadSheet";
        //    return;
        //}
        //InitRows = Convert.ToInt32(matches[0].Value);
        //InitCols = Convert.ToInt32(matches[1].Value);

        //DataTable table = RenderTable(InitRows, InitCols);
        //dataGridView1.DataSource = table;
        //this.RespondTextBox.Text = "Table loaded succusfully";


        private void CleanTable(SharableSpreadaheet ssp)
        {
            for (int i = 1; i < InitRows + 1; i++)
            {
                for (int j = 1; j < InitCols + 1; j++)
                {
                    ssp.setCell(i, j, "");
                }
            }
        }

        private void SetCellButton_Click(object sender, EventArgs e)
        {
            try
            {
                var strCell = dataGridView1.CurrentCell.Value;
                if (strCell is null)
                {
                    ssp.setCell(dataGridView1.CurrentCell.RowIndex + 1, dataGridView1.CurrentCell.ColumnIndex + 1, "");
                }
                else
                {
                    string cell = (string)strCell;
                    ssp.setCell(dataGridView1.CurrentCell.RowIndex + 1, dataGridView1.CurrentCell.ColumnIndex + 1, cell);
                }
                //int x = 0;
                //int y = 0;
                //ssp.getSize(ref x, ref y);
                DataTable table = RenderTable();
                dataGridView1.DataSource = table;
                this.RespondTextBox.Text = "Cell has been set";
            }
            catch (Exception)
            {
                this.RespondTextBox.Text = "Invalid Input";
            }
        }

        private void StringLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void ExchangeColsButton_Click(object sender, EventArgs e)
        {
            string loc = this.InputTextBox.Text;
            Regex rx = new Regex(@"(\d+)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(loc);
            if (loc == "" || matches.Count == 0)
            {
                this.RespondTextBox.Text = "invalid input, please enter: col1,col2. example: 1,2";
                return;
            }
            int col1 = Convert.ToInt32(matches[0].Value);
            int col2 = Convert.ToInt32(matches[1].Value);

            int Row = 0;
            int Col = 0;
            ssp.getSize(ref Row, ref Col);
            if (col1 < 0 || col1 > Col || col2 < 0 || col2 > Col)
            {
                this.RespondTextBox.Text = "cell not in table!";
                return;
            }
            else
            {
                ssp.exchangeCols(col1, col2);
                DataTable table = RenderTable();
                dataGridView1.DataSource = table;
                this.RespondTextBox.Text = "Cols Has Change Succusfully";
            }
        }

        private void button3_Click(object sender, EventArgs e) //add row button
        {
            string row = this.InputTextBox.Text;
            if (row == "" || row.Length != 1)
            {
                this.RespondTextBox.Text = "invalid input, please enter: row. example: 1";
                return;
            }
            try
            {
                int RowToAddAbove = int.Parse(row);
                ssp.addRow(RowToAddAbove);
                DataTable table = RenderTable();
                dataGridView1.DataSource = table;
                this.RespondTextBox.Text = "Row added Succusfully";
            }
            catch (Exception)
            {
                this.RespondTextBox.Text = "invalid input, please enter: row. example: 1";
                return;
            }
        }

        private void AddColButton_Click(object sender, EventArgs e)
        {
            string col = this.InputTextBox.Text;
            if (col == "")
            {
                this.RespondTextBox.Text = "invalid input, please enter: col. example: 1";
                return;
            }
            int ColToAdd = int.Parse(col);
            ssp.addCol(ColToAdd);
            DataTable table = RenderTable();
            dataGridView1.DataSource = table;
            this.RespondTextBox.Text = "Col added Succusfully";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ssp.save(sfd.FileName);
                    this.RespondTextBox.Text = "File saved Succusfully";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("File Count not be saved");
                this.RespondTextBox.Text = ofd.FileName;
            }
        }
    }
}