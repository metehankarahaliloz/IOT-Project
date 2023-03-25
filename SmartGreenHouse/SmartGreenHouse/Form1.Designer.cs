namespace SmartGreenHouse
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.baslat = new System.Windows.Forms.Button();
            this.durdur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.yavas = new System.Windows.Forms.Button();
            this.orta = new System.Windows.Forms.Button();
            this.hızlı = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.Button();
            this.kapa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ledac = new System.Windows.Forms.Button();
            this.ledkapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.IndianRed;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(144, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PORT";
            // 
            // baslat
            // 
            this.baslat.BackColor = System.Drawing.Color.IndianRed;
            this.baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.baslat.Location = new System.Drawing.Point(47, 132);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(106, 35);
            this.baslat.TabIndex = 2;
            this.baslat.Text = "BASLAT";
            this.baslat.UseVisualStyleBackColor = false;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // durdur
            // 
            this.durdur.BackColor = System.Drawing.Color.IndianRed;
            this.durdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.durdur.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.durdur.Location = new System.Drawing.Point(172, 132);
            this.durdur.Name = "durdur";
            this.durdur.Size = new System.Drawing.Size(125, 35);
            this.durdur.TabIndex = 3;
            this.durdur.Text = "DURDUR";
            this.durdur.UseVisualStyleBackColor = false;
            this.durdur.Click += new System.EventHandler(this.durdur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(637, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "IŞIK MİKTARI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(637, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "GAZ MİKTARI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(637, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "NEM MİKTARI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(637, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "SICAKLIK";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(802, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(802, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(478, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(802, 219);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(478, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(802, 297);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(478, 22);
            this.textBox4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.IndianRed;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(911, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "PENCERE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.IndianRed;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(948, 556);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "FAN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.IndianRed;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(1007, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.IndianRed;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(1007, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.IndianRed;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(1007, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 16);
            this.label12.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.IndianRed;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(1007, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 21;
            // 
            // yavas
            // 
            this.yavas.BackColor = System.Drawing.Color.IndianRed;
            this.yavas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.yavas.Location = new System.Drawing.Point(614, 613);
            this.yavas.Name = "yavas";
            this.yavas.Size = new System.Drawing.Size(127, 75);
            this.yavas.TabIndex = 22;
            this.yavas.Text = "YAVAŞ";
            this.yavas.UseVisualStyleBackColor = false;
            this.yavas.Click += new System.EventHandler(this.yavas_Click);
            // 
            // orta
            // 
            this.orta.BackColor = System.Drawing.Color.IndianRed;
            this.orta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orta.Location = new System.Drawing.Point(792, 613);
            this.orta.Name = "orta";
            this.orta.Size = new System.Drawing.Size(127, 75);
            this.orta.TabIndex = 23;
            this.orta.Text = "ORTA";
            this.orta.UseVisualStyleBackColor = false;
            this.orta.Click += new System.EventHandler(this.orta_Click);
            // 
            // hızlı
            // 
            this.hızlı.BackColor = System.Drawing.Color.IndianRed;
            this.hızlı.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hızlı.Location = new System.Drawing.Point(980, 613);
            this.hızlı.Name = "hızlı";
            this.hızlı.Size = new System.Drawing.Size(127, 75);
            this.hızlı.TabIndex = 24;
            this.hızlı.Text = "HIZLI";
            this.hızlı.UseVisualStyleBackColor = false;
            this.hızlı.Click += new System.EventHandler(this.hızlı_Click);
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.Color.IndianRed;
            this.kapat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kapat.Location = new System.Drawing.Point(1160, 613);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(141, 75);
            this.kapat.TabIndex = 25;
            this.kapat.Text = "KAPAT";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // ac
            // 
            this.ac.BackColor = System.Drawing.Color.IndianRed;
            this.ac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ac.Location = new System.Drawing.Point(802, 439);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(127, 75);
            this.ac.TabIndex = 26;
            this.ac.Text = "AÇ";
            this.ac.UseVisualStyleBackColor = false;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            this.ac.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ac_MouseDown);
            this.ac.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ac_MouseUp);
            // 
            // kapa
            // 
            this.kapa.BackColor = System.Drawing.Color.IndianRed;
            this.kapa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kapa.Location = new System.Drawing.Point(1001, 439);
            this.kapa.Name = "kapa";
            this.kapa.Size = new System.Drawing.Size(127, 75);
            this.kapa.TabIndex = 27;
            this.kapa.Text = "KAPAT";
            this.kapa.UseVisualStyleBackColor = false;
            this.kapa.Click += new System.EventHandler(this.kapa_Click);
            this.kapa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kapa_MouseDown);
            this.kapa.MouseUp += new System.Windows.Forms.MouseEventHandler(this.kapa_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.IndianRed;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(139, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "LED DURUMU";
            // 
            // ledac
            // 
            this.ledac.BackColor = System.Drawing.Color.IndianRed;
            this.ledac.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ledac.Location = new System.Drawing.Point(78, 491);
            this.ledac.Name = "ledac";
            this.ledac.Size = new System.Drawing.Size(109, 61);
            this.ledac.TabIndex = 29;
            this.ledac.Text = "LED AC";
            this.ledac.UseVisualStyleBackColor = false;
            this.ledac.Click += new System.EventHandler(this.ledac_Click);
            // 
            // ledkapat
            // 
            this.ledkapat.BackColor = System.Drawing.Color.IndianRed;
            this.ledkapat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ledkapat.Location = new System.Drawing.Point(261, 491);
            this.ledkapat.Name = "ledkapat";
            this.ledkapat.Size = new System.Drawing.Size(109, 61);
            this.ledkapat.TabIndex = 30;
            this.ledkapat.Text = "LED KAPAT";
            this.ledkapat.UseVisualStyleBackColor = false;
            this.ledkapat.Click += new System.EventHandler(this.ledkapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartGreenHouse.Properties.Resources.akilli_tarim_calismalari_hiz_kesmiyor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 815);
            this.Controls.Add(this.ledkapat);
            this.Controls.Add(this.ledac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kapa);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.hızlı);
            this.Controls.Add(this.orta);
            this.Controls.Add(this.yavas);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.durdur);
            this.Controls.Add(this.baslat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.Button durdur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button yavas;
        private System.Windows.Forms.Button orta;
        private System.Windows.Forms.Button hızlı;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button ac;
        private System.Windows.Forms.Button kapa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ledac;
        private System.Windows.Forms.Button ledkapat;
    }
}

