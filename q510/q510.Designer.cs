namespace q510
{
    partial class q510
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(q510));
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.childPictureBox = new System.Windows.Forms.PictureBox();
            this.motherPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.intervalButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.callButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.childPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 20;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // childPictureBox
            // 
            this.childPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("childPictureBox.Image")));
            this.childPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("childPictureBox.InitialImage")));
            this.childPictureBox.Location = new System.Drawing.Point(350, 234);
            this.childPictureBox.Name = "childPictureBox";
            this.childPictureBox.Size = new System.Drawing.Size(122, 118);
            this.childPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.childPictureBox.TabIndex = 0;
            this.childPictureBox.TabStop = false;
            // 
            // motherPictureBox
            // 
            this.motherPictureBox.Image = global::q510.Properties.Resources.mother;
            this.motherPictureBox.InitialImage = global::q510.Properties.Resources.mother;
            this.motherPictureBox.Location = new System.Drawing.Point(21, 22);
            this.motherPictureBox.Name = "motherPictureBox";
            this.motherPictureBox.Size = new System.Drawing.Size(120, 117);
            this.motherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.motherPictureBox.TabIndex = 1;
            this.motherPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Promise to Call More Often";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Happy Mother\'s Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "-Patrick Xie";
            // 
            // intervalButton
            // 
            this.intervalButton.Location = new System.Drawing.Point(119, 260);
            this.intervalButton.Name = "intervalButton";
            this.intervalButton.Size = new System.Drawing.Size(93, 23);
            this.intervalButton.TabIndex = 5;
            this.intervalButton.Text = "Set Call Speed";
            this.intervalButton.UseVisualStyleBackColor = true;
            this.intervalButton.Click += new System.EventHandler(this.intervalButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // callButton
            // 
            this.callButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callButton.Location = new System.Drawing.Point(283, 331);
            this.callButton.Name = "callButton";
            this.callButton.Size = new System.Drawing.Size(61, 23);
            this.callButton.TabIndex = 7;
            this.callButton.Text = "Hang Up";
            this.callButton.UseVisualStyleBackColor = true;
            this.callButton.Click += new System.EventHandler(this.callButton_Click);
            // 
            // q510
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 366);
            this.Controls.Add(this.callButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.intervalButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.motherPictureBox);
            this.Controls.Add(this.childPictureBox);
            this.DoubleBuffered = true;
            this.Name = "q510";
            this.Text = "Quest 510 -- Patrick Xie";
            this.Load += new System.EventHandler(this.q510_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.q510_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.childPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.PictureBox childPictureBox;
        private System.Windows.Forms.PictureBox motherPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button intervalButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button callButton;

    }
}

