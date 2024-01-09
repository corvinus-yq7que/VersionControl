namespace Gift
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnBallColor = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnBall = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPresent = new System.Windows.Forms.Button();
            this.btnPresentColor1 = new System.Windows.Forms.Button();
            this.btnPresentColor2 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.btnPresentColor2);
            this.mainPanel.Controls.Add(this.btnPresentColor1);
            this.mainPanel.Controls.Add(this.btnPresent);
            this.mainPanel.Controls.Add(this.btnBallColor);
            this.mainPanel.Controls.Add(this.lblNext);
            this.mainPanel.Controls.Add(this.btnBall);
            this.mainPanel.Controls.Add(this.btnCar);
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(801, 451);
            this.mainPanel.TabIndex = 0;
            // 
            // btnBallColor
            // 
            this.btnBallColor.Location = new System.Drawing.Point(181, 89);
            this.btnBallColor.Name = "btnBallColor";
            this.btnBallColor.Size = new System.Drawing.Size(101, 33);
            this.btnBallColor.TabIndex = 3;
            this.btnBallColor.UseVisualStyleBackColor = true;
            this.btnBallColor.Click += new System.EventHandler(this.btnBallColor_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(460, 44);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(101, 20);
            this.lblNext.TabIndex = 2;
            this.lblNext.Text = "Coming next:";
            // 
            // btnBall
            // 
            this.btnBall.Location = new System.Drawing.Point(181, 35);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(101, 38);
            this.btnBall.TabIndex = 1;
            this.btnBall.Text = "BALL";
            this.btnBall.UseVisualStyleBackColor = true;
            this.btnBall.Click += new System.EventHandler(this.btnBall_Click);
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(40, 35);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(101, 38);
            this.btnCar.TabIndex = 0;
            this.btnCar.Text = "CAR";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // createTimer
            // 
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btnPresent
            // 
            this.btnPresent.Location = new System.Drawing.Point(329, 35);
            this.btnPresent.Name = "btnPresent";
            this.btnPresent.Size = new System.Drawing.Size(101, 38);
            this.btnPresent.TabIndex = 4;
            this.btnPresent.Text = "Present";
            this.btnPresent.UseVisualStyleBackColor = true;
            this.btnPresent.Click += new System.EventHandler(this.btnPresent_Click);
            // 
            // btnPresentColor1
            // 
            this.btnPresentColor1.Location = new System.Drawing.Point(329, 89);
            this.btnPresentColor1.Name = "btnPresentColor1";
            this.btnPresentColor1.Size = new System.Drawing.Size(101, 33);
            this.btnPresentColor1.TabIndex = 5;
            this.btnPresentColor1.UseVisualStyleBackColor = true;
            this.btnPresentColor1.Click += new System.EventHandler(this.btnPresentColor1_Click);
            // 
            // btnPresentColor2
            // 
            this.btnPresentColor2.Location = new System.Drawing.Point(329, 128);
            this.btnPresentColor2.Name = "btnPresentColor2";
            this.btnPresentColor2.Size = new System.Drawing.Size(101, 33);
            this.btnPresentColor2.TabIndex = 6;
            this.btnPresentColor2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnBallColor;
        private System.Windows.Forms.Button btnPresent;
        private System.Windows.Forms.Button btnPresentColor2;
        private System.Windows.Forms.Button btnPresentColor1;
    }
}

