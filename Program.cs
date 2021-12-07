using System;
using System.Linq;

class Latihan_AP_Statistik_Kata
{
	static void Main(string[] args)
	{
		Console.Write("Input Kalimat : ");
		var inputKalimat = Console.ReadLine();
		while (inputKalimat.Length < 3)
		{
			Console.WriteLine("KATA PADA KALIMAT KURANG PANJANG");
			Console.Write("Input Kalimat : ");
			inputKalimat = Console.ReadLine();
        }
		Console.Write("Input Kata : ");
		var inputKata = Console.ReadLine();
		while (inputKata.Length < 2)
        {
			Console.WriteLine("HURUF PADA KATA KURANG PANJANG");
			Console.Write("Input Kata : ");
			inputKata = Console.ReadLine();
        }
		Console.WriteLine("\nStatistik Huruf : ");
		while (inputKalimat.Length > 0)
        {
			if (inputKalimat[0] != ' ')
				Console.Write($"{inputKalimat[0]} = ");
				
			int counter = 0;
			for (int i = 0; i < inputKalimat.Length; i++)
			{
				if (inputKalimat[0] == inputKalimat[i])
					counter++;
			}
			if (inputKalimat[0] != ' ')
				Console.WriteLine(counter);
			inputKalimat = inputKalimat.Replace(inputKalimat[0].ToString(), string.Empty);
        }
	}
}