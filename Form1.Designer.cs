namespace BgwTest
{
    partial class frmMain
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
            this.txtavvio2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtAvvia100 = new System.Windows.Forms.TextBox();
            this.btnAvvio100 = new System.Windows.Forms.Button();
            this.btnStop100 = new System.Windows.Forms.Button();
            this.btnAvvio2 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtavvio2
            // 
            this.txtavvio2.Location = new System.Drawing.Point(123, 48);
            this.txtavvio2.Multiline = true;
            this.txtavvio2.Name = "txtavvio2";
            this.txtavvio2.Size = new System.Drawing.Size(93, 333);
            this.txtavvio2.TabIndex = 0;
            // 
            // txtAvvia100
            // 
            this.txtAvvia100.Location = new System.Drawing.Point(518, 43);
            this.txtAvvia100.Multiline = true;
            this.txtAvvia100.Name = "txtAvvia100";
            this.txtAvvia100.Size = new System.Drawing.Size(92, 333);
            this.txtAvvia100.TabIndex = 1;
            // 
            // btnAvvio100
            // 
            this.btnAvvio100.Location = new System.Drawing.Point(428, 49);
            this.btnAvvio100.Name = "btnAvvio100";
            this.btnAvvio100.Size = new System.Drawing.Size(76, 25);
            this.btnAvvio100.TabIndex = 2;
            this.btnAvvio100.Text = "button1";
            this.btnAvvio100.UseVisualStyleBackColor = true;
            this.btnAvvio100.Click += new System.EventHandler(this.btnAvvio100_Click);
            // 
            // btnStop100
            // 
            this.btnStop100.Location = new System.Drawing.Point(428, 100);
            this.btnStop100.Name = "btnStop100";
            this.btnStop100.Size = new System.Drawing.Size(75, 21);
            this.btnStop100.TabIndex = 3;
            this.btnStop100.Text = "button1";
            this.btnStop100.UseVisualStyleBackColor = true;
            this.btnStop100.Click += new System.EventHandler(this.btnStop100_Click);
            // 
            // btnAvvio2
            // 
            this.btnAvvio2.Location = new System.Drawing.Point(10, 48);
            this.btnAvvio2.Name = "btnAvvio2";
            this.btnAvvio2.Size = new System.Drawing.Size(79, 26);
            this.btnAvvio2.TabIndex = 4;
            this.btnAvvio2.Text = "button1";
            this.btnAvvio2.UseVisualStyleBackColor = true;
            this.btnAvvio2.Click += new System.EventHandler(this.btnAvvio2_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(12, 95);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(76, 25);
            this.btnStop2.TabIndex = 5;
            this.btnStop2.Text = "button1";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop2);
            this.Controls.Add(this.btnAvvio2);
            this.Controls.Add(this.btnStop100);
            this.Controls.Add(this.btnAvvio100);
            this.Controls.Add(this.txtAvvia100);
            this.Controls.Add(this.txtavvio2);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtavvio2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtAvvia100;
        private System.Windows.Forms.Button btnAvvio100;
        private System.Windows.Forms.Button btnStop100;
        private System.Windows.Forms.Button btnAvvio2;
        private System.Windows.Forms.Button btnStop2;
    }
}

