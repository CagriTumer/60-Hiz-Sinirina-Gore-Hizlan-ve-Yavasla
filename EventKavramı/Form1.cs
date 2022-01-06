using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventKavramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Araba arac;
        private void Form1_Load(object sender, EventArgs e)
        {
            arac = new Araba();
            arac.HizDegisti += araba_hiziDegisti;
            //kullanıcının butonu tıklaması, fareyi tıklaması, selectedIndexChanged ler bunların tamamı EVENTTİR yani eylemlerdir.

            //bu olayları yakalayan ve takip eden mekanizmaya ya da sisteme ise EventHandler denir

            //event handler ilgili olayy olduğunda tetiklenir. Olay gerçekleştikten sonra hangi işlemlerin yapılacağı delegeler ile temsil edilir.

            //Buton tıklama click eventi, tuşa basma keypress eventidir ve bunların sonucunda nelerin yapılması gerektiğini kodlarımızda belirleyebiliriz.

        }
        private void btnFren_Click(object sender, EventArgs e)
        {
            arac.Yavasla();
            //lblHiz.Text = arac.Hiz.ToString();
            //lblHiz.BackColor = arac.Hiz > arac.HizSiniri ? Color.Crimson : Color.SpringGreen;
        }

        private void btnGaz_Click(object sender, EventArgs e)
        {
            arac.Hizlan();
            //lblHiz.Text = arac.Hiz.ToString();
            //lblHiz.BackColor = arac.Hiz > arac.HizSiniri ? Color.Crimson : Color.SpringGreen;
        }
        private void araba_hiziDegisti(object sender, EventArgs eventArgs)
        {
            lblHiz.Text = arac.Hiz.ToString();
            lblHiz.BackColor = arac.Hiz > arac.HizSiniri ? Color.Crimson : Color.SpringGreen;
        }
    }
}
