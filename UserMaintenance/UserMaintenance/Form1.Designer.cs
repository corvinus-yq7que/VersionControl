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
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
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
            // txtLastName
            // 
            txtLastName.Location = new Point(459, 68);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(288, 31);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(459, 123);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(288, 31);
            txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(394, 68);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(59, 25);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "label1";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(394, 126);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(59, 25);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "label2";
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
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(listUsers);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listUsers;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnAdd;
    }
}