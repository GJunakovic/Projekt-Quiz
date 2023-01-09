
namespace Kviz
{
    partial class GameOver_prikaz
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
            this.label1 = new System.Windows.Forms.Label();
            this.prikazBodova = new System.Windows.Forms.Label();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Žao nam je ali igra je završena.";
            // 
            // prikazBodova
            // 
            this.prikazBodova.AutoSize = true;
            this.prikazBodova.Font = new System.Drawing.Font("Matura MT Script Capitals", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prikazBodova.Location = new System.Drawing.Point(172, 186);
            this.prikazBodova.Name = "prikazBodova";
            this.prikazBodova.Size = new System.Drawing.Size(72, 70);
            this.prikazBodova.TabIndex = 1;
            this.prikazBodova.Text = "...";
            this.prikazBodova.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BorderColor = System.Drawing.Color.Indigo;
            this.button_WOC2.ButtonColor = System.Drawing.Color.Goldenrod;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.ForeColor = System.Drawing.Color.Indigo;
            this.button_WOC2.Location = new System.Drawing.Point(184, 389);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.Indigo;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.Goldenrod;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC2.Size = new System.Drawing.Size(504, 50);
            this.button_WOC2.TabIndex = 3;
            this.button_WOC2.Text = "Izlaz iz igrice";
            this.button_WOC2.TextColor = System.Drawing.Color.White;
            this.button_WOC2.UseVisualStyleBackColor = true;
            this.button_WOC2.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // GameOver_prikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.button_WOC2);
            this.Controls.Add(this.prikazBodova);
            this.Controls.Add(this.label1);
            this.Name = "GameOver_prikaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOver_prikaz";
            this.Load += new System.EventHandler(this.GameOver_prikaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label prikazBodova;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
    }
}