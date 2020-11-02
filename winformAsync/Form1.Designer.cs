namespace winformAsync
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
            this.value1tbx = new System.Windows.Forms.TextBox();
            this.value2tbx = new System.Windows.Forms.TextBox();
            this.resultlb = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.subtractbtn = new System.Windows.Forms.Button();
            this.dividebtn = new System.Windows.Forms.Button();
            this.multiplybtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // value1tbx
            // 
            this.value1tbx.Location = new System.Drawing.Point(19, 22);
            this.value1tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.value1tbx.Name = "value1tbx";
            this.value1tbx.Size = new System.Drawing.Size(141, 31);
            this.value1tbx.TabIndex = 0;
            this.value1tbx.Text = "5.6";
            // 
            // value2tbx
            // 
            this.value2tbx.Location = new System.Drawing.Point(19, 72);
            this.value2tbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.value2tbx.Name = "value2tbx";
            this.value2tbx.Size = new System.Drawing.Size(141, 31);
            this.value2tbx.TabIndex = 1;
            this.value2tbx.Text = "8.9";
            // 
            // resultlb
            // 
            this.resultlb.AutoSize = true;
            this.resultlb.Location = new System.Drawing.Point(19, 122);
            this.resultlb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultlb.Name = "resultlb";
            this.resultlb.Size = new System.Drawing.Size(22, 25);
            this.resultlb.TabIndex = 2;
            this.resultlb.Text = "0";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(196, 22);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(36, 42);
            this.addbtn.TabIndex = 3;
            this.addbtn.Text = "+";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // subtractbtn
            // 
            this.subtractbtn.Location = new System.Drawing.Point(240, 22);
            this.subtractbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.subtractbtn.Name = "subtractbtn";
            this.subtractbtn.Size = new System.Drawing.Size(36, 42);
            this.subtractbtn.TabIndex = 4;
            this.subtractbtn.Text = "-";
            this.subtractbtn.UseVisualStyleBackColor = true;
            this.subtractbtn.Click += new System.EventHandler(this.subtractbtn_Click);
            // 
            // dividebtn
            // 
            this.dividebtn.Location = new System.Drawing.Point(196, 72);
            this.dividebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dividebtn.Name = "dividebtn";
            this.dividebtn.Size = new System.Drawing.Size(36, 42);
            this.dividebtn.TabIndex = 5;
            this.dividebtn.Text = "/";
            this.dividebtn.UseVisualStyleBackColor = true;
            this.dividebtn.Click += new System.EventHandler(this.dividebtn_Click);
            // 
            // multiplybtn
            // 
            this.multiplybtn.Location = new System.Drawing.Point(240, 73);
            this.multiplybtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.multiplybtn.Name = "multiplybtn";
            this.multiplybtn.Size = new System.Drawing.Size(36, 42);
            this.multiplybtn.TabIndex = 6;
            this.multiplybtn.Text = "*";
            this.multiplybtn.UseVisualStyleBackColor = true;
            this.multiplybtn.Click += new System.EventHandler(this.multiplybtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 224);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.statusStrip1.Size = new System.Drawing.Size(399, 31);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(143, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 255);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.multiplybtn);
            this.Controls.Add(this.dividebtn);
            this.Controls.Add(this.subtractbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.resultlb);
            this.Controls.Add(this.value2tbx);
            this.Controls.Add(this.value1tbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Dan Test Winform Async";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox value1tbx;
        private System.Windows.Forms.TextBox value2tbx;
        private System.Windows.Forms.Label resultlb;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button subtractbtn;
        private System.Windows.Forms.Button dividebtn;
        private System.Windows.Forms.Button multiplybtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
    }
}

