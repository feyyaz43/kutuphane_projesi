using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace giris_ekr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection burak = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\1234.accdb");

        void baglan()
        {

            try
            {
                if (burak.State == ConnectionState.Closed)
                    burak.Open();
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);
            }

        }

        void e_kitap_goster() { label24.Visible = true; label26.Visible = true; label27.Visible = true; label28.Visible = true; textBox17.Visible = true; textBox8.Visible = true; textBox10.Visible = true; textBox11.Visible = true; button14.Visible = true; label23.Visible = true; comboBox8.Visible = true; comboBox10.Visible = true; comboBox11.Visible = true; }
        void e_yazar_goster() { label29.Visible = true; label31.Visible = true; label32.Visible = true;  textBox7.Visible = true; textBox11.Visible = true; textBox12.Visible = true; label23.Visible = true; button14.Visible = true; }
        void e_özet_goster() { label23.Visible = true; button14.Visible = true; label33.Visible = true; label34.Visible = true; label35.Visible = true; textBox11.Visible = true; textBox13.Visible = true; textBox14.Visible = true; }
        void e_kullanıcı_goster() { button14.Visible=true; textBox11.Visible = true; textBox13.Visible = true; textBox17.Visible = true; label30.Visible = true; label37.Visible = true; label38.Visible = true; label23.Visible=true;}
        void e_kitap_kaybet() { label24.Visible = false; label26.Visible = false; label27.Visible = false; label28.Visible = false; comboBox8.Visible = false; comboBox10.Visible = false; comboBox11.Visible = false; textBox7.Visible = false; textBox8.Visible = false; textBox10.Visible = false; textBox11.Visible = false; label23.Visible = false; button14.Visible = false; }
        void e_yazar_kaybet() { label29.Visible = false; label31.Visible = false; label32.Visible = false; textBox7.Visible = false; textBox11.Visible = false; textBox12.Visible = false; label23.Visible = false; button14.Visible = false; }
        void e_özet_kaybet() { button14.Visible=false; label33.Visible = false; label34.Visible = false; label35.Visible = false; textBox11.Visible = false; textBox13.Visible = false; textBox14.Visible = false; }
        void e_kullanıcı_kaybet() { button14.Visible = false; textBox11.Visible = false; textBox13.Visible = false; textBox17.Visible = false; label30.Visible = false; label37.Visible = false; label38.Visible = false; label23.Visible = false; }

        void s_kitap_goster() { label40.Visible = true; label39.Visible = true; comboBox9.Visible = true; comboBox12.Visible = true; textBox11.Visible = true; button16.Visible = true; }
        void s_yazar_goster() { label40.Visible = true; label41.Visible = true; label42.Visible = true; textBox13.Visible = true; textBox17.Visible = true; button16.Visible = true; }
        void s_özet_goster() { label40.Visible = true;  label39.Visible = true; label41.Visible = true; textBox11.Visible = true; textBox13.Visible = true; button16.Visible = true; }
        void s_kullanıcı_goster() { label40.Visible = true; button16.Visible = true; label30.Visible = true; label43.Visible = true; textBox11.Visible = true; textBox13.Visible = true; }
        void s_kitap_kaybet() { label40.Visible = false; label39.Visible = false; comboBox9.Visible = false; comboBox12.Visible = false; textBox11.Visible = false; button16.Visible = false; }
        void s_yazar_kaybet() { label40.Visible = false; label41.Visible = false; label42.Visible = false; textBox13.Visible = false; textBox17.Visible = false; button16.Visible = false; }
        void s_özet_kaybet() { label40.Visible = false; label39.Visible = false; label41.Visible = false; textBox11.Visible = false; textBox13.Visible = false; button16.Visible = false; }
        void s_kullanıcı_kaybet() { label40.Visible = false; button16.Visible = false; label30.Visible = false; label43.Visible = false; textBox11.Visible = false; textBox13.Visible = false; }










        void arama_goster() { label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true; button11.Visible = true; button12.Visible = true; button13.Visible = true; textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true; comboBox1.Visible = true; comboBox2.Visible = true; comboBox3.Visible = true; comboBox4.Visible = true; comboBox5.Visible = true; comboBox6.Visible = true; comboBox7.Visible = true; label4.Visible = true; label10.Visible = true; button7.Visible = true; label9.Visible = true; label11.Visible = true; }


        private void button1_Click(object sender, EventArgs e)  //yönetici
        {
            pictureBox5.Visible = true; button11.Visible = false; button12.Visible = false; button13.Visible = false;pictureBox1.Visible = false; label9.Visible = false; label11.Visible = false;  pictureBox2.Visible = false; pictureBox4.Visible = false;
            label1.Visible = true; label25.Visible = true;label2.Visible = true; label1.Visible=false;textBox1.Visible = true; textBox2.Visible = true;button1.Visible = false; button10.Visible = true;
            button2.Visible = false; button7.Enabled = true;button3.Visible = false;button4.Visible = true;button6.Visible = true; 

        }
        
        private void button2_Click(object sender, EventArgs e)  //kayıtlı öğrenci
        {
            pictureBox5.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            label1.Visible = true;
            label2.Visible = true; label17.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true; textBox9.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false; button7.Enabled = true;
            button4.Visible = true; button6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e) //yeni kayıt
        {
            pictureBox5.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button5.Visible = true; button6.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)  //kayıtlı öğrenci girişe bastıysa
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM Kullanıcı WHERE Öğrenci_Numara='" + textBox1.Text + "' AND Şifre='" + textBox2.Text + "'  AND Ad_Soyad='" + textBox9.Text + "'  ", burak);
            ad.Fill(dt);

            if (dt.Rows.Count > 0)  //şifre ve numara doğruysa
            {

                DataTable dt2 = new DataTable();
                OleDbDataAdapter ad2 = new OleDbDataAdapter("SELECT * FROM Kitap WHERE Ödünç_Bilgisi='" + textBox1.Text + "' AND Rafta='Ödünç' ", burak);
                ad2.Fill(dt2);
                dataGridView1.DataSource = dt2;

                label20.Text = textBox9.Text; label21.Text = textBox1.Text; button8.Visible = true; button9.Visible = true;
                label1.Visible = false; label2.Visible = false; label3.Visible = true; label17.Visible = false; label18.Visible = true; label19.Visible = true; label20.Visible = true; label21.Visible = true; textBox1.Visible = false; textBox2.Visible = false; textBox9.Visible = false; button4.Visible = false; button6.Visible = false; pictureBox3.Visible = false; pictureBox5.Visible = false; dataGridView1.Visible = true;
                label4.Visible = true; label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true; label12.Visible = true; label13.Visible = true; label14.Visible = true; label15.Visible = true; label16.Visible = true; button7.Visible = true;
                comboBox1.Visible = true; comboBox2.Visible = true; comboBox3.Visible = true; comboBox4.Visible = true; comboBox5.Visible = true; comboBox6.Visible = true; textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true; 
            }
            
            else  //şifre veya numara yanlışsa 
            {
                MessageBox.Show("hatalı şifre veya numara girişi");
            }

        }

        private void button5_Click(object sender, EventArgs e) //yeni kayıt ekle
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM Kullanıcı WHERE Öğrenci_Numara='" + textBox1.Text + "'  ", burak);
            ad.Fill(dt);
            if (dt.Rows.Count > 0)  //girilen numaradan kayılı biri varsa
            {
            MessageBox.Show("bu numaraya kayıtlı öğrenci bulunmaktadır.\n yeniden kayıt yapamazsınız...");
            }
            else
            {
                label1.Visible = false; label2.Visible = false; textBox1.Visible = false; textBox2.Visible = false; pictureBox3.Visible = false; pictureBox5.Visible = false; button5.Visible = false; button6.Visible = false;
                label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true;  textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true; comboBox1.Visible = true; comboBox2.Visible = true; comboBox3.Visible = true; comboBox4.Visible = true; comboBox5.Visible = true; comboBox6.Visible = true;  label4.Visible = true; label10.Visible = true; button7.Visible = true; 
                
                OleDbCommand kom = new OleDbCommand("INSERT INTO Kullanıcı(Öğrenci_Numara,Şifre) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "')", burak); //yazma işlemi olduğundan
                kom.ExecuteNonQuery();
            } 
        }

        private void button6_Click(object sender, EventArgs e) //ilk ana menü
        {
            button10.Visible=false; label25.Visible = false; label17.Visible = false; textBox9.Visible=false; button4.Visible = false; button5.Visible = false; button6.Visible = false; label1.Visible = false; label2.Visible = false; textBox1.Visible = false; textBox2.Visible = false; pictureBox5.Visible = false;
            pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox4.Visible = true; button1.Visible = true; button2.Visible = true; button3.Visible = true; textBox1.Text = ""; textBox2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e) //ara
        {   
            baglan();  
            try
            {
                
                object selectedItem1 = comboBox1.SelectedItem; object selectedItem2 = comboBox2.SelectedItem; object selectedItem3 = comboBox3.SelectedItem; object selectedItem4 = comboBox4.SelectedItem;
                DataTable dt = new DataTable();
                OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM Kitap WHERE Tür= '" + selectedItem1.ToString() + "' AND Alt_Tür='" + selectedItem2.ToString() + "' AND Bölüm='" + selectedItem3.ToString() + "'  AND Dil='" + selectedItem4.ToString() + "' AND Rafta='Rafta' ", burak);
                
                ad.Fill(dt);
                if (dt.Rows.Count > 0)
                {  //bulduysa  
                    
                    label22.Visible = true; dataGridView2.Visible = true; label36.Visible = true; textBox15.Visible = true;  button15.Visible=true;

                    DataTable dt2 = new DataTable();
                    OleDbDataAdapter ad2 = new OleDbDataAdapter("SELECT * FROM İlişki2 WHERE Rafta='Rafta' AND Tür= '" + selectedItem1.ToString() + "' AND Alt_Tür='" + selectedItem2.ToString() + "' AND Bölüm='" + selectedItem3.ToString() + "'  AND Dil='" + selectedItem4.ToString() + "'   ", burak);
                    
                    ad2.Fill(dt2);
                    dataGridView2.DataSource = dt2;
                    if (label3.Visible == true) { label44.Visible = true; label45.Visible = true; button15.Visible = true; button17.Visible = true; textBox15.Visible = true; textBox18.Visible = true; }
                    
                
                
                }


                else { label36.Visible = false; textBox15.Visible = false; button15.Visible=false; dataGridView2.Visible = false; MessageBox.Show("bulamadı......."); }
            }
            catch (Exception)
            {

                MessageBox.Show("Zorunlu Alanları Seçiniz...");
            } 
            //MessageBox.Show(selectedItem.ToString());
           
               
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }

        private void button9_Click(object sender, EventArgs e)  //Ana Menü
        {
            e_kitap_kaybet(); e_yazar_kaybet(); e_özet_kaybet(); e_kullanıcı_kaybet(); dataGridView3.Visible = false; 
            s_kitap_kaybet();s_yazar_kaybet();s_özet_kaybet();s_kullanıcı_kaybet();  button18.Visible=false; dataGridView4.Visible=false;

            comboBox7.Visible=false; button11.Visible = false; button12.Visible = false; button13.Visible = false; button15.Visible = false; label25.Visible = false; label36.Visible = false; comboBox1.Visible = false; comboBox2.Visible = false; comboBox3.Visible = false; comboBox4.Visible = false; comboBox5.Visible = false; comboBox6.Visible = false; textBox3.Visible = false; textBox4.Visible = false; textBox5.Visible = false; textBox6.Visible = false; textBox15.Visible = false; button7.Visible = false; button8.Visible = false; button9.Visible = false; dataGridView1.DataSource = ""; dataGridView2.DataSource = "";
            label4.Visible = false; label5.Visible = false; label6.Visible = false; label7.Visible = false; label8.Visible = false; label9.Visible = false; label11.Visible = false; label12.Visible = false; label13.Visible = false; label14.Visible = false; label15.Visible = false; label16.Visible = false; label18.Visible = false; label19.Visible = false; label20.Visible = false; label21.Visible = false; dataGridView1.Visible = false; dataGridView2.Visible = false; label3.Visible = false; label22.Visible = false;
            pictureBox1.Visible = true; pictureBox2.Visible = true; pictureBox3.Visible = true; pictureBox4.Visible = true; button1.Visible = true; button2.Visible = true; button3.Visible = true; textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; label44.Visible = false; label45.Visible = false; textBox18.Visible=false; button17.Visible=false;
    
        }

        private void button8_Click(object sender, EventArgs e) //Çıkış
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e) //yonetici girişi
        {
            baglan(); button8.Visible = true;  button9.Visible = true;
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM Yönetici WHERE Kullanıcı_Adı='" + textBox1.Text + "' AND Parola='" + textBox2.Text + "'   ", burak);
            ad.Fill(dt);


            if (dt.Rows.Count > 0)  //kullanıcı adı ve parola doğruysa
            {
                label9.Visible = true; label11.Visible = true; label2.Visible = false; label25.Visible = false; textBox1.Visible = false; textBox2.Visible = false; button4.Visible = false; button6.Visible = false; button10.Visible = false; pictureBox3.Visible = false; pictureBox5.Visible = false;
                label5.Visible = true; label6.Visible = true; label7.Visible = true; label8.Visible = true; button11.Visible = true; button12.Visible = true; button13.Visible = true; textBox3.Visible = true; textBox4.Visible = true; textBox5.Visible = true; textBox6.Visible = true; comboBox1.Visible = true; comboBox2.Visible = true; comboBox3.Visible = true; comboBox4.Visible = true; comboBox5.Visible = true; comboBox6.Visible = true; comboBox7.Visible = true; label4.Visible = true; label10.Visible = true; button7.Visible = true;
                label44.Visible = true; dataGridView4.Visible = true; button18.Visible = true;

                DataTable dt2 = new DataTable();
                OleDbDataAdapter ad2 = new OleDbDataAdapter("SELECT * FROM İstek WHERE Rafta='İstek'   ", burak);
                ad2.Fill(dt2);
                dataGridView4.DataSource = dt2;




            }

            else  //şifre veya numara yanlışsa 
            {
                MessageBox.Show("hatalı şifre veya numara girişi");
            }

        }

        private void button11_Click(object sender, EventArgs e) //yonetici ekle
        {
            try
            {
                    object selectItem1 = comboBox7.SelectedItem; string a = selectItem1.ToString(); button18.Visible=false;

                    label9.Visible = false; label11.Visible = false; comboBox7.Visible = false; button11.Visible = false; button12.Visible = false; button13.Visible = false; label10.Visible = false; button7.Enabled = false;
                    
                if(a=="Kitap") { e_kitap_goster();  }
                if (a == "Yazar") { e_yazar_goster(); }
                if (a == "Özet") { e_özet_goster(); }
                if (a == "Kullanıcı") { e_kullanıcı_goster(); }
            
                
                
            }
            catch (Exception )
            {
                MessageBox.Show("Tabloyu seçin.");
                
            }
            
        
        
        
        
        }

        private void button12_Click(object sender, EventArgs e) //yonetici sil
        {
            try
            {
                object selectItem1 = comboBox7.SelectedItem; string a = selectItem1.ToString(); button18.Visible = false;

                label9.Visible = false; label11.Visible = false; comboBox7.Visible = false; button11.Visible = false; button12.Visible = false; button13.Visible = false; label10.Visible = false; button7.Enabled = false;

                if (a == "Kitap") { s_kitap_goster(); }
                if (a == "Yazar") { s_yazar_goster(); }
                if (a == "Özet") { s_özet_goster(); }
                if (a == "Kullanıcı") { s_kullanıcı_goster(); }



            }
            catch (Exception)
            {
                MessageBox.Show("Tabloyu seçin.");

            }

        }

        private void button13_Click(object sender, EventArgs e) //yonetici guncelle
        {
            button18.Visible = false;
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)  //yonetici, eklediten sonra 'tamam' butonu
        {
            
    try 
	{
           object selectItem1 = comboBox7.SelectedItem; button7.Enabled = true;  textBox17.Visible=false;
           
           if(selectItem1.ToString() == "Kitap") {
                   
               object selectItem8 = comboBox8.SelectedItem; object selectItem11 = comboBox11.SelectedItem; object selectItem10 = comboBox10.SelectedItem; 

               string a = textBox11.Text; string b = textBox7.Text; string d = textBox10.Text; string c = textBox8.Text;
            OleDbCommand kom = new OleDbCommand("INSERT INTO Kitap(Kitap_Adı,Tür,Alt_Tür,Bölüm,Dil,Yayın_Tarihi,Yayın_Yeri,Yayın_Evi,Rafta) VALUES('" + a + "', 'Kitap', '" + selectItem8.ToString() + "', '" + selectItem11.ToString() + "', '" + selectItem10.ToString() + "', '" + b + "', '" + c + "', '" + d + "', 'Rafta' )   ", burak); //yazma işlemi olduğundanCommand
            kom.ExecuteNonQuery();

            e_kitap_kaybet();
            arama_goster();
            label23.Visible = false; label9.Visible = true; label11.Visible = true;
                                                  }

           if (selectItem1.ToString() == "Yazar")
           {

               string a = textBox11.Text; string b = textBox7.Text; string c = textBox12.Text;
               OleDbCommand kom = new OleDbCommand("INSERT INTO Yazar(Ad_Soyad,Doğum_Yeri,İlk_Eseri) VALUES('" + a + "', '" + b + "', '" + c + "' )   ", burak); //yazma işlemi olduğundanCommand
               kom.ExecuteNonQuery();
               e_yazar_kaybet();
               arama_goster();
           }

          

           if (selectItem1.ToString() == "Kullanıcı")
           {

               //if (textBox7.Text == "" || textBox8.Text == "" || textBox10.Text == "" || textBox11.Text == "") { button14.Visible=false; }  //textleri kontrol et 
               string a = textBox11.Text; string b = textBox13.Text; string c = textBox17.Text; 
               OleDbCommand kom = new OleDbCommand("INSERT INTO Kullanıcı(Öğrenci_Numara,Ad_Soyad,Şifre) VALUES('" +a+ "', '" +b+ "', '" +c+ "' )   ", burak); //yazma işlemi olduğundanCommand
               kom.ExecuteNonQuery();
               e_kullanıcı_kaybet();
               arama_goster();
           }


    
    }
	catch (Exception)
	{
		button7.Enabled=false;
        MessageBox.Show("Tüm alanları doldurun");
	}
        
        
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible=true; 
            baglan();
            DataTable dt2 = new DataTable();
            OleDbDataAdapter ad2 = new OleDbDataAdapter("SELECT * FROM İlişki WHERE Kitap_Adı= '" + textBox15.Text + "'  ", burak);
            ad2.Fill(dt2);
            dataGridView3.DataSource = dt2; dataGridView3.Visible=true;

            
           
            
            
            

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e) //yonetici sil e bastıktan sonra tamama basarsa
        {
            try
            {
                object selectItem1 = comboBox7.SelectedItem; 
                
                
                if (selectItem1.ToString() == "Kitap")
                {
                    baglan();
                    
                    object selectItem9 = comboBox9.SelectedItem; object selectItem12 = comboBox12.SelectedItem;
                    
                    DataTable dt=new DataTable();
                    OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM Kitap WHERE Kitap_Adı='" + textBox11.Text + "' AND  Alt_Tür='" + selectItem9.ToString() + "' AND Dil='" + selectItem12.ToString() + "'   ", burak);
                    ad.Fill(dt);
                    if (dt.Rows.Count > 0)  //silinecek kitap bulduysa...
                    {

                        OleDbCommand kom = new OleDbCommand("DELETE FROM Kitap  WHERE Kitap_Adı='" + textBox11.Text + "' AND  Alt_Tür='" + selectItem9.ToString() + "' AND Dil='" + selectItem12.ToString() + "'                            ", burak);
                        kom.ExecuteNonQuery();
                        MessageBox.Show("Silindi");
                        s_kitap_kaybet();
                        arama_goster();
                    }
                    else   //silinecek kitap bulamadıysa...
                    {
                        MessageBox.Show("Aradığınız özellikte kitap bulunamadı");
                    }
                  
                }

                
                
                if (selectItem1.ToString() == "Yazar")
                {
                    baglan();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM Yazar WHERE Ad_Soyad='" + textBox13.Text + "' AND  İlk_Eseri='" + textBox17.Text + "' ", burak);
                    ad.Fill(dt);
                    if (dt.Rows.Count > 0)  //silinecek yazar bulduysa...
                    {

                        OleDbCommand kom = new OleDbCommand("DELETE FROM Yazar WHERE Ad_Soyad='" + textBox13.Text + "' AND  İlk_Eseri='" + textBox17.Text + "' ", burak);
                        kom.ExecuteNonQuery();

                        s_yazar_kaybet();
                        arama_goster();
                    }
                    else   //silinecek yazar bulamadıysa...
                    {
                        MessageBox.Show("Aradığınız özellikte yazar bulunamadı");
                    }
                  

                }

                if (selectItem1.ToString() == "Özet")
                {

                    DataTable dt2 = new DataTable();
                    OleDbDataAdapter ad2 = new OleDbDataAdapter("SELECT * FROM İlişki WHERE Kitap_Adı= '" + textBox11.Text + "' AND  Ad_Soyad='" + textBox13.Text + "' ", burak);
                    ad2.Fill(dt2);
                    if (dt2.Rows.Count > 0)
                    {
                        MessageBox.Show("bulduuuu");
                        OleDbCommand kom = new OleDbCommand("DELETE FROM Kitap WHERE Kitap_Adı= '" + textBox11.Text + "' ", burak);
                        kom.ExecuteNonQuery();
                        s_özet_kaybet();
                        arama_goster();
                    }
                    else
                    {
                        MessageBox.Show("Aradığınız özellikte eser bulunamadı...");
                    }


                } //Özet

                if (selectItem1.ToString() == "Kullanıcı")
                {

                    //if (textBox7.Text == "" || textBox8.Text == "" || textBox10.Text == "" || textBox11.Text == "") { button14.Visible=false; }  //textleri kontrol et 
                    
                    s_kullanıcı_kaybet();
                    arama_goster();
                }



            }
            catch (Exception)
            {
                button7.Enabled = false;
                MessageBox.Show("Özellikleri doldurun...");
            }
        

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }  

        private void button17_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            OleDbDataAdapter ad2 = new OleDbDataAdapter("SELECT * FROM Kitap WHERE Kitap_Adı= '" + textBox18.Text + "'   ", burak);
            ad2.Fill(dt2);
            if (dt2.Rows.Count > 0) //bulduysa
            {

                DataTable dt3 = new DataTable();
                OleDbDataAdapter ad3 = new OleDbDataAdapter("UPDATE Kitap SET Rafta='İstek'  WHERE Kitap_Adı= '" + textBox18.Text + "'  ", burak);
                ad3.Fill(dt3);
                dataGridView4.DataSource = dt3;
                
                DataTable dt4 = new DataTable();
                OleDbDataAdapter ad4 = new OleDbDataAdapter("UPDATE Kitap SET Ödünç_Bilgisi='" + textBox1.Text + "'  WHERE Kitap_Adı= '" + textBox18.Text + "'  ", burak);
                ad4.Fill(dt4);
                dataGridView4.DataSource = dt4;
                
                MessageBox.Show("İsteğiniz gönderilmiştir.");

            }

            else { MessageBox.Show("Aradığınız isimde kitap bulunamadı..."); }
                    
            
        }

        private void button18_Click(object sender, EventArgs e) //onayla
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("UPDATE İstek SET Gün='20' WHERE Rafta='İstek' ", burak);
            ad.Fill(dt);
            dataGridView4.DataSource = dt;
            
            
            
            DataTable dt2 = new DataTable();
            OleDbDataAdapter ad2 = new OleDbDataAdapter("UPDATE İstek SET Rafta='Ödünç' ", burak);
            ad2.Fill(dt2);
            dataGridView4.DataSource = dt2;

            DataTable dt1 = new DataTable();
            OleDbDataAdapter ad1 = new OleDbDataAdapter("SELECT * FROM İstek WHERE Kitap_Adı='"+textBox18.Text+"' ", burak);
            ad1.Fill(dt1);
            dataGridView4.DataSource = dt1;
            


        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    
    }
}
