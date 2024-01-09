namespace VAR
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
            this.dgw = new System.Windows.Forms.DataGridView();
            this.dgw2 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.IdőszakColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NyereségColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw
            // 
            this.dgw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdőszakColumn,
            this.NyereségColumn});
            this.dgw.Location = new System.Drawing.Point(12, 27);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 62;
            this.dgw.RowTemplate.Height = 28;
            this.dgw.Size = new System.Drawing.Size(758, 220);
            this.dgw.TabIndex = 0;
            // 
            // dgw2
            // 
            this.dgw2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw2.Location = new System.Drawing.Point(12, 270);
            this.dgw2.Name = "dgw2";
            this.dgw2.RowHeadersWidth = 62;
            this.dgw2.RowTemplate.Height = 28;
            this.dgw2.Size = new System.Drawing.Size(758, 301);
            this.dgw2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(880, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 102);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // IdőszakColumn
            // 
            this.IdőszakColumn.HeaderText = "Időszak";
            this.IdőszakColumn.MinimumWidth = 8;
            this.IdőszakColumn.Name = "IdőszakColumn";
            this.IdőszakColumn.Width = 150;
            // 
            // NyereségColumn
            // 
            this.NyereségColumn.HeaderText = "Nyereség";
            this.NyereségColumn.MinimumWidth = 8;
            this.NyereségColumn.Name = "NyereségColumn";
            this.NyereségColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 583);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgw2);
            this.Controls.Add(this.dgw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw;
        private System.Windows.Forms.DataGridView dgw2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdőszakColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NyereségColumn;
    }
}

