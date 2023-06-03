using System;


class Program
{
	static void Main()
	{
		int number = 0;
		for (int i = 1; i <= 1000; i++)
		{
			if (i % 7 == 0 && i % 13 == 0 && i % 17 == 0)
			{
				number = i;
				break;
			}
		}

		if (number != 0)
		{
			Console.WriteLine("O primeiro número divisível por 7, 13 e 17 é: " + number);
		}
		else
		{
			Console.WriteLine("Nenhum número divisível por 7, 13 e 17 encontrado entre 1 e 1000.");
		}
	}
}
//Alteração V2.0
//Alteração V2.1
//Alteração V2.2
//Alteração V3.0
//Alteração V3.1
//Alteração V3.2
//Alteração V4.0
//Alteração V4.1
//Alteração V4.2
//Alteração V5.0