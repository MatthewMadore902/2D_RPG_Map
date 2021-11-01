using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_RPG_Map
{
	class Program
	{

		static	char[,] Area = new char[3, 3];
		static System.Random random = new System.Random();
	

		static void DisplayMap()
		{
			/*char[,] Area = new char[3, 3];
			Area[0, 0] = '~';
			Area[0, 1] = '+';
			Area[0, 2] = '~';
			Area[1, 0] = '+';
			Area[1, 1] = '~';
			Area[1, 2] = '+';
			Area[2, 0] = '~';
			Area[2, 1] = '+';
			Area[2, 2] = '~';

			for (int x = 0; x <= 2; x++)
			{
				
				Console.WriteLine("catagory");

				for (int y = 0; y <= 2; y++ )
				{
					Console.WriteLine(Area[x, y]);
				}
			}*/
		}


		static void Main(string[] args)
		{
			DisplayMap();
			Console.ReadKey(true);
		}
	}
}
