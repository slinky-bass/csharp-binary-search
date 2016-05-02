/*
 * Created by SharpDevelop.
 * User: Slinky_Bass
 * Date: 2016/04/10
 * Time: 02:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;

namespace csharp_binary_search
{

	class Program
	{	
	
		public static void Main()
		{	
			string line;
			StreamReader OriginalCatalogue = new StreamReader(@"c:\Sites\Mus777.cat");
			List<KeyValuePair<string, string>> BarcodeList = new List<KeyValuePair<string, string>>();
			SortIt BarcodeSort = new SortIt();
			SearchIt BarcodeSearch = new SearchIt();
			ConsoleLogIt SearchResult = new ConsoleLogIt();
		
			while((line = OriginalCatalogue.ReadLine()) != null)
			{		
				if (line != "") 
				{	
					string Barcode = line.Substring(15, 13);	
					BarcodeList.Add(new KeyValuePair<string, string>(Barcode, line));
				}
			}
			
			BarcodeSort.InsertionSort(BarcodeList);
			OriginalCatalogue.Close();		
			string output = BarcodeSearch.BinarySearch(BarcodeSort.SortedResult, "6001491206920");
			
			if (output != null)
			{
				SearchResult.SearchOutput(output);	
			}
			
			else 
			{
				Console.WriteLine("The barcode you searched for does not exist, please try again");
			}				
		}	
	}		
}