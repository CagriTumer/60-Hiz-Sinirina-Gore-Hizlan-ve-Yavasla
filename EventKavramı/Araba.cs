using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventKavramı
{
     class Araba
    {
        int _hiz;
        int _hizSiniri;
        public event EventHandler HizDegisti;
        public Araba()
        {
            Hiz = 0;
            HizSiniri = 60;
        }

        public int Hiz
        {
            get
            {
                return _hiz;
            }
            set
            {
                if (value < 0)
               
                    return; //_hiz=0;
                    _hiz = value;

                //eger bu olayla herhangi bir metot ilişkilendirilmediyse hata vermesine engel olmak icin ? koyuyoruz
                HizDegisti?.Invoke(this,new EventArgs());
                
            }
        }
        public int HizSiniri
        {
            get
            {
                return _hizSiniri;
            }
            set
            {
                if (value < 0)
                
                    return;
                    _hizSiniri = value;
                

            }
        }
        //hızı yavaslatan ve artıran metotlar yazalım

        public void Hizlan()
        {
            Hiz += 10;
            //_hiz += 10; bunu korumak için boyle yazmıyoruz Hiz yazıyoruz. kontrol mekanizması calısması icin gerekli


        }
        public void Yavasla()
        {
            Hiz -= 10;

        }
        
    }
}
