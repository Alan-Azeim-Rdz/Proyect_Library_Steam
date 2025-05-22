namespace Proyect_Library_Steam
{
    partial class Search_Games
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
            BrnSearch = new Button();
            TextAppID = new TextBox();
            DataGridLogros = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataGridLogros).BeginInit();
            SuspendLayout();
            // 
            // BrnSearch
            // 
            BrnSearch.Location = new Point(91, 164);
            BrnSearch.Name = "BrnSearch";
            BrnSearch.Size = new Size(126, 53);
            BrnSearch.TabIndex = 0;
            BrnSearch.Text = "Buscar";
            BrnSearch.UseVisualStyleBackColor = true;
            BrnSearch.Click += BrnSearch_Click;
            // 
            // TextAppID
            // 
            TextAppID.Location = new Point(33, 106);
            TextAppID.Name = "TextAppID";
            TextAppID.Size = new Size(252, 23);
            TextAppID.TabIndex = 4;
            // 
            // DataGridLogros
            // 
            DataGridLogros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridLogros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            DataGridLogros.Location = new Point(376, 12);
            DataGridLogros.Name = "DataGridLogros";
            DataGridLogros.Size = new Size(683, 558);
            DataGridLogros.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "Logo";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Descripccion";
            Column3.Name = "Column3";
            // 
            // Search_Games
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 582);
            Controls.Add(DataGridLogros);
            Controls.Add(TextAppID);
            Controls.Add(BrnSearch);
            Name = "Search_Games";
            Text = "Shearch_Games";
            ((System.ComponentModel.ISupportInitialize)DataGridLogros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BrnSearch;
        private TextBox TextAppID;
        private DataGridView DataGridLogros;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}