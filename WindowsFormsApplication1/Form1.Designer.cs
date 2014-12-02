namespace WindowsFormsApplication1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Excel_Theirs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.DataCount_Correct = new System.Windows.Forms.Label();
            this.DataCount_BeChanged = new System.Windows.Forms.Label();
            this.DataCount_CantMatch = new System.Windows.Forms.Label();
            this.DataCount_Merge = new System.Windows.Forms.Label();
            this.Excel2JSON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenExcel
            // 
            this.OpenExcel.Location = new System.Drawing.Point(8, 7);
            this.OpenExcel.Name = "OpenExcel";
            this.OpenExcel.Size = new System.Drawing.Size(134, 51);
            this.OpenExcel.TabIndex = 1;
            this.OpenExcel.Text = "Excel - going to be change";
            this.OpenExcel.UseVisualStyleBackColor = true;
            this.OpenExcel.Click += new System.EventHandler(this.OpenMine_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(387, 207);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(418, 104);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(372, 207);
            this.dataGridView2.TabIndex = 5;
            // 
            // Excel_Theirs
            // 
            this.Excel_Theirs.Location = new System.Drawing.Point(421, 7);
            this.Excel_Theirs.Name = "Excel_Theirs";
            this.Excel_Theirs.Size = new System.Drawing.Size(134, 51);
            this.Excel_Theirs.TabIndex = 4;
            this.Excel_Theirs.Text = "Excel_Correct Data";
            this.Excel_Theirs.UseVisualStyleBackColor = true;
            this.Excel_Theirs.Click += new System.EventHandler(this.Excel_Theirs_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.RunProgram_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Export this to Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExportMine_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(818, 104);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(313, 207);
            this.dataGridView3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data Can\'t Find Collection";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(684, 7);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(109, 23);
            this.search.TabIndex = 9;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(938, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Export this to Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ExportMissing_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Merge";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.merge_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(8, 346);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(387, 207);
            this.dataGridView4.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(123, 317);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Export this to Excel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ExportMerge_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "SQLCommand";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(561, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "SQLCommand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Data Going to be changed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Standard Data to modify other ( won\'t change )";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(938, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "Column Names List";
            // 
            // DataCount_Correct
            // 
            this.DataCount_Correct.AutoSize = true;
            this.DataCount_Correct.Location = new System.Drawing.Point(669, 74);
            this.DataCount_Correct.Name = "DataCount_Correct";
            this.DataCount_Correct.Size = new System.Drawing.Size(67, 13);
            this.DataCount_Correct.TabIndex = 20;
            this.DataCount_Correct.Text = "DataCount : ";
            // 
            // DataCount_BeChanged
            // 
            this.DataCount_BeChanged.AutoSize = true;
            this.DataCount_BeChanged.Location = new System.Drawing.Point(248, 74);
            this.DataCount_BeChanged.Name = "DataCount_BeChanged";
            this.DataCount_BeChanged.Size = new System.Drawing.Size(67, 13);
            this.DataCount_BeChanged.TabIndex = 21;
            this.DataCount_BeChanged.Text = "DataCount : ";
            // 
            // DataCount_CantMatch
            // 
            this.DataCount_CantMatch.AutoSize = true;
            this.DataCount_CantMatch.Location = new System.Drawing.Point(1003, 74);
            this.DataCount_CantMatch.Name = "DataCount_CantMatch";
            this.DataCount_CantMatch.Size = new System.Drawing.Size(67, 13);
            this.DataCount_CantMatch.TabIndex = 22;
            this.DataCount_CantMatch.Text = "DataCount : ";
            // 
            // DataCount_Merge
            // 
            this.DataCount_Merge.AutoSize = true;
            this.DataCount_Merge.Location = new System.Drawing.Point(251, 322);
            this.DataCount_Merge.Name = "DataCount_Merge";
            this.DataCount_Merge.Size = new System.Drawing.Size(67, 13);
            this.DataCount_Merge.TabIndex = 23;
            this.DataCount_Merge.Text = "DataCount : ";
            // 
            // Excel2JSON
            // 
            this.Excel2JSON.Location = new System.Drawing.Point(277, 7);
            this.Excel2JSON.Name = "Excel2JSON";
            this.Excel2JSON.Size = new System.Drawing.Size(118, 23);
            this.Excel2JSON.TabIndex = 24;
            this.Excel2JSON.Text = "Export this to JSON";
            this.Excel2JSON.UseVisualStyleBackColor = true;
            this.Excel2JSON.Click += new System.EventHandler(this.Excel2JSON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 562);
            this.Controls.Add(this.Excel2JSON);
            this.Controls.Add(this.DataCount_Merge);
            this.Controls.Add(this.DataCount_CantMatch);
            this.Controls.Add(this.DataCount_BeChanged);
            this.Controls.Add(this.DataCount_Correct);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Excel_Theirs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OpenExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Excel_Theirs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label DataCount_Correct;
        private System.Windows.Forms.Label DataCount_BeChanged;
        private System.Windows.Forms.Label DataCount_CantMatch;
        private System.Windows.Forms.Label DataCount_Merge;
        private System.Windows.Forms.Button Excel2JSON;
    }
}

