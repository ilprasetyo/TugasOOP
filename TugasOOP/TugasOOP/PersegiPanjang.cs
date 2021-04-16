using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOOP
{
    class PersegiPanjang: Persegi
    {
        private double panjang,lebar;

        public void setPanjang(double p)
        {
            this.panjang = p;
        }
        public double getPanjang()
        {
            return panjang;
        }
        public void setLebar(double l)
        {
            this.lebar = l;
        }
        public double getLebar()
        {
            return lebar;
        }
        public override void Inputan()
        {
            Console.WriteLine("Masukan Panjang(Cm) : ");
            setPanjang(panjang = Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Masukan Lebar(Cm) : ");
            setLebar(lebar = Convert.ToDouble(Console.ReadLine()));
        }
        public override void HitungLuas()
        {
            double hasil = getPanjang()*getLebar();
            Console.WriteLine("Luas Persegi Panjang : " + hasil.ToString("0.00"));
        }
        public override void HitungKeliling()
        {
            double hasil = 2*(getPanjang()+getLebar());
            Console.WriteLine("Keliling Persegi Panjang : " + hasil.ToString("0.00"));
        }
    }
}
