/*
 * Created by SharpDevelop.
 * User: Slinky_Bass
 * Date: 2016/05/02
 * Time: 07:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace csharp_binary_search
{
	/// <summary>
	/// Description of SearchIt.
	/// </summary>
	public class SearchIt
	{
		public SearchIt()
		{
		}
		
		public string BinarySearch(List<KeyValuePair<string, string>> BarcodeList, string key)
		{
			int lower = 0;
			int upper = BarcodeList.Count - 1;
			
			while (lower <= upper) 
			{
				int middle = lower + (upper - lower) / 2;
				string position = BarcodeList[middle].Key;
			        
				if (key.CompareTo(position) < 0)
				{
					upper = middle - 1;
				}
				
				else if (key.CompareTo(position) > 0)
				{
					lower = middle + 1;
				}
				
				else if (key.CompareTo(position) == 0)
				{
					return BarcodeList[middle].Value;	
				}
			}
			return null;		
		}
	}
}
