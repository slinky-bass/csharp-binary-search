/*
 * Created by SharpDevelop.
 * User: Slinky_Bass
 * Date: 2016/05/02
 * Time: 08:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace csharp_binary_search
{
	/// <summary>
	/// Description of ConsoleLogIt.
	/// </summary>
	public class ConsoleLogIt
	{
		public ConsoleLogIt()
		{
		}
		
		//PRINT THE RESULTS TO THE CONSOLE...
		public void SearchOutput(string output)
		{	
			if (output != null) 
			{
				string CatalogueNum = output.Substring(0, 15);
				string Price = output.Substring(28, 7);
				string Quantity = output.Substring(35, 3);
				Console.WriteLine("Catalogue: {0} \n\r Price: {1} \n\r Quantity: {2}", CatalogueNum, Price, Quantity);
				Console.ReadKey(true);
			}
		}
	}
}