using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasOOP
{
    class Program
    {
        public void Restart()
        {
            String restart;
            Console.WriteLine("........");
            Console.WriteLine("Type Yes to restart program");
            restart = Console.ReadLine();

            if (restart.ToUpper() == "YES")
            {
                Main();
            }
        }
        private int menu;

        public void setMenu(int m)
        {
            this.menu = m;
        }

        public int getMenu()
        {
            return menu;
        }
        static void Main()
        {
            Program program = new Program();
            Persegi menu1 = new Persegi();
            PersegiPanjang menu2 = new PersegiPanjang();
            Lingkaran menu3 = new Lingkaran();

            int menu;
            try
            {

                Console.WriteLine("Program Hitung Luas dan Keliling Bangun Datar");
                Console.WriteLine("");
                Console.WriteLine("1. Persegi ");
                Console.WriteLine("2. Persegi Panjang");
                Console.WriteLine("3. Lingkaran");
                Console.WriteLine("4. Segitiga");
                Console.WriteLine("5. Trapesium");
                Console.WriteLine("");
                Console.WriteLine("Input Number From 1-5");

                program.setMenu(menu = Convert.ToInt16(Console.ReadLine()));

                switch (program.getMenu())
                {
                    case 1:
                        menu1.Inputan();
                        menu1.Line();
                        menu1.HitungLuas();
                        menu1.HitungKeliling();
                        program.Restart();
                        break;
                    case 2:
                        menu2.Inputan();
                        menu2.Line();
                        menu2.HitungLuas();
                        menu2.HitungKeliling();
                        program.Restart();
                        break;
                    case 3:
                        menu3.HitungLuas();
                        menu3.HitungKeliling();
                        program.Restart();
                        break;
                    case 4:
                        Segitiga menu4 = new Segitiga();
                        menu4.HitungLuas();
                        menu4.HitungKeliling();
                        program.Restart();
                        break;
                    case 5:
                        Trapesium menu5 = new Trapesium();
                        menu5.HitungLuas();
                        menu5.HitungKeliling();
                        program.Restart();
                        break;
                    default:
                        Console.WriteLine("Can't Insert " + program.getMenu());
                        Console.WriteLine("Please Insert Number 1-5");
                        program.Restart();
                        break;
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Please Insert Number, Not Alphabet");
                program.Restart();
            }
        }
    }
}
