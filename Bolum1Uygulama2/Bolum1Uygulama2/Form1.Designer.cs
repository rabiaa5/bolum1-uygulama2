namespace Bolum1Uygulama2
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
            this.btnKirmizi = new System.Windows.Forms.Button();
            this.btnSari = new System.Windows.Forms.Button();
            this.btnMavi = new System.Windows.Forms.Button();
            this.btnSiyah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKirmizi
            // 
            this.btnKirmizi.BackColor = System.Drawing.Color.Red;
            this.btnKirmizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKirmizi.Location = new System.Drawing.Point(113, 79);
            this.btnKirmizi.Name = "btnKirmizi";
            this.btnKirmizi.Size = new System.Drawing.Size(113, 60);
            this.btnKirmizi.TabIndex = 0;
            this.btnKirmizi.Text = "kırmızı";
            this.btnKirmizi.UseVisualStyleBackColor = false;
            this.btnKirmizi.Click += new System.EventHandler(this.btnKirmizi_Click);
            // 
            // btnSari
            // 
            this.btnSari.BackColor = System.Drawing.Color.Yellow;
            this.btnSari.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSari.Location = new System.Drawing.Point(113, 145);
            this.btnSari.Name = "btnSari";
            this.btnSari.Size = new System.Drawing.Size(113, 67);
            this.btnSari.TabIndex = 1;
            this.btnSari.Text = "sarı";
            this.btnSari.UseVisualStyleBackColor = false;
            this.btnSari.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMavi
            // 
            this.btnMavi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMavi.Location = new System.Drawing.Point(113, 218);
            this.btnMavi.Name = "btnMavi";
            this.btnMavi.Size = new System.Drawing.Size(113, 61);
            this.btnMavi.TabIndex = 2;
            this.btnMavi.Text = "mavi";
            this.btnMavi.UseVisualStyleBackColor = false;
            this.btnMavi.Click += new System.EventHandler(this.btnMavi_Click);
            // 
            // btnSiyah
            // 
            this.btnSiyah.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSiyah.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiyah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSiyah.Location = new System.Drawing.Point(113, 285);
            this.btnSiyah.Name = "btnSiyah";
            this.btnSiyah.Size = new System.Drawing.Size(113, 59);
            this.btnSiyah.TabIndex = 3;
            this.btnSiyah.Text = "siyah";
            this.btnSiyah.UseVisualStyleBackColor = false;
            this.btnSiyah.Click += new System.EventHandler(this.btnSiyah_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSiyah);
            this.Controls.Add(this.btnMavi);
            this.Controls.Add(this.btnSari);
            this.Controls.Add(this.btnKirmizi);
            this.Name = "Form1";
            this.Text = "kırmızı";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKirmizi;
        private System.Windows.Forms.Button btnSari;
        private System.Windows.Forms.Button btnMavi;
        private System.Windows.Forms.Button btnSiyah;
    }
}

