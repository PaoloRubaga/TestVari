namespace TestPerLog
{
    partial class FormEmail
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
            this.labelDestinatario = new System.Windows.Forms.Label();
            this.textDestinatario = new System.Windows.Forms.TextBox();
            this.labelOggetto = new System.Windows.Forms.Label();
            this.textOggetto = new System.Windows.Forms.TextBox();
            this.textTesto = new System.Windows.Forms.TextBox();
            this.labelTesto = new System.Windows.Forms.Label();
            this.buttonInvio = new System.Windows.Forms.Button();
            this.labelCc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelDestinatario
            // 
            this.labelDestinatario.AutoSize = true;
            this.labelDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDestinatario.Location = new System.Drawing.Point(217, 24);
            this.labelDestinatario.Name = "labelDestinatario";
            this.labelDestinatario.Size = new System.Drawing.Size(84, 17);
            this.labelDestinatario.TabIndex = 0;
            this.labelDestinatario.Text = "Destinatario";
            // 
            // textDestinatario
            // 
            this.textDestinatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textDestinatario.Location = new System.Drawing.Point(314, 21);
            this.textDestinatario.Name = "textDestinatario";
            this.textDestinatario.Size = new System.Drawing.Size(474, 21);
            this.textDestinatario.TabIndex = 1;
            this.textDestinatario.Text = "paolo.rubaga@geeo.it";
            // 
            // labelOggetto
            // 
            this.labelOggetto.AutoSize = true;
            this.labelOggetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOggetto.Location = new System.Drawing.Point(217, 92);
            this.labelOggetto.Name = "labelOggetto";
            this.labelOggetto.Size = new System.Drawing.Size(59, 17);
            this.labelOggetto.TabIndex = 2;
            this.labelOggetto.Text = "Oggetto";
            this.labelOggetto.Click += new System.EventHandler(this.labelOggetto_Click);
            // 
            // textOggetto
            // 
            this.textOggetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textOggetto.Location = new System.Drawing.Point(314, 89);
            this.textOggetto.Name = "textOggetto";
            this.textOggetto.Size = new System.Drawing.Size(474, 21);
            this.textOggetto.TabIndex = 3;
            this.textOggetto.Text = "oggetto prova";
            // 
            // textTesto
            // 
            this.textTesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textTesto.Location = new System.Drawing.Point(314, 158);
            this.textTesto.Multiline = true;
            this.textTesto.Name = "textTesto";
            this.textTesto.Size = new System.Drawing.Size(474, 116);
            this.textTesto.TabIndex = 4;
            this.textTesto.Text = "testo prova";
            // 
            // labelTesto
            // 
            this.labelTesto.AutoSize = true;
            this.labelTesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTesto.Location = new System.Drawing.Point(217, 158);
            this.labelTesto.Name = "labelTesto";
            this.labelTesto.Size = new System.Drawing.Size(44, 17);
            this.labelTesto.TabIndex = 5;
            this.labelTesto.Text = "Testo";
            // 
            // buttonInvio
            // 
            this.buttonInvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonInvio.Location = new System.Drawing.Point(211, 299);
            this.buttonInvio.Name = "buttonInvio";
            this.buttonInvio.Size = new System.Drawing.Size(577, 28);
            this.buttonInvio.TabIndex = 6;
            this.buttonInvio.Text = "Invio";
            this.buttonInvio.UseVisualStyleBackColor = true;
            this.buttonInvio.Click += new System.EventHandler(this.buttonInvio_Click);
            // 
            // labelCc
            // 
            this.labelCc.AutoSize = true;
            this.labelCc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCc.Location = new System.Drawing.Point(217, 60);
            this.labelCc.Name = "labelCc";
            this.labelCc.Size = new System.Drawing.Size(22, 17);
            this.labelCc.TabIndex = 7;
            this.labelCc.Text = "cc";
            this.labelCc.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(474, 20);
            this.textBox1.TabIndex = 8;
            // 
            // FormEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCc);
            this.Controls.Add(this.buttonInvio);
            this.Controls.Add(this.labelTesto);
            this.Controls.Add(this.textTesto);
            this.Controls.Add(this.textOggetto);
            this.Controls.Add(this.labelOggetto);
            this.Controls.Add(this.textDestinatario);
            this.Controls.Add(this.labelDestinatario);
            this.Name = "FormEmail";
            this.Text = "FormEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDestinatario;
        private System.Windows.Forms.TextBox textDestinatario;
        private System.Windows.Forms.Label labelOggetto;
        private System.Windows.Forms.TextBox textOggetto;
        private System.Windows.Forms.TextBox textTesto;
        private System.Windows.Forms.Label labelTesto;
        private System.Windows.Forms.Button buttonInvio;
        private System.Windows.Forms.Label labelCc;
        private System.Windows.Forms.TextBox textBox1;
    }
}