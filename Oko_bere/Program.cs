using System;

namespace Oko_bere
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Začínáme hru oko bere.");
			Random nahodne = new Random();
			int karta = nahodne.Nex­t(0, 11);
			int body = 0;
		
			Console.WriteLine("Máš " + body, "bodů");
			Console.WriteLine("Chceš další kartu? ");
			string odpoved = Console.ReadLine();

			if (odpoved == "ano")
			{
				karta += nahodne.Nex­t(0, 11);

				Console.Write("Otočil jsi kartu: " + karta);
				body += karta;
			}

			else if (odpoved == "ne")
			{
				if (body <= 21)
				{
					Console.WriteLine("Trefa - jsi vítěz. Máš " + body, "bodů.");
				}
				else if (body > 21)
				{
					Console.WriteLine("Prohrál jsi! Máš " + body, "bodů a to je moc!");
				}
			}
			else
			{
				Console.WriteLine("Co to říkáš? Nerozumím ti - buď ano nebo ne");
			}
			Console.ReadKey();
			
		}
			
       
    }
}
