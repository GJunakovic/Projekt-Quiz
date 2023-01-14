
namespace Kviz
{
    partial class SveOdgovorenoForma
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
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(886, 147);
            this.label1.TabIndex = 1;
            this.label1.Text = "Čestitamo odgovorili ste na sva pitanja!";
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BorderColor = System.Drawing.Color.Blue;
            this.button_WOC1.ButtonColor = System.Drawing.Color.CornflowerBlue;
            this.button_WOC1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_WOC1.Location = new System.Drawing.Point(168, 465);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Blue;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.CornflowerBlue;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.RoyalBlue;
            this.button_WOC1.Size = new System.Drawing.Size(224, 58);
            this.button_WOC1.TabIndex = 2;
            this.button_WOC1.Text = "Izlaz";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // SveOdgovorenoForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kviz.Properties.Resources.pozadina1;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.label1);
            this.Name = "SveOdgovorenoForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SveOdgovorenoForma";
            this.Load += new System.EventHandler(this.SveOdgovorenoForma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}