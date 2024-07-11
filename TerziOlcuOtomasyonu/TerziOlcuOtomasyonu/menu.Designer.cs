namespace TerziOlcuOtomasyonu
{
    partial class TerziOlcumVeSiparis
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerziOlcumVeSiparis));
			this.Musteri = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Musteri
			// 
			this.Musteri.BackColor = System.Drawing.Color.Transparent;
			this.Musteri.Cursor = System.Windows.Forms.Cursors.Default;
			this.Musteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Musteri.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Musteri.ForeColor = System.Drawing.Color.White;
			this.Musteri.Location = new System.Drawing.Point(35, 62);
			this.Musteri.Margin = new System.Windows.Forms.Padding(4);
			this.Musteri.Name = "Musteri";
			this.Musteri.Size = new System.Drawing.Size(405, 207);
			this.Musteri.TabIndex = 1;
			this.Musteri.Text = "Müşteri ve Ölçü İşlemleri";
			this.Musteri.UseVisualStyleBackColor = false;
			this.Musteri.Click += new System.EventHandler(this.Musteri_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Ignore;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(35, 332);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(405, 207);
			this.button2.TabIndex = 2;
			this.button2.Text = "Sipariş Takibi";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// TerziOlcumVeSiparis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Goldenrod;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(855, 588);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Musteri);
			this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TerziOlcumVeSiparis";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TerziOlcumVeSiparis";
			this.Load += new System.EventHandler(this.TerziOlcumVeSiparis_Load);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Musteri;
        private System.Windows.Forms.Button button2;
    }
}

