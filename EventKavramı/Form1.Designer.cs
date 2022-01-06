
namespace EventKavramı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHiz = new System.Windows.Forms.Label();
            this.btnFren = new System.Windows.Forms.Button();
            this.btnGaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblHiz
            // 
            this.lblHiz.BackColor = System.Drawing.Color.SpringGreen;
            this.lblHiz.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHiz.Location = new System.Drawing.Point(23, 191);
            this.lblHiz.Name = "lblHiz";
            this.lblHiz.Size = new System.Drawing.Size(325, 129);
            this.lblHiz.TabIndex = 1;
            this.lblHiz.Text = "0";
            this.lblHiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFren
            // 
            this.btnFren.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFren.Font = new System.Drawing.Font("Poplar Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFren.Location = new System.Drawing.Point(38, 350);
            this.btnFren.Name = "btnFren";
            this.btnFren.Size = new System.Drawing.Size(103, 75);
            this.btnFren.TabIndex = 2;
            this.btnFren.Text = "FREN";
            this.btnFren.UseVisualStyleBackColor = false;
            this.btnFren.Click += new System.EventHandler(this.btnFren_Click);
            // 
            // btnGaz
            // 
            this.btnGaz.BackColor = System.Drawing.Color.OrangeRed;
            this.btnGaz.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGaz.Location = new System.Drawing.Point(221, 350);
            this.btnGaz.Name = "btnGaz";
            this.btnGaz.Size = new System.Drawing.Size(109, 75);
            this.btnGaz.TabIndex = 3;
            this.btnGaz.Text = "GAZ";
            this.btnGaz.UseVisualStyleBackColor = false;
            this.btnGaz.Click += new System.EventHandler(this.btnGaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 546);
            this.Controls.Add(this.btnGaz);
            this.Controls.Add(this.btnFren);
            this.Controls.Add(this.lblHiz);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHiz;
        private System.Windows.Forms.Button btnFren;
        private System.Windows.Forms.Button btnGaz;
    }
}

