
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
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zao nam je ali igra je zavrsena :.(";
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
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Silver;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Red;
            this.button_WOC1.Location = new System.Drawing.Point(184, 396);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC1.Size = new System.Drawing.Size(189, 67);
            this.button_WOC1.TabIndex = 2;
            this.button_WOC1.Text = "button_WOC1";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // GameOver_prikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.button_WOC1);
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
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}