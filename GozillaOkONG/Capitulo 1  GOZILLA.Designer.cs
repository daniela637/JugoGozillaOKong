
namespace GozillaOkONG
{
    partial class Fkong1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fkong1));
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
            this.pictureBox1.Location = new System.Drawing.Point(120, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 485);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 136);
            this.label1.TabIndex = 1;
            this.label1.Text = "Te encuentras en un helicoptero, no estas muy lejos del suelo. y ves a Kong venir" +
    ".\r\nque vas a Decidir. tienes 2 opciones. \r\n\r\n";
            // 
            // btnOpcionA
            // 
            this.btnOpcionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionA.Location = new System.Drawing.Point(37, 382);
            this.btnOpcionA.Name = "btnOpcionA";
            this.btnOpcionA.Size = new System.Drawing.Size(198, 97);
            this.btnOpcionA.TabIndex = 2;
            this.btnOpcionA.Text = "1. Te quedas en el helicoptero y enfrentas a Kong con una pistola.";
            this.btnOpcionA.UseVisualStyleBackColor = true;
            this.btnOpcionA.Click += new System.EventHandler(this.btnOpcionA_Click);
            // 
            // btnOpcionB
            // 
            this.btnOpcionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionB.Location = new System.Drawing.Point(674, 382);
            this.btnOpcionB.Name = "btnOpcionB";
            this.btnOpcionB.Size = new System.Drawing.Size(182, 97);
            this.btnOpcionB.TabIndex = 3;
            this.btnOpcionB.Text = "2. Decides Saltar, te golpeas un poco pero logras escabullirte hasta entrar en un" +
    "a cueva";
            this.btnOpcionB.UseVisualStyleBackColor = true;
            this.btnOpcionB.Click += new System.EventHandler(this.btnOpcionB_Click);
            // 
            // Fkong1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(885, 519);
            this.ControlBox = false;
            this.Controls.Add(this.btnOpcionB);
            this.Controls.Add(this.btnOpcionA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fkong1";
            this.Text = "Capitulo_1__GOZILLA";
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