
namespace NurseNote
{
    partial class regPatMemo
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
            FarPoint.Win.Spread.CellType.TextCellType textCellType7 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType8 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType9 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType10 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType11 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType12 = new FarPoint.Win.Spread.CellType.TextCellType();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ssList = new FarPoint.Win.Spread.FpSpread();
            this.ssList_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList_Sheet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 23);
            this.panel2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "재원환자관리";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 40);
            this.panel1.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 29);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "◀";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "▶";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ssList
            // 
            this.ssList.AccessibleDescription = "ssList, Sheet1, Row 0, Column 0, ";
            this.ssList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssList.Location = new System.Drawing.Point(0, 63);
            this.ssList.Margin = new System.Windows.Forms.Padding(4);
            this.ssList.Name = "ssList";
            this.ssList.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ssList_Sheet1});
            this.ssList.Size = new System.Drawing.Size(1130, 574);
            this.ssList.TabIndex = 17;
            // 
            // ssList_Sheet1
            // 
            this.ssList_Sheet1.Reset();
            this.ssList_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ssList_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            ssList_Sheet1.ColumnCount = 12;
            ssList_Sheet1.RowCount = 1;
            this.ssList_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "병동";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "병실";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "환자번호";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "환자이름";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "입원일자";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "수술일자";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "성별";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "나이";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "진료과";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "진료의";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 10).Value = "POD";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 11).Value = "메모";
            this.ssList_Sheet1.Columns.Get(2).CellType = textCellType7;
            this.ssList_Sheet1.Columns.Get(2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(2).Label = "환자번호";
            this.ssList_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(2).Width = 109F;
            this.ssList_Sheet1.Columns.Get(3).CellType = textCellType8;
            this.ssList_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(3).Label = "환자이름";
            this.ssList_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(3).Width = 133F;
            this.ssList_Sheet1.Columns.Get(4).Label = "입원일자";
            this.ssList_Sheet1.Columns.Get(4).Width = 81F;
            this.ssList_Sheet1.Columns.Get(5).Label = "수술일자";
            this.ssList_Sheet1.Columns.Get(5).Width = 79F;
            this.ssList_Sheet1.Columns.Get(6).CellType = textCellType9;
            this.ssList_Sheet1.Columns.Get(6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(6).Label = "성별";
            this.ssList_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(7).CellType = textCellType10;
            this.ssList_Sheet1.Columns.Get(7).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(7).Label = "나이";
            this.ssList_Sheet1.Columns.Get(7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(8).CellType = textCellType11;
            this.ssList_Sheet1.Columns.Get(8).Label = "진료과";
            this.ssList_Sheet1.Columns.Get(8).Width = 80F;
            this.ssList_Sheet1.Columns.Get(9).CellType = textCellType12;
            this.ssList_Sheet1.Columns.Get(9).Label = "진료의";
            this.ssList_Sheet1.Columns.Get(9).Width = 100F;
            this.ssList_Sheet1.Columns.Get(11).Label = "메모";
            this.ssList_Sheet1.Columns.Get(11).Width = 344F;
            this.ssList_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.ReadOnly;
            this.ssList_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.ssList_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(876, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(254, 40);
            this.panel3.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSave.Location = new System.Drawing.Point(147, 3);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(104, 34);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(876, 40);
            this.panel4.TabIndex = 4;
            // 
            // regPatMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1130, 637);
            this.Controls.Add(this.ssList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "regPatMemo";
            this.Text = "regPatMemo";
            this.Load += new System.EventHandler(this.regPatMemo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ssList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList_Sheet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FarPoint.Win.Spread.FpSpread ssList;
        private FarPoint.Win.Spread.SheetView ssList_Sheet1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnSave;
    }
}