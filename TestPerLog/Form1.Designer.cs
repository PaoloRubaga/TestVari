namespace TestPerLog
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLog1 = new System.Windows.Forms.Button();
            this.buttonLog2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLog1
            // 
            this.buttonLog1.Location = new System.Drawing.Point(30, 70);
            this.buttonLog1.Name = "buttonLog1";
            this.buttonLog1.Size = new System.Drawing.Size(201, 104);
            this.buttonLog1.TabIndex = 0;
            this.buttonLog1.Text = "Clicca per Log";
            this.buttonLog1.UseVisualStyleBackColor = true;
            this.buttonLog1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLog2
            // 
            this.buttonLog2.Location = new System.Drawing.Point(30, 200);
            this.buttonLog2.Name = "buttonLog2";
            this.buttonLog2.Size = new System.Drawing.Size(201, 103);
            this.buttonLog2.TabIndex = 1;
            this.buttonLog2.Text = "Log del secondo bottone";
            this.buttonLog2.UseVisualStyleBackColor = true;
            this.buttonLog2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 559);
            this.Controls.Add(this.buttonLog2);
            this.Controls.Add(this.buttonLog1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLog1;
        private System.Windows.Forms.Button buttonLog2;
    }
}

