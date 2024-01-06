namespace UserMaintenance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listUsers = new ListBox();
            this.txtFullName = new TextBox();
            lblFullName = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // listUsers
            // 
            listUsers.FormattingEnabled = true;
            listUsers.ItemHeight = 25;
            listUsers.Location = new Point(50, 50);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(305, 329);
            listUsers.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new Point(459, 107);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new Size(288, 31);
            this.txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(394, 107);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(59, 25);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "label1";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(394, 190);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(353, 53);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(lblFullName);
            Controls.Add(this.txtFullName);
            Controls.Add(listUsers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listUsers;
        private TextBox txtFullName;
        private Label lblFullName;
        private Button btnAdd;
    }
}