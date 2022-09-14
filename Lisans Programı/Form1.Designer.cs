namespace Lisans_Programı
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.denemesurumubtn = new System.Windows.Forms.Button();
            this.lisansbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lisanstextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kalangünlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // denemesurumubtn
            // 
            this.denemesurumubtn.Location = new System.Drawing.Point(204, 69);
            this.denemesurumubtn.Name = "denemesurumubtn";
            this.denemesurumubtn.Size = new System.Drawing.Size(97, 40);
            this.denemesurumubtn.TabIndex = 0;
            this.denemesurumubtn.Text = "Deneme sürümünü başlat";
            this.denemesurumubtn.UseVisualStyleBackColor = true;
            this.denemesurumubtn.Click += new System.EventHandler(this.denemesurumubtn_Click);
            // 
            // lisansbtn
            // 
            this.lisansbtn.Location = new System.Drawing.Point(101, 69);
            this.lisansbtn.Name = "lisansbtn";
            this.lisansbtn.Size = new System.Drawing.Size(97, 40);
            this.lisansbtn.TabIndex = 1;
            this.lisansbtn.Text = "Lisans gir";
            this.lisansbtn.UseVisualStyleBackColor = true;
            this.lisansbtn.Click += new System.EventHandler(this.lisansbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lisans anahtarı: ";
            // 
            // lisanstextbox
            // 
            this.lisanstextbox.Location = new System.Drawing.Point(101, 30);
            this.lisanstextbox.Name = "lisanstextbox";
            this.lisanstextbox.Size = new System.Drawing.Size(200, 20);
            this.lisanstextbox.TabIndex = 3;
            this.lisanstextbox.TextChanged += new System.EventHandler(this.lisanstextbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kalan gün sayısı: ";
            // 
            // kalangünlabel
            // 
            this.kalangünlabel.AutoSize = true;
            this.kalangünlabel.Location = new System.Drawing.Point(182, 53);
            this.kalangünlabel.Name = "kalangünlabel";
            this.kalangünlabel.Size = new System.Drawing.Size(13, 13);
            this.kalangünlabel.TabIndex = 5;
            this.kalangünlabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 149);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kalangünlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lisanstextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lisansbtn);
            this.Controls.Add(this.denemesurumubtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lisans programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button denemesurumubtn;
        private System.Windows.Forms.Button lisansbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lisanstextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kalangünlabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

