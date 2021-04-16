using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOOP
{
    class Trapesium
    {
        private double atas, bawah, tinggi, sisi_miring;
        public void setAtas(double a)
        {
            this.atas = a;
        }
        public double getAtas()
        {
            return atas;
        }
        public void setBawah(double b)
        {
            this.bawah = b;
        }
        public double getBawah()
        {
            return bawah;
        }
        public void setTinggi(double t)
        {
            this.tinggi = t;
        }
        public double getTinggi()
        {
            return tinggi;
        }
        public void setSisi(double s)
        {
            this.sisi_miring = s;
        }
        public double getSisi()
        {
            return sisi_miring;
        }
        public Trapesium()
        {
            Console.WriteLine("Masukan Sisi Atas Trapesium(Cm) : ");
            setAtas(atas = Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Masukan Sisi Bawah Trapesium(Cm) : ");
            setBawah(bawah = Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Masukan Tinggi Trapesium(Cm) : ");
            setTinggi(tinggi = Convert.ToDouble(Console.ReadLine()));
        }

        public void HitungLuas()
        {
            double hasil = 0.5 * (getAtas()+getBawah()) * getTinggi();
            Console.WriteLine("Luas Trapesium : " + hasil.ToString("0.00"));
        }
        public void HitungKeliling()
        {
            double alas_pinggir = (getBawah() - getAtas()) * 0.5;
            sisi_miring = (Math.Pow(alas_pinggir, 2)) + (Math.Pow(getTinggi(), 2));
            setSisi(Math.Sqrt(sisi_miring));
            double hasil = (getSisi() * 2) + getAtas()+getBawah();
            Console.WriteLine("Keliling Trapesium : " + hasil.ToString("0.00"));
        }
    }
}
