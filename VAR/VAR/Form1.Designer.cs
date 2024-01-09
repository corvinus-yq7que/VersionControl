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
            ((System.ComponentModel.ISupportInitialize)(this.dgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw
            // 
            this.dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw.Location = new System.Drawing.Point(57, 43);
            this.dgw.Name = "dgw";
            this.dgw.RowHeadersWidth = 62;
            this.dgw.RowTemplate.Height = 28;
            this.dgw.Size = new System.Drawing.Size(235, 301);
            this.dgw.TabIndex = 0;
            // 
            // dgw2
            // 
            this.dgw2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw2.Location = new System.Drawing.Point(413, 43);
            this.dgw2.Name = "dgw2";
            this.dgw2.RowHeadersWidth = 62;
            this.dgw2.RowTemplate.Height = 28;
            this.dgw2.Size = new System.Drawing.Size(283, 301);
            this.dgw2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

