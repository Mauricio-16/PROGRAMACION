namespace Reproductor_de_Música
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progresocancion = new System.Windows.Forms.ProgressBar();
            this.retrocedercancion = new System.Windows.Forms.Button();
            this.botonpausa = new System.Windows.Forms.Button();
            this.pasarcancion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Machista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naoya Zenin";
            // 
            // progresocancion
            // 
            this.progresocancion.Location = new System.Drawing.Point(229, 285);
            this.progresocancion.Name = "progresocancion";
            this.progresocancion.Size = new System.Drawing.Size(328, 23);
            this.progresocancion.TabIndex = 3;
            this.progresocancion.Value = 45;
            // 
            // retrocedercancion
            // 
            this.retrocedercancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retrocedercancion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.retrocedercancion.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrocedercancion.Location = new System.Drawing.Point(229, 342);
            this.retrocedercancion.Name = "retrocedercancion";
            this.retrocedercancion.Size = new System.Drawing.Size(75, 33);
            this.retrocedercancion.TabIndex = 4;
            this.retrocedercancion.Text = "<<";
            this.retrocedercancion.UseVisualStyleBackColor = true;
            // 
            // botonpausa
            // 
            this.botonpausa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonpausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonpausa.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonpausa.Location = new System.Drawing.Point(353, 342);
            this.botonpausa.Name = "botonpausa";
            this.botonpausa.Size = new System.Drawing.Size(84, 33);
            this.botonpausa.TabIndex = 5;
            this.botonpausa.Text = "Play";
            this.botonpausa.UseVisualStyleBackColor = true;
            this.botonpausa.Click += new System.EventHandler(this.button2_Click);
            // 
            // pasarcancion
            // 
            this.pasarcancion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pasarcancion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pasarcancion.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasarcancion.Location = new System.Drawing.Point(482, 342);
            this.pasarcancion.Name = "pasarcancion";
            this.pasarcancion.Size = new System.Drawing.Size(75, 33);
            this.pasarcancion.TabIndex = 6;
            this.pasarcancion.Text = ">>";
            this.pasarcancion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pasarcancion);
            this.Controls.Add(this.botonpausa);
            this.Controls.Add(this.retrocedercancion);
            this.Controls.Add(this.progresocancion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progresocancion;
        private System.Windows.Forms.Button retrocedercancion;
        private System.Windows.Forms.Button botonpausa;
        private System.Windows.Forms.Button pasarcancion;
    }
}

