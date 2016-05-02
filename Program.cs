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
using System.Collections;
using System.Collections.Generic;

namespace binary_search
{
	class Program
	{
		//TIL: VOID MEANS THIS METHOD DOES NOT RETURN SOMETHING	
		public static void Main(string[] args) 
		{		
			//REUSE STUFF FROM FIRST APP
			string line;
			StreamReader Catalogue = new StreamReader(@"c:\Sites\reorder.cat");
			SortedList BarfcodeSort = new SortedList();	
	
			while((line = Catalogue.ReadLine()) != null) 
			{
				if (line != "")
				{
					string barfcode = line.Substring(15, 13);		
					BarfcodeSort.Add(barfcode, line);
				}
			}
			
			//PROMPT USER FOR INPUT
			Console.Write("Please enter the barcode you wish to search for \n\r");
			
			//PAUSE APP AND WAIT FOR INPUT, READLINE COMPLETES ON ENTER AND RETURNS A STRING
			string input = Console.ReadLine();
			
			//CONVERT STRING TO INT BECAUSE TRYING TO COMPARE STRING TO STRING LATER ON IN BINARYSEARCH GAVE ME AN ERROR!!
			//LONG IS THE EQUIVALENT OF INT32, USING BECAUSE THE BARCODE IS TOO BIG FOR REGULAR INT(32)!!
			long key = long.Parse(input);
			
			Catalogue.Close();
			
			string output = BinarySearch(BarfcodeSort, key);
			SearchOutput(output);
		}
		
		
		//SPECIFYING STRING HERE INSTEAD OF VOID AS THIS FUNCTION RETURNS A STRING
		public static string BinarySearch(SortedList BarfcodeSort, long key)
		{
			//SET SEARCH RANGE
			int lower = 0;
			int upper = BarfcodeSort.Count - 1;
			
			//BINARY SEARCH USES DIVIDE AND CONQUER TO HALVE SEARCH TIME
			while (lower <= upper) 
			{
				
				//METHOD FOR CALCULATING MIDDLE
				int middle = lower + (upper - lower) / 2;
				
				//FIND THE MID POINT OF THE ARRAY SO THE RANGE TO SEARCH CAN BE DIVIDED INTO TWO HALVES
				long position = Convert.ToInt64(BarfcodeSort.GetKey(middle));
			        
				if (key < position)
				{
					upper = middle - 1;
				}
				
				else if (key > position) 
				{
					lower = middle + 1;
				}
				
				else 
				{
					//IF KEY IS NEITHER GREATER NOR LESSER THAN POSITION, RETURN THE VALUE ASSOCIATED WITH THE POSITION KEY AND CAST IT TO STRING	
					return BarfcodeSort.GetValueList()[middle].ToString();
				}
			}
			return null;		
		}
		
		//PRINT THE RESULTS TO THE CONSOLE...
		public static void SearchOutput(string output)
		{
			string CatalogueNum = output.Substring(0, 15);
			string Price = output.Substring(28, 7);
			string Quantity = output.Substring(35, 3);
			Console.WriteLine("Catalogue: {0} \n\r Price: {1} \n\r Quantity: {2}", CatalogueNum, Price, Quantity);
			Console.ReadKey(true);
		}		
	}
}