using System;
using System.Reflection.Metadata;

namespace PBO_Inheritance_Module // Note: actual namespace depends on the project name.
{
    //mobil
    public class Mobil
    {
        //method
        public void NyalakanMesin()
        {
            Console.WriteLine("Mesin mobil " + merk + " bertipe " + tipe + " menyala");
        }
        public void MatikanMesin()
        {
            Console.WriteLine("Mesin mobil " + merk + " bertipe " + tipe + " mati");
        }


        //atribut
        public string merk;
        public string tipe;
        public Ban ban;

    }

    public class Toyota : Mobil
    {
        public Toyota()
        {
            merk = "Toyota";
        }
    }

    public class Agya : Toyota
    {
        public Agya()
        {
            tipe = "Agya";
        }
    }

    public class Innova : Toyota
    {
        public Innova()
        {
            tipe = "Innova";
        }
    }

    public class Avanza : Toyota
    {
        public Avanza()
        {
            tipe = "Avanza";
        }
        public void NyalakanLampu()
        {
            Console.WriteLine("Lampu mobil " + merk + " bertipe " + tipe + " menyala");
        }

    }

    public class Daihatsu : Mobil
    {
        public Daihatsu()
        {
            merk = "Daihatsu";
        }
    }

    public class Ayla : Daihatsu
    {
        public Ayla()
        {
            tipe = "Ayla";
        }
    }

    public class Xenia : Daihatsu
    {
        public Xenia()
        {
            tipe = "Xenia";
        }
    }


    public class Honda : Mobil
    {
        public Honda()
        {
            merk = "Honda";
        }
    }

    public class Brio : Honda
    {
        public Brio()
        {
            tipe = "Brio";
        }
    }

    public class Civic : Honda
    {
        public Civic()
        {
            tipe = "Civic";
        }
        public void VtecKickedIn()
        {
            Console.WriteLine("Ngeeeng Wooosh!!!");
        }
    }

    public class Ban
    {
        public void MerkBan()
        {
            Console.WriteLine(merk);
        }
        //atribut
        public string merk;

    }
    public class Michelin : Ban
    {
        public Michelin()
        {
            merk = "Michelin";
        }
    }

    public class Bridgestone : Ban
    {
        public Bridgestone()
        {
            merk = "Bridgestone";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1;
            mobil1 = new Agya();
            mobil1.ban = new Michelin();

            Mobil mobil2;
            mobil2 = new Avanza();
            mobil2.ban = new Bridgestone();

            Civic civic1;
            civic1 = new Civic();
            civic1.ban = new Bridgestone();

            //soal 1
            Console.WriteLine("Soal 1");
            mobil1.NyalakanMesin();
            mobil1.MatikanMesin();
            Console.WriteLine("");

            //soal 2
            Console.WriteLine("Soal 2");
            mobil2.NyalakanLampu();
            Console.WriteLine("");

            //soal 3
            Console.WriteLine("Soal 3");
            mobil1.ban.MerkBan();
            Console.WriteLine("");

            //soal 4
            Console.WriteLine("Soal 4");
            civic1.VtecKickedIn();
            Console.WriteLine("");

            //soal 5
            Console.WriteLine("Soal 5");
            Honda honda1;
            honda1 = new Civic();
            honda1.VtecKickedIn();
            Console.WriteLine("");

            Console.ReadLine();
        }
    }

}
