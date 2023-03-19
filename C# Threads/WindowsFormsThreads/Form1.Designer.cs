namespace WindowsFormsThreads
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
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnellipse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYellow
            // 
            this.btnYellow.Location = new System.Drawing.Point(194, 146);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(111, 42);
            this.btnYellow.TabIndex = 0;
            this.btnYellow.Text = "button1";
            this.btnYellow.UseVisualStyleBackColor = true;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(343, 146);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(111, 42);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.Text = "button2";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(486, 146);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(111, 42);
            this.btnRed.TabIndex = 2;
            this.btnRed.Text = "button3";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnellipse
            // 
            this.btnellipse.Location = new System.Drawing.Point(345, 204);
            this.btnellipse.Name = "btnellipse";
            this.btnellipse.Size = new System.Drawing.Size(111, 42);
            this.btnellipse.TabIndex = 3;
            this.btnellipse.Text = "button4";
            this.btnellipse.UseVisualStyleBackColor = true;
            this.btnellipse.Click += new System.EventHandler(this.btnellipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnellipse);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnYellow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnellipse;
    }
}

