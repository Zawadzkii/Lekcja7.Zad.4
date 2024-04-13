using System;

class Program
{
	static void Main()
	{
		Console.Write("Podaj rok: ");

		// Pobranie roku od użytkownika i konwersja na typ int
		int rok = Convert.ToInt32(Console.ReadLine());

		// Sprawdzenie warunków dla roku przestępnego
		if ((rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0))
		{
			Console.WriteLine($"{rok} jest rokiem przestępnym.");
		}
		else
		{
			Console.WriteLine($"{rok} nie jest rokiem przestępnym.");
		}

		Console.ReadLine();
	}
}