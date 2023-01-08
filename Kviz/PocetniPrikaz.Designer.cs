
namespace Kviz
{
    partial class PocetniPrikaz
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
            this.unosImenatxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // unosImenatxt
            // 
            this.unosImenatxt.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unosImenatxt.Location = new System.Drawing.Point(420, 104);
            this.unosImenatxt.Name = "unosImenatxt";
            this.unosImenatxt.Size = new System.Drawing.Size(407, 41);
            this.unosImenatxt.TabIndex = 0;
            this.unosImenatxt.TextChanged += new System.EventHandler(this.unosImenatxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(420, 335);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(407, 357);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.DarkMagenta;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Goldenrod;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button_WOC1.Location = new System.Drawing.Point(420, 211);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.DarkMagenta;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.Goldenrod;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.button_WOC1.Size = new System.Drawing.Size(407, 50);
            this.button_WOC1.TabIndex = 2;
            this.button_WOC1.Text = "Pokreni kviz";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = true;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // PocetniPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unosImenatxt);
            this.Name = "PocetniPrikaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PocetniPrikaz";
            this.Load += new System.EventHandler(this.PocetniPrikaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.TextBox unosImenatxt;
    }
}