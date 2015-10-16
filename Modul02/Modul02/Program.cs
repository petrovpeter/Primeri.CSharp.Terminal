﻿using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		    //Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string program_name = "Modul02 - Примери";
			string program_version = "1.0";

			//Събиране на числа
		    a = 10;
			b = 5;

			sum = a + b;

			//За програмата
			Console.WriteLine ( program_name );
			Console.WriteLine ( "Версия: " + program_version + "\n\n" );


			//Писане в конзолата
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine ( sum );

			//Допълнителни оператори
			Console.WriteLine ("\nизползване на +=");
			a += b; //a = 10 + 5, a = a + b
			Console.WriteLine ( a );

			Console.WriteLine ("\nизползване на -=");
			a -= b; //a = 10 + 5, a = a + b
			Console.WriteLine ( a );

			Console.WriteLine ("\nизползване на *=");
			a *= b; //a = 10 + 5, a = a + b
			Console.WriteLine ( a );


			Console.WriteLine ("\nизползване на ++");
			a++; //a = 10 + 5, a = a + b
			Console.WriteLine ( a );

			Console.WriteLine ("Стандартно делене: " + ( 14 / 4).ToString ());    // -> 2 (7 / 3 = 2,3333)
			Console.WriteLine ("Остатък от делене: " + ( 14 % 4).ToString ()); // -> 1 ( 1/3 = 0.3333 )


		}
	}
}
