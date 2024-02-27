namespace ConsoleApp8
{
    class Program
    {



        static void Main(string[] args)
        {
            ShowData();
        }





        static void ShowData()
        {
            string file = @"tools.txt";
            string[] ProducentTools = { "Bosch", "NoName", "Stihl", "Wakus" };
            string[] TypTools = { "Elektr", "Mech", "Pneum" };
            int[] CenyTools = { 340, 220, 430, 470, 320, 290, 210, 330, 440 };
            var rand = new Random();
            using (StreamReader sr = File.OpenText(file))
            {
                string s;
                int i = 0;
                Tools[] tools = new Tools[9];
                while ((s = sr.ReadLine()) != null)
                {
                    var tab = s.Split(";");
                    if (tab[0] == "1")
                    {


                        int index = rand.Next(3);
                        Mech mech = new Mech(CenyTools[index]);
                        mech.SetInfo(tab[1], tab[2], (Convert.ToInt32(tab[3])));
                        tools[i] = mech;
                        tools[i].Info();
                        i++;


                    }

                }
            }
        }



        class Tools
        {

            private string Producent;
            private string Typ;
            private int Cena;
            public void SetInfo(string producent, string typ, int cena)
            {
                this.Producent = producent;
                this.Typ = typ;
                this.Cena = cena;
            }
            public virtual void Info()
            {

            }



        }



        class Mech : Tools
        {
            private bool Touch = true;
            private int Cena = 0;
            public Mech(int cena)
            {
                Cena = cena;
            }
            public override void Info()
            {
                Console.WriteLine("Cena: " + Cena);
            }



        }



        class Elektr : Tools
        {

            private string Produkt = "Pogchamp";
            string[] kolory = new string[] { "czerwony", "zielony", "niebieski" };
            Random rnd = new Random();
            int index = rnd.Next(names.Length);
            Console.WriteLine($"Produkt: {kolory[index]}");
            public Elektr(string produkt)
            {
                Produkt = produkt;
            }
            public override void Info()
            {
                base.Info();
                Console.WriteLine(": " + Produkt);



            }
        }
        class Pneum : Tools
        {



            private string Produkt = "Pogchamp";
            string[] model = new string[] { "Jakos20", "Moden321" };
            Random rnd = new Random();
            int index = rnd.Next(names.Length);
            public Pneum(string produkt)
            {
                Produkt = produkt;
            }
            public override void Info()
            {
                base.Info();
                Console.WriteLine(": " + Produkt);



            }



        }



    }
}