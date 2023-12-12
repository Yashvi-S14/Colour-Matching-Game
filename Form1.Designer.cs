
namespace FinalCPT
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
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.pcbWand1 = new System.Windows.Forms.PictureBox();
            this.pcbWand2 = new System.Windows.Forms.PictureBox();
            this.pcbWand3 = new System.Windows.Forms.PictureBox();
            this.pcbWand4 = new System.Windows.Forms.PictureBox();
            this.pcbWand5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWand5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStart.Font = new System.Drawing.Font("Sparkles", 14F);
            this.btnStart.ForeColor = System.Drawing.Color.Navy;
            this.btnStart.Location = new System.Drawing.Point(797, 56);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 92);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.Font = new System.Drawing.Font("Sparkles", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPoints.Location = new System.Drawing.Point(12, 33);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(112, 24);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "Points:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEnd.Font = new System.Drawing.Font("Sparkles", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.Black;
            this.lblEnd.Location = new System.Drawing.Point(306, 264);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(0, 48);
            this.lblEnd.TabIndex = 2;
            // 
            // pcbWand1
            // 
            this.pcbWand1.BackColor = System.Drawing.Color.Transparent;
            this.pcbWand1.Image = global::FinalCPT.Properties.Resources.wand_;
            this.pcbWand1.Location = new System.Drawing.Point(762, 298);
            this.pcbWand1.Name = "pcbWand1";
            this.pcbWand1.Size = new System.Drawing.Size(87, 106);
            this.pcbWand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbWand1.TabIndex = 3;
            this.pcbWand1.TabStop = false;
            this.pcbWand1.Click += new System.EventHandler(this.pcbWand1_Click);
            // 
            // pcbWand2
            // 
            this.pcbWand2.BackColor = System.Drawing.Color.Transparent;
            this.pcbWand2.Image = global::FinalCPT.Properties.Resources.wand_;
            this.pcbWand2.Location = new System.Drawing.Point(855, 298);
            this.pcbWand2.Name = "pcbWand2";
            this.pcbWand2.Size = new System.Drawing.Size(87, 106);
            this.pcbWand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbWand2.TabIndex = 4;
            this.pcbWand2.TabStop = false;
            this.pcbWand2.Click += new System.EventHandler(this.pcbWand2_Click);
            // 
            // pcbWand3
            // 
            this.pcbWand3.BackColor = System.Drawing.Color.Transparent;
            this.pcbWand3.Image = global::FinalCPT.Properties.Resources.wand_;
            this.pcbWand3.Location = new System.Drawing.Point(948, 298);
            this.pcbWand3.Name = "pcbWand3";
            this.pcbWand3.Size = new System.Drawing.Size(87, 106);
            this.pcbWand3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbWand3.TabIndex = 5;
            this.pcbWand3.TabStop = false;
            this.pcbWand3.Click += new System.EventHandler(this.pcbWand3_Click);
            // 
            // pcbWand4
            // 
            this.pcbWand4.BackColor = System.Drawing.Color.Transparent;
            this.pcbWand4.Image = global::FinalCPT.Properties.Resources.wand_;
            this.pcbWand4.Location = new System.Drawing.Point(808, 410);
            this.pcbWand4.Name = "pcbWand4";
            this.pcbWand4.Size = new System.Drawing.Size(87, 106);
            this.pcbWand4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbWand4.TabIndex = 6;
            this.pcbWand4.TabStop = false;
            this.pcbWand4.Click += new System.EventHandler(this.pcbWand4_Click);
            // 
            // pcbWand5
            // 
            this.pcbWand5.BackColor = System.Drawing.Color.Transparent;
            this.pcbWand5.Image = global::FinalCPT.Properties.Resources.wand_;
            this.pcbWand5.Location = new System.Drawing.Point(901, 410);
            this.pcbWand5.Name = "pcbWand5";
            this.pcbWand5.Size = new System.Drawing.Size(87, 106);
            this.pcbWand5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbWand5.TabIndex = 7;
            this.pcbWand5.TabStop = false;
            this.pcbWand5.Click += new System.EventHandler(this.pcbWand5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1083, 598);
            this.Controls.Add(this.pcbWand5);
            this.Controls.Add(this.pcbWand4);
            this.Controls.Add(this.pcbWand3);
            this.Controls.Add(this.pcbWand2);
            this.Controls.Add(this.pcbWand1);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pcbWand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWand5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.PictureBox pcbWand1;
        private System.Windows.Forms.PictureBox pcbWand2;
        private System.Windows.Forms.PictureBox pcbWand3;
        private System.Windows.Forms.PictureBox pcbWand4;
        private System.Windows.Forms.PictureBox pcbWand5;
    }
}

