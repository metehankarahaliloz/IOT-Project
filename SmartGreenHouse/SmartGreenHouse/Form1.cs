using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGreenHouse
{
    public partial class Form1 : Form
    {
        private string data;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); //Port isimlerini al
            foreach (string port in ports)
                comboBox1.Items.Add(port); //Port isimlerini comboBox içine yaz
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived); //DataReceived eventini oluşturma
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine();                      //Veriyi al
            this.Invoke(new EventHandler(displayData_event));
        }

        private void displayData_event(object sender, EventArgs e)
        {
            string[] value = data.Split('*'); //'*' gördüğün yerlerden stringi ayır ve diziye ata
            textBox1.Text = DateTime.Now.ToString()+ "  " + "IŞIK DEĞERİ " + value[0]; 
            textBox2.Text = DateTime.Now.ToString()+ "  " + "GAZ  DEĞERİ " + value[1];
            textBox3.Text = DateTime.Now.ToString()+ "  " + "NEM  DEĞERİ % " + value[2];
            textBox4.Text = DateTime.Now.ToString()+ "  " + "SICAKLIK DEĞERİ " + value[3] + "°C";
            int a = 4095;
            int ısık = Int32.Parse(value[0]);
            int b = 850;
            int gaz = int.Parse(value[1]);
            int c = 65;
            int nem = int.Parse(value[2]);
            int d = 20;
            int sıcaklık = int.Parse(value[3]);
            if (ısık >= a)
            {
                label10.Text = "IŞIĞI AÇ";
            }
            else 
            {
                label10.Text = string.Empty;
            }
            if (gaz > b)
            {
                label11.Text = "CAMI AC";
            }
            else
            {
                label11.Text = string.Empty;
            }
            if (nem > c)
            {
                label12.Text = "FANI ÇALIŞTIR";
            }
            else
            {
                label12.Text = string.Empty;
            }
            if ( sıcaklık > d)
            {
                label13.Text = "FANI ÇALIŞTIR";
            }
            else
            {
                label13.Text = string.Empty;
            }


        }

        private void baslat_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;  //ComboBox1'de seçili nesneyi port ismine ata
                serialPort1.BaudRate = 9600;            //BaudRate 9600 olarak ayarla
                serialPort1.Open();                     //Seri portu aç
                durdur.Enabled = true;                  //Durdurma butonunu aktif hale getir
                baslat.Enabled = false;                 //Başlatma butonunu pasif hale getir

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");    //Hata mesajı göster
            }
        }

        private void durdur_Click(object sender, EventArgs e)
        {
            serialPort1.Close();        //Seri Portu kapa
            durdur.Enabled = false;     //Durdurma butonunu pasif hale getir
            baslat.Enabled = true;      //Başlatma butonunu aktif hale getir
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();    //Seri port açıksa kapat
        }

  

        private void yavas_Click(object sender, EventArgs e)
        {
            serialPort1.Write("y" + ",");  //Butona basınca fanı yavaş hızda döndürücek
        }

        private void orta_Click(object sender, EventArgs e)
        {
            serialPort1.Write("o" + ",");  //Butona basınca fanı orta hızda döndürücek
        }

        private void hızlı_Click(object sender, EventArgs e)
        {
            serialPort1.Write("h" + ",");   //Butona basınca fanı hızlı olarak döndürücek
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            serialPort1.Write("d" + ",");   //Butona basınca fanı durdurucak
        }

        private void ac_Click(object sender, EventArgs e)
        {
            serialPort1.Write("s" + ",");
        }

        private void kapa_Click(object sender, EventArgs e)
        {
            serialPort1.Write("r" + ",");
        }

        private void ac_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("s" + ",");
            serialPort1.Write("s" + ",");
        }

        private void ac_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("s" + ",");
            serialPort1.Write("s" + ",");
        }

        private void kapa_MouseDown(object sender, MouseEventArgs e)
        {
            serialPort1.Write("r" + ",");
            serialPort1.Write("r" + ",");
        }

        private void kapa_MouseUp(object sender, MouseEventArgs e)
        {
            serialPort1.Write("r" + ",");
            serialPort1.Write("r" + ",");
        }

        private void ledac_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");    //Seri porta "1" gönder    
            ledkapat.Enabled = true;    //Button2'yi tıklanabilir hale getir
            ledac.Enabled = false;   //Button1'i tıklanamaz hale getir
        }

        private void ledkapat_Click(object sender, EventArgs e)
        {
            serialPort1.Write("b");    //Seri porta "0" gönder
            ledac.Enabled = true;    //Button1'i tıklanabilir hale getir
            ledkapat.Enabled = false;   //Button2'yi tıklanamaz hale getir
        }
    }
}
