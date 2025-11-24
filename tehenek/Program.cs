
namespace tehenek
{
    internal class Program
    {

        static List<Tehen> happyCows = new List<Tehen>();
        static void Main(string[] args)
        {
            Tehen tehen1 = new Tehen("19");
            tehen1.EredmenytRogzit("0", "14");
            tehen1.EredmenytRogzit("2", "5");
            tehen1.EredmenytRogzit("5", "8");
            Beolvasas("hozam.txt");
            Feladat_3();
        }

        private static void Feladat_3()
        {
            Console.WriteLine("Az állomány " + happyCows.Count() + " tehén adatait tartalmazza.");
        }

        public static void Beolvasas(string fajlNev)
        {
            StreamReader sr = new StreamReader(fajlNev);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string id = sor.Split(';')[0];
                string nap = sor.Split(';')[1];
                string menyiseg = sor.Split(';')[2];
                Tehen aktTehen = new Tehen(id);
                if (!happyCows.Contains(aktTehen))
                {
                    happyCows.Add(aktTehen);
                }
                int index = happyCows.IndexOf(aktTehen);
                happyCows[index].EredmenytRogzit(nap, menyiseg);
            }
        }
    }
}
