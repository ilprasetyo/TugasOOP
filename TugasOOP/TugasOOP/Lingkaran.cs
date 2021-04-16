using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOOP
{
    
    class Lingkaran: ILingkaran
    {
        private double diameter;
        public void setDiameter(double d) {
            this.diameter = d;
        }
        public double getDiameter()
        {
            return diameter;
        }
        public void HitungLuas()
        {
            Console.WriteLine("Masukan Diameter(Cm) : ");
            setDiameter(diameter = Convert.ToDouble(Console.ReadLine()));

            double jari = getDiameter() / 2;
            double hasil = (Math.PI) * (Math.Pow(jari,2));
            Console.WriteLine("Luas Lingkaran : "+hasil.ToString("0.00"));
        }
        public void HitungKeliling()
        {
            double hasil = (Math.PI) * getDiameter();
            Console.WriteLine("Keliling Lingkaran : " + hasil.ToString("0.00"));
        }
    }
}
