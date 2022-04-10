
namespace GozillaOkONG
{
    partial class Fcap2_Kong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fcap2_Kong));
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
            this.pictureBox1.Location = new System.Drawing.Point(24, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(656, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(65, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "Te salvaste de Kong. Pero de repente escuchas un ruido raro, tenebroso en la cuev" +
    "a. \r\nque vas hacer.";
            // 
            // btnOpcionA
            // 
            this.btnOpcionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionA.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnOpcionA.Location = new System.Drawing.Point(59, 335);
            this.btnOpcionA.Name = "btnOpcionA";
            this.btnOpcionA.Size = new System.Drawing.Size(287, 56);
            this.btnOpcionA.TabIndex = 2;
            this.btnOpcionA.Text = "1. Sales rapidamente de la cueva sabiendo que kong esta afuera y puede matarte.";
            this.btnOpcionA.UseVisualStyleBackColor = true;
            this.btnOpcionA.Click += new System.EventHandler(this.btnOpcionA_Click);
            // 
            // btnOpcionB
            // 
            this.btnOpcionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnOpcionB.Location = new System.Drawing.Point(59, 409);
            this.btnOpcionB.Name = "btnOpcionB";
            this.btnOpcionB.Size = new System.Drawing.Size(287, 46);
            this.btnOpcionB.TabIndex = 3;
            this.btnOpcionB.Text = "2. Te quedas muy quieto y en Silencio.";
            this.btnOpcionB.UseVisualStyleBackColor = true;
            this.btnOpcionB.Click += new System.EventHandler(this.btnOpcionB_Click);
            // 
            // Fcap2_Kong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(704, 502);
            this.ControlBox = false;
            this.Controls.Add(this.btnOpcionB);
            this.Controls.Add(this.btnOpcionA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fcap2_Kong";
            this.Text = "Fcap2_Kong";
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