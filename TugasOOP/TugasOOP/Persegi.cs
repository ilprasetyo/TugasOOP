using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOOP
{
    class Persegi
    {
        private double sisi;

        public virtual void setSisi(double s)
        {
            this.sisi = s;
        }
        public virtual double getSisi()
        {
            return sisi;
        }
        public virtual void HitungLuas() {
            Console.WriteLine("Masukan Panjang Sisi : ");
            setSisi(sisi = Convert.ToDouble(Console.ReadLine()));

            double hasil = Math.Pow(getSisi(), 2);
            Console.WriteLine("Luas Persegi : "+hasil.ToString("0.00"));
        }
        public virtual void HitungKeliling()
        {
            double hasil = getSisi()*4;
            Console.WriteLine("Luas Persegi : " + hasil.ToString("0.00"));
        }
    }
}
