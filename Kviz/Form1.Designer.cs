
namespace Kviz
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
            this.lblPitanje = new System.Windows.Forms.Label();
            this.odgovor1 = new System.Windows.Forms.Button();
            this.odgovor2 = new System.Windows.Forms.Button();
            this.odgovor3 = new System.Windows.Forms.Button();
            this.odgovor4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPitanje
            // 
            this.lblPitanje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPitanje.Location = new System.Drawing.Point(100, 60);
            this.lblPitanje.Name = "lblPitanje";
            this.lblPitanje.Padding = new System.Windows.Forms.Padding(15);
            this.lblPitanje.Size = new System.Drawing.Size(871, 104);
            this.lblPitanje.TabIndex = 0;
            this.lblPitanje.Text = "label1";
            this.lblPitanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // odgovor1
            // 
            this.odgovor1.Location = new System.Drawing.Point(106, 234);
            this.odgovor1.Name = "odgovor1";
            this.odgovor1.Padding = new System.Windows.Forms.Padding(15);
            this.odgovor1.Size = new System.Drawing.Size(364, 114);
            this.odgovor1.TabIndex = 1;
            this.odgovor1.Tag = "1";
            this.odgovor1.Text = "button1";
            this.odgovor1.UseVisualStyleBackColor = true;
            this.odgovor1.Click += new System.EventHandler(this.OdgovoriEvent);
            // 
            // odgovor2
            // 
            this.odgovor2.Location = new System.Drawing.Point(607, 234);
            this.odgovor2.Name = "odgovor2";
            this.odgovor2.Padding = new System.Windows.Forms.Padding(15);
            this.odgovor2.Size = new System.Drawing.Size(364, 114);
            this.odgovor2.TabIndex = 2;
            this.odgovor2.Tag = "2";
            this.odgovor2.Text = "button2";
            this.odgovor2.UseVisualStyleBackColor = true;
            this.odgovor2.Click += new System.EventHandler(this.OdgovoriEvent);
            // 
            // odgovor3
            // 
            this.odgovor3.Location = new System.Drawing.Point(106, 426);
            this.odgovor3.Name = "odgovor3";
            this.odgovor3.Padding = new System.Windows.Forms.Padding(15);
            this.odgovor3.Size = new System.Drawing.Size(364, 114);
            this.odgovor3.TabIndex = 3;
            this.odgovor3.Tag = "3";
            this.odgovor3.Text = "button3";
            this.odgovor3.UseVisualStyleBackColor = true;
            this.odgovor3.Click += new System.EventHandler(this.OdgovoriEvent);
            // 
            // odgovor4
            // 
            this.odgovor4.Location = new System.Drawing.Point(607, 426);
            this.odgovor4.Name = "odgovor4";
            this.odgovor4.Padding = new System.Windows.Forms.Padding(15);
            this.odgovor4.Size = new System.Drawing.Size(364, 114);
            this.odgovor4.TabIndex = 4;
            this.odgovor4.Tag = "4";
            this.odgovor4.Text = "button4";
            this.odgovor4.UseVisualStyleBackColor = true;
            this.odgovor4.Click += new System.EventHandler(this.OdgovoriEvent);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1031, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kviz.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odgovor4);
            this.Controls.Add(this.odgovor3);
            this.Controls.Add(this.odgovor2);
            this.Controls.Add(this.odgovor1);
            this.Controls.Add(this.lblPitanje);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPitanje;
        private System.Windows.Forms.Button odgovor1;
        private System.Windows.Forms.Button odgovor2;
        private System.Windows.Forms.Button odgovor3;
        private System.Windows.Forms.Button odgovor4;
        public System.Windows.Forms.Label label1;
    }
}

