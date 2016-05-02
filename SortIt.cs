/*
 * Created by SharpDevelop.
 * User: Slinky_Bass
 * Date: 2016/04/30
 * Time: 01:48 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace linear_sort
{
	/// <summary>
	/// SortIt() class performs an insertion sort on a dictionary object and has the property SortedResult
	/// </summary>
	public class SortIt
	{
		
		public List<KeyValuePair<string, string>> SortedResult = new List<KeyValuePair<string, string>>();
			
		//constructor, this is the thing that is called to instantiate the object LinearSort	
		public SortIt()
		{
			
		}	
		
		//insertionSort method
		public void InsertionSort(List<KeyValuePair<string, string>> BarcodeList)
		{			
					
			int SourceLength = BarcodeList.Count;
				
			//for every item in the source list:
		    for (int i = 0; i < SourceLength; i++)
		    {
		     	//get the key to sort on
				string SortKey = BarcodeList[i].Key;
				
		     	//if the new list is empty, add item
		     	if (SortedResult.Count == 0) 
		     	{
		     		SortedResult.Add(BarcodeList[i]);
		     	}
		     	
		     	else
		     	{
		     		int TargetLength = SortedResult.Count;
		     		
		     		//compare to each item in the target list
		     		for (int j = 0; j < TargetLength; j++)
		     		{
		     		 	//if the target item is bigger, put new item before it
		     		 	if (SortedResult[j].Key.CompareTo(SortKey) > 0)
			     		{
			     			SortedResult.Insert(j, BarcodeList[i]);	
			     			break;
			     		}
			     		
			     		//if at the end of the target list, add new item to end of the list
			     		else if (SortedResult.Count == j-1)
			     		{
			     			SortedResult.Add(BarcodeList[i]);
			     		}
		     		}	
		     	}		     	
		    }
		}		
	}
}