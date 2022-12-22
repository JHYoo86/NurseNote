
namespace NurseNote
{
    partial class DrCdMng
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
            FarPoint.Win.Spread.CellType.TextCellType textCellType5 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType6 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType7 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType8 = new FarPoint.Win.Spread.CellType.TextCellType();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.ssList = new FarPoint.Win.Spread.FpSpread();
            this.ssList_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.ssList2 = new FarPoint.Win.Spread.FpSpread();
            this.ssList2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ssList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList2_Sheet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 23);
            this.panel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "진료의사 코드관리";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 40);
            this.panel1.TabIndex = 16;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAdd.Location = new System.Drawing.Point(351, 3);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(104, 34);
            this.BtnAdd.TabIndex = 22;
            this.BtnAdd.Text = "추가";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnDelete.Location = new System.Drawing.Point(559, 3);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(104, 34);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSave.Location = new System.Drawing.Point(455, 3);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(104, 34);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSearch.Location = new System.Drawing.Point(247, 3);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(104, 34);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.Text = "조회";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // ssList
            // 
            this.ssList.AccessibleDescription = "";
            this.ssList.Dock = System.Windows.Forms.DockStyle.Left;
            this.ssList.Location = new System.Drawing.Point(0, 63);
            this.ssList.Margin = new System.Windows.Forms.Padding(4);
            this.ssList.Name = "ssList";
            this.ssList.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ssList_Sheet1});
            this.ssList.Size = new System.Drawing.Size(372, 574);
            this.ssList.TabIndex = 17;
            this.ssList.SelectionChanged += new FarPoint.Win.Spread.SelectionChangedEventHandler(this.ssList_SelectionChanged);
            // 
            // ssList_Sheet1
            // 
            this.ssList_Sheet1.Reset();
            this.ssList_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ssList_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            ssList_Sheet1.ColumnCount = 2;
            ssList_Sheet1.RowCount = 1;
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "코드";
            this.ssList_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "명칭";
            this.ssList_Sheet1.Columns.Get(0).CellType = textCellType5;
            this.ssList_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(0).Label = "코드";
            this.ssList_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(0).Width = 109F;
            this.ssList_Sheet1.Columns.Get(1).CellType = textCellType6;
            this.ssList_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(1).Label = "명칭";
            this.ssList_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList_Sheet1.Columns.Get(1).Width = 207F;
            this.ssList_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.ReadOnly;
            this.ssList_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.ssList_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // ssList2
            // 
            this.ssList2.AccessibleDescription = "ssList2, Sheet1, Row 0, Column 0, ";
            this.ssList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssList2.Location = new System.Drawing.Point(372, 63);
            this.ssList2.Margin = new System.Windows.Forms.Padding(4);
            this.ssList2.Name = "ssList2";
            this.ssList2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.ssList2_Sheet1});
            this.ssList2.Size = new System.Drawing.Size(657, 574);
            this.ssList2.TabIndex = 18;
            // 
            // ssList2_Sheet1
            // 
            this.ssList2_Sheet1.Reset();
            this.ssList2_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.ssList2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            ssList2_Sheet1.ColumnCount = 3;
            ssList2_Sheet1.RowCount = 1;
            this.ssList2_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "의사코드";
            this.ssList2_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "의사이름";
            this.ssList2_Sheet1.Columns.Get(0).CellType = textCellType7;
            this.ssList2_Sheet1.Columns.Get(0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList2_Sheet1.Columns.Get(0).Label = "의사코드";
            this.ssList2_Sheet1.Columns.Get(0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList2_Sheet1.Columns.Get(0).Width = 109F;
            this.ssList2_Sheet1.Columns.Get(1).CellType = textCellType8;
            this.ssList2_Sheet1.Columns.Get(1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.ssList2_Sheet1.Columns.Get(1).Label = "의사이름";
            this.ssList2_Sheet1.Columns.Get(1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.ssList2_Sheet1.Columns.Get(1).Width = 192F;
            this.ssList2_Sheet1.Columns.Get(2).Visible = false;
            this.ssList2_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.ssList2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnSearch);
            this.panel3.Controls.Add(this.BtnAdd);
            this.panel3.Controls.Add(this.BtnSave);
            this.panel3.Controls.Add(this.BtnDelete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(363, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(666, 40);
            this.panel3.TabIndex = 23;
            // 
            // DrCdMng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 637);
            this.Controls.Add(this.ssList2);
            this.Controls.Add(this.ssList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DrCdMng";
            this.Text = "DrCdMng";
            this.Load += new System.EventHandler(this.DrCdMng_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ssList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssList2_Sheet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnSearch;
        private FarPoint.Win.Spread.FpSpread ssList;
        private FarPoint.Win.Spread.SheetView ssList_Sheet1;
        private FarPoint.Win.Spread.FpSpread ssList2;
        private FarPoint.Win.Spread.SheetView ssList2_Sheet1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel panel3;
    }
}