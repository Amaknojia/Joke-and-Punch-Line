namespace JokeandPunchline
{
    partial class frmJokeandPunchLine
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
            this.jplabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jplabel
            // 
            this.jplabel.AutoSize = true;
            this.jplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jplabel.Location = new System.Drawing.Point(148, 60);
            this.jplabel.MaximumSize = new System.Drawing.Size(100, 50);
            this.jplabel.MinimumSize = new System.Drawing.Size(500, 60);
            this.jplabel.Name = "jplabel";
            this.jplabel.Size = new System.Drawing.Size(500, 60);
            this.jplabel.TabIndex = 0;
            this.jplabel.Text = "Joke and Punch Line";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Setup";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Punch Line";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmJokeandPunchLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jplabel);
            this.Name = "frmJokeandPunchLine";
            this.Text = "Joke and Punch Line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jplabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

