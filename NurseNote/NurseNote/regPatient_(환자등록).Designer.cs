
namespace NurseNote
{
    partial class regPatient
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
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType2 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType3 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType4 = new FarPoint.Win.Spread.CellType.TextCellType();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPTNO = new System.Windows.Forms.TextBox();
            this.TxtPTNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSSNO1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSSNO2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ssList = new FarPoint.Win.Spread.FpSpread();
            this.ssList_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 149);
            this.panel1.TabIndex = 1;
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(389, 4);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(104, 38);
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "클리어";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(701, 4);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(104, 38);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(805, 4);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(104, 38);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "닫기";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(597, 4);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(104, 38);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(493, 4);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(104, 38);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.Text = "조회";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 23);
            this.panel2.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtPTNO);
            this.groupBox1.Controls.Add(this.TxtPTNAME);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtSSNO1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtSSNO2);
            this.groupBox1.Location = new System.Drawing.Point(13, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(896, 89);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "환자정보";
            // 
            // TxtPTNO
            // 
            this.TxtPTNO.Location = new System.Drawing.Point(76, 37);
            this.TxtPTNO.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPTNO.Name = "TxtPTNO";
            this.TxtPTNO.Size = new System.Drawing.Size(156, 25);
            this.TxtPTNO.TabIndex = 0;
            // 
            // TxtPTNAME
            // 
            this.TxtPTNAME.Location = new System.Drawing.Point(327, 37);
            this.TxtPTNAME.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPTNAME.Name = "TxtPTNAME";
            this.TxtPTNAME.Size = new System.Drawing.Size(179, 25);
            this.TxtPTNAME.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "환자번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "환자이름";
            // 
            // TxtSSNO1
            // 
            this.TxtSSNO1.Location = new System.Drawing.Point(606, 37);
            this.TxtSSNO1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSSNO1.Name = "TxtSSNO1";
            this.TxtSSNO1.Size = new System.Drawing.Size(124, 25);
            this.TxtSSNO1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "주민번호";
            // 
            // TxtSSNO2
            // 
            this.TxtSSNO2.Location = new System.Drawing.Point(730, 37);
            this.TxtSSNO2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSSNO2.Name = "TxtSSNO2";
            this.TxtSSNO2.Size = new System.Drawing.Size(145, 25);
            this.TxtSSNO2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "환자등록";
            // 
            // ssList
            // 
            this.ssList.AccessibleDescription = "";
            this.ssList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssList.Location = new System.Drawing.Point(0, 172);
            this.ssList.Margin = new System.Windows.Forms.Padding(4);
            this.ssList.Name = "ssList";
            this.ssList.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ssList_Sheet1});
            this.ssList.Size = new System.Drawing.Size(919, 743);
            this.ssList.TabIndex = 14;
            // 
            // ssList_Sheet1
            // 
            this.ssList_Sheet1.Reset();
            this.ssList_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ssList_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            ssList_Sheet1.ColumnCount = 4;
            ssList_Sheet1.RowCount = 1;
            this.ssList_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "환자번호";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "환자이름";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "주민번호1";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "주민번호2";
            this.ssList_Sheet1.Columns.Get(0).CellType = textCellType1;
            this.ssList_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(0).Label = "환자번호";
            this.ssList_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(0).Width = 109F;
            this.ssList_Sheet1.Columns.Get(1).CellType = textCellType2;
            this.ssList_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(1).Label = "환자이름";
            this.ssList_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(1).Width = 133F;
            this.ssList_Sheet1.Columns.Get(2).CellType = textCellType3;
            this.ssList_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(2).Label = "주민번호1";
            this.ssList_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(2).Width = 110F;
            this.ssList_Sheet1.Columns.Get(3).CellType = textCellType4;
            this.ssList_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(3).Label = "주민번호2";
            this.ssList_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(3).Width = 120F;
            this.ssList_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.ReadOnly;
            this.ssList_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.ssList_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // regPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(919, 915);
            this.Controls.Add(this.ssList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "regPatient";
            this.Text = "(주)두나소프트 - 똥수기 기록지 Ver1.0";
            this.Load += new System.EventHandler(this.regPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPTNO;
        private System.Windows.Forms.TextBox TxtPTNAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSSNO1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSSNO2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private FarPoint.Win.Spread.FpSpread ssList;
        private FarPoint.Win.Spread.SheetView ssList_Sheet1;
    }
}