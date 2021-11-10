using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG_Map
{
	class Program
	{

		static int x = 0;
		static int y = 0;
		//static	char[,] Area = new char[3, 3];
		static System.Random random = new System.Random();
		//static int scale;
	
		static char[,] map = new char[,] // dimensions defined by following data:
		{
				{'/','^','^','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/'},
				{'/','^','^','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/'},
				{'/','^','^','/','/','/','/','/','/','/','/','/','/','/','/','*','*','/','/','/','/','/','/','/','/','/','/','/','/','/'},
				{'/','^','^','/','/','/','/','/','/','/','/','/','/','/','/','/','*','/','/','/','/','/','~','/','/','/','/','/','/','/'},
				{'/','^','^','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','~','/','/','/','/','/','/','/'},
				{'/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','~','~','/','/','/','/','/','/','/'},
				{'/','^','^','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','~','/','/','/','/','/','/','/','/'},
				{'/','^','^','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/'},
				{'/','^','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/'},
				{'/','^','^','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','*','*','/','/','/','/','/','/','/','/','/'},
				{'/','^','^','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','*','*','*','/','/','/','/','/','/','/'},
				{'/','^','^','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/','/'},

		};

		static void Main(string[] args)
		{
			Console.WriteLine();
			DisplayMap();
			Console.ReadKey(true);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Display map 2x");
			DisplayMap(2);
			Console.ReadKey(true);
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Display map 3x");
			DisplayMap(3);
			Console.ReadKey(true);
			Console.WriteLine();
		}



		static void DisplayMap()
		{



			Console.WriteLine(" map legend: ");
			Console.WriteLine(" ^ = mountain = Gray");
			Console.WriteLine(" / = grass = white ");
			Console.WriteLine(" ~ = water = blue ");
			Console.WriteLine(" * = trees = green ");
			/*char[,] Area = new char[3, 3];
			Area[0, 0] = '~';
			Area[0, 1] = '+';
			Area[0, 2] = '~';
			Area[1, 0] = '+';
			Area[1, 1] = '~';
			Area[1, 2] = '+';
			Area[2, 0] = '~';
			Area[2, 1] = '+';
			Area[2, 2] = '~';*/

			Console.Write("╔");
			for (int TopBorder = 0; TopBorder < map.GetLength(1); TopBorder++)
			{
				Console.Write("═");
			}

			Console.WriteLine("╗");
			for (int x = 0; x <= 11; x++)
			{
				Console.Write("▒");

				for (int y = 0; y <= 29; y++)
				{

					Console.Write(map[x, y]);

				}

				Console.WriteLine("▒");
			}
			Console.Write("╚");
			for (int BottomBorder = 0; BottomBorder < map.GetLength(1); BottomBorder++)
			{
				Console.Write("═");
			}
			Console.WriteLine("╝");





		}


		static void DisplayMap(int scale)
		{
			//Border(scale);
/*			Console.Write("╔");
			for (int TopBorder = 0; TopBorder <= map.GetLength(0) * scale; TopBorder++)
			{
				Console.WriteLine("═");
			}
			Console.Write("╚");*/

/*			Console.Write("╗");
			for (int BottomBorder = 0; BottomBorder <= map.GetLength(0) * scale; BottomBorder++)
			{
				Console.WriteLine("═");
			}
			Console.Write("╝");*/


			Console.Write("╔");
			for (int TopBorder = 0; TopBorder < map.GetLength(1) * scale; TopBorder++)
			{
				Console.Write("═");
			}
			
			Console.WriteLine("╗");

			for (int x = 0; x < map.GetLength(0); x++)
			{

				for (int xx = 0; xx < scale; xx++)
				{
					Console.Write("▒");
					
					for (int y = 0; y < map.GetLength(1); y++)
					{
						
						for (int yy = 0; yy < scale; yy++)
						{

							Console.Write(map[x, y]);
						}
						
					}
					Console.WriteLine("▒");
				}

			}
			Console.Write("╚");
			for (int BottomBorder = 0; BottomBorder < map.GetLength(1) * scale; BottomBorder++)
			{
				Console.Write("═");
			}
			Console.WriteLine("╝");



		}

		static void ColorCode(int x ,int y)
		{
			
			/*for (map[x, y] == "*")
			{
				Console.ForegroundColor = ConsoleColor.Green;
			}*/
		}

	}
}
