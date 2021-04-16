using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOOP
{
    class Segitiga
    {
        private double alas, tinggi, sisi_miring;
        public void setAlas(double a)
        {
            this.alas = a;
        }
        public double getAlas()
        {
            return alas;
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
        public Segitiga()
        {
            Console.WriteLine("Masukan Alas Segitiga(Cm) : ");
            setAlas(alas = Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Masukan Tinggi Segitiga(Cm) : ");
            setTinggi(tinggi = Convert.ToDouble(Console.ReadLine()));
        }

        public void HitungLuas()
        {
            double hasil = 0.5 * getAlas() * getTinggi();
            Console.WriteLine("Luas Segitiga : " + hasil.ToString("0.00"));
        }
        public void HitungKeliling()
        {
            sisi_miring = (Math.Pow(0.5 * getAlas(), 2)) + (Math.Pow(getTinggi(), 2));
            setSisi(Math.Sqrt(sisi_miring));
            double hasil = (getSisi()*2) + getAlas();
            Console.WriteLine("Keliling Segitiga : " + hasil.ToString("0.00"));
        }
    }
}
