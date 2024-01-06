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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(50, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(305, 329);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(459, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(459, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(288, 31);
            textBox2.TabIndex = 2;
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
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnAdd;
    }
}