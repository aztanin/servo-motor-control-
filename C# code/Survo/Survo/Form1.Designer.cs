namespace Survo
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
            this.trackBarRange = new System.Windows.Forms.TrackBar();
            this.txtDegree = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRange)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarRange
            // 
            this.trackBarRange.Location = new System.Drawing.Point(257, 184);
            this.trackBarRange.Maximum = 180;
            this.trackBarRange.Minimum = 10;
            this.trackBarRange.Name = "trackBarRange";
            this.trackBarRange.Size = new System.Drawing.Size(377, 45);
            this.trackBarRange.TabIndex = 0;
            this.trackBarRange.Value = 10;
            this.trackBarRange.Scroll += new System.EventHandler(this.trackBarRange_Scroll);
            // 
            // txtDegree
            // 
            this.txtDegree.AutoSize = true;
            this.txtDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDegree.Location = new System.Drawing.Point(409, 283);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(46, 31);
            this.txtDegree.TabIndex = 1;
            this.txtDegree.Text = "10";
            this.txtDegree.TextChanged += new System.EventHandler(this.txtDegree_TextChanged);
            this.txtDegree.Click += new System.EventHandler(this.txtDegree_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(257, 83);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 532);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtDegree);
            this.Controls.Add(this.trackBarRange);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarRange;
        private System.Windows.Forms.Label txtDegree;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
    }
}

