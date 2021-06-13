
namespace SpreadsheetApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.InputResponsePanel = new System.Windows.Forms.Panel();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.InputLabelTextBox = new System.Windows.Forms.Label();
            this.RespondTextBox = new System.Windows.Forms.TextBox();
            this.RespondLabel = new System.Windows.Forms.Label();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.AddColButton = new System.Windows.Forms.Button();
            this.SetCellButton = new System.Windows.Forms.Button();
            this.ExchangeColsButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.SearchStringButton = new System.Windows.Forms.Button();
            this.ExchangeRows = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.InputResponsePanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.InputResponsePanel);
            this.panel1.Controls.Add(this.buttonsPanel);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1458, 1075);
            this.panel1.TabIndex = 0;
            // 
            // InputResponsePanel
            // 
            this.InputResponsePanel.Controls.Add(this.InputTextBox);
            this.InputResponsePanel.Controls.Add(this.InputLabelTextBox);
            this.InputResponsePanel.Controls.Add(this.RespondTextBox);
            this.InputResponsePanel.Controls.Add(this.RespondLabel);
            this.InputResponsePanel.Location = new System.Drawing.Point(13, 125);
            this.InputResponsePanel.Name = "InputResponsePanel";
            this.InputResponsePanel.Size = new System.Drawing.Size(1425, 100);
            this.InputResponsePanel.TabIndex = 15;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.InputTextBox.Location = new System.Drawing.Point(214, 25);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(186, 55);
            this.InputTextBox.TabIndex = 10;
            // 
            // InputLabelTextBox
            // 
            this.InputLabelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputLabelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.InputLabelTextBox.Location = new System.Drawing.Point(102, 30);
            this.InputLabelTextBox.Name = "InputLabelTextBox";
            this.InputLabelTextBox.Size = new System.Drawing.Size(190, 35);
            this.InputLabelTextBox.TabIndex = 9;
            this.InputLabelTextBox.Text = "Input:";
            this.InputLabelTextBox.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // RespondTextBox
            // 
            this.RespondTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RespondTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RespondTextBox.Location = new System.Drawing.Point(871, 19);
            this.RespondTextBox.Multiline = true;
            this.RespondTextBox.Name = "RespondTextBox";
            this.RespondTextBox.Size = new System.Drawing.Size(524, 61);
            this.RespondTextBox.TabIndex = 8;
            // 
            // RespondLabel
            // 
            this.RespondLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RespondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RespondLabel.Location = new System.Drawing.Point(696, 30);
            this.RespondLabel.Name = "RespondLabel";
            this.RespondLabel.Size = new System.Drawing.Size(190, 47);
            this.RespondLabel.TabIndex = 7;
            this.RespondLabel.Text = "Response:";
            this.RespondLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsPanel.AutoSize = true;
            this.buttonsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonsPanel.Controls.Add(this.SaveButton);
            this.buttonsPanel.Controls.Add(this.LoadButton);
            this.buttonsPanel.Controls.Add(this.AddColButton);
            this.buttonsPanel.Controls.Add(this.SetCellButton);
            this.buttonsPanel.Controls.Add(this.ExchangeColsButton);
            this.buttonsPanel.Controls.Add(this.AddRowButton);
            this.buttonsPanel.Controls.Add(this.SearchStringButton);
            this.buttonsPanel.Controls.Add(this.ExchangeRows);
            this.buttonsPanel.Location = new System.Drawing.Point(16, 11);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(2780, 104);
            this.buttonsPanel.TabIndex = 14;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.Teal;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveButton.Location = new System.Drawing.Point(1316, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(123, 46);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LoadButton.Location = new System.Drawing.Point(3, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(121, 46);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // AddColButton
            // 
            this.AddColButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddColButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AddColButton.Location = new System.Drawing.Point(1163, 4);
            this.AddColButton.Name = "AddColButton";
            this.AddColButton.Size = new System.Drawing.Size(147, 46);
            this.AddColButton.TabIndex = 13;
            this.AddColButton.Text = "Add Col";
            this.AddColButton.UseVisualStyleBackColor = true;
            this.AddColButton.Click += new System.EventHandler(this.AddColButton_Click);
            // 
            // SetCellButton
            // 
            this.SetCellButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetCellButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SetCellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SetCellButton.Location = new System.Drawing.Point(130, 3);
            this.SetCellButton.Name = "SetCellButton";
            this.SetCellButton.Size = new System.Drawing.Size(159, 47);
            this.SetCellButton.TabIndex = 1;
            this.SetCellButton.Text = "Set Value";
            this.SetCellButton.UseVisualStyleBackColor = true;
            this.SetCellButton.Click += new System.EventHandler(this.SetCellButton_Click);
            // 
            // ExchangeColsButton
            // 
            this.ExchangeColsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExchangeColsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ExchangeColsButton.Location = new System.Drawing.Point(760, 4);
            this.ExchangeColsButton.Name = "ExchangeColsButton";
            this.ExchangeColsButton.Size = new System.Drawing.Size(230, 46);
            this.ExchangeColsButton.TabIndex = 11;
            this.ExchangeColsButton.Text = "Exchange Cols";
            this.ExchangeColsButton.UseVisualStyleBackColor = true;
            this.ExchangeColsButton.Click += new System.EventHandler(this.ExchangeColsButton_Click);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.AddRowButton.Location = new System.Drawing.Point(996, 4);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(161, 46);
            this.AddRowButton.TabIndex = 12;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchStringButton
            // 
            this.SearchStringButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchStringButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.SearchStringButton.Location = new System.Drawing.Point(295, 3);
            this.SearchStringButton.Name = "SearchStringButton";
            this.SearchStringButton.Size = new System.Drawing.Size(210, 47);
            this.SearchStringButton.TabIndex = 3;
            this.SearchStringButton.Text = "Search String";
            this.SearchStringButton.UseVisualStyleBackColor = true;
            this.SearchStringButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // ExchangeRows
            // 
            this.ExchangeRows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExchangeRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ExchangeRows.Location = new System.Drawing.Point(511, 3);
            this.ExchangeRows.Name = "ExchangeRows";
            this.ExchangeRows.Size = new System.Drawing.Size(243, 47);
            this.ExchangeRows.TabIndex = 2;
            this.ExchangeRows.Text = "Exchange Rows";
            this.ExchangeRows.UseVisualStyleBackColor = true;
            this.ExchangeRows.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(13, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1425, 683);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "csv";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C\\:";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Browse Text Files";
            this.openFileDialog1.HelpRequest += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 922);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.InputResponsePanel.ResumeLayout(false);
            this.InputResponsePanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SetCellButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SearchStringButton;
        private System.Windows.Forms.Button ExchangeRows;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddColButton;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button ExchangeColsButton;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel InputResponsePanel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label InputLabelTextBox;
        private System.Windows.Forms.TextBox RespondTextBox;
        private System.Windows.Forms.Label RespondLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

