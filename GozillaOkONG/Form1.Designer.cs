
namespace GozillaOkONG
{
    partial class FInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpcionA = new System.Windows.Forms.Button();
            this.btnOpcionB = new System.Windows.Forms.Button();
            this.btnOpcionC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(915, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 95);
            this.label1.TabIndex = 1;
            this.label1.Text = "y Tú valiente Guerrero humano a cúal de estos dos Montruos te vas  a enfrentar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOpcionA
            // 
            this.btnOpcionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionA.Location = new System.Drawing.Point(423, 423);
            this.btnOpcionA.Name = "btnOpcionA";
            this.btnOpcionA.Size = new System.Drawing.Size(205, 38);
            this.btnOpcionA.TabIndex = 2;
            this.btnOpcionA.Text = "1. kONG";
            this.btnOpcionA.UseVisualStyleBackColor = true;
            this.btnOpcionA.Click += new System.EventHandler(this.btnOpcionA_Click);
            // 
            // btnOpcionB
            // 
            this.btnOpcionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionB.Location = new System.Drawing.Point(423, 479);
            this.btnOpcionB.Name = "btnOpcionB";
            this.btnOpcionB.Size = new System.Drawing.Size(205, 36);
            this.btnOpcionB.TabIndex = 3;
            this.btnOpcionB.Text = "2. GOZILLA";
            this.btnOpcionB.UseVisualStyleBackColor = true;
            this.btnOpcionB.Click += new System.EventHandler(this.btnOpcionB_Click);
            // 
            // btnOpcionC
            // 
            this.btnOpcionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcionC.Location = new System.Drawing.Point(423, 531);
            this.btnOpcionC.Name = "btnOpcionC";
            this.btnOpcionC.Size = new System.Drawing.Size(205, 46);
            this.btnOpcionC.TabIndex = 4;
            this.btnOpcionC.Text = "3. Ni Loco Que lo Haga Otro";
            this.btnOpcionC.UseVisualStyleBackColor = true;
            this.btnOpcionC.Click += new System.EventHandler(this.btnOpcionC_Click);
            // 
            // FInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(939, 606);
            this.ControlBox = false;
            this.Controls.Add(this.btnOpcionC);
            this.Controls.Add(this.btnOpcionB);
            this.Controls.Add(this.btnOpcionA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FInicio";
            this.Text = "Inicio de la aventura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpcionA;
        private System.Windows.Forms.Button btnOpcionB;
        private System.Windows.Forms.Button btnOpcionC;
    }
}

