
namespace GozillaOkONG
{
    partial class Fcap1Gozilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fcap1Gozilla));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpcionA = new System.Windows.Forms.Button();
            this.btnOpcionB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 125);
            this.label1.TabIndex = 1;
            this.label1.Text = "Te encuentras en un Barco militar y de repente golpea algo muy fuerte el barco.\r\n" +
    "avisan que gozilla los esta atacando. piensa rapido que vas a hacer.";
            // 
            // btnOpcionA
            // 
            this.btnOpcionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionA.Location = new System.Drawing.Point(52, 426);
            this.btnOpcionA.Name = "btnOpcionA";
            this.btnOpcionA.Size = new System.Drawing.Size(153, 66);
            this.btnOpcionA.TabIndex = 2;
            this.btnOpcionA.Text = "1. Saltas del Barco y te Haces el muerto.";
            this.btnOpcionA.UseVisualStyleBackColor = true;
            this.btnOpcionA.Click += new System.EventHandler(this.btnOpcionA_Click);
            // 
            // btnOpcionB
            // 
            this.btnOpcionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionB.Location = new System.Drawing.Point(369, 426);
            this.btnOpcionB.Name = "btnOpcionB";
            this.btnOpcionB.Size = new System.Drawing.Size(195, 66);
            this.btnOpcionB.TabIndex = 3;
            this.btnOpcionB.Text = "2. Te quedas en el Barco y disparas a Gozilla con las armas que hay.";
            this.btnOpcionB.UseVisualStyleBackColor = true;
            this.btnOpcionB.Click += new System.EventHandler(this.btnOpcionB_Click);
            // 
            // Fcap1Gozilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.ControlBox = false;
            this.Controls.Add(this.btnOpcionB);
            this.Controls.Add(this.btnOpcionA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fcap1Gozilla";
            this.Text = "Fcap1Gozilla";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpcionA;
        private System.Windows.Forms.Button btnOpcionB;
    }
}