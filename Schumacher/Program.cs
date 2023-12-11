namespace Schumacher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Eredmeny> eredmenyek = new List<Eredmeny>();
            string[] olvasottEredmenyek = File.ReadAllLines("Source\\schumacher.csv");
            for (int i = 1; i < olvasottEredmenyek.Length; i++)
            {
                string[] tagok = olvasottEredmenyek[i].Split(';');
                Eredmeny ujEredmeny = new Eredmeny(DateTime.Parse(tagok[0]), tagok[1], int.Parse(tagok[2]), int.Parse(tagok[3]), int.Parse(tagok[4]), tagok[5], tagok[6]);
                eredmenyek.Add(ujEredmeny);
            }

            //3.feladat:
            Console.WriteLine($"3. feladat: {eredmenyek.Count()}");

            //4.feladat:
            Console.WriteLine("Magyar Nagydíj helyezései");
            foreach (var i in eredmenyek)
            {
                if (i.Grandprix == "Hungarian Grand Prix" && i.Position > 0)
                {
                    Console.WriteLine($"\t{i.Date.ToShortDateString()} : {i.Position}. hely");
                }
            }

            //5.feladat:
            Console.WriteLine("5. feladat: Hibastatisztika");

        }
    }
}