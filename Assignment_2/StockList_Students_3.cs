using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
        //param        : NA
        //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
        //return       : total value
        //return type  : decimal
        public decimal Value()
        {
            decimal value = 0.0m;
            StockNode stockNode = this.head;
            for (; stockNode != null; stockNode = stockNode.Next)
            {
                value += stockNode.StockHolding.Holdings * stockNode.StockHolding.CurrentPrice;
            }
            return value;

        }


        //param  (StockList) listToCompare     : StockList which has to comared for similarity index
        //summary      : finds the similar number of nodes between two lists
        //return       : similarty index
        //return type  : int
        public int Similarity(StockList listToCompare)
        {
            int similarityIndex = 0;
            StockNode list2Node = listToCompare.head;
            for (; list2Node != null; list2Node = list2Node.Next)
            {
                StockNode list1Node = this.head;
                for (; list1Node != null; list1Node = list1Node.Next)
                {
                    if (list1Node.StockHolding.Name == list2Node.StockHolding.Name)
                    {
                        similarityIndex += 1;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return similarityIndex;
        }

        //param        : NA
        //summary      : Print all the nodes present in the list
        //return       : NA
        //return type  : NA
        public void Print()
        {
            StockNode sn = this.head;
            for (; sn != null; sn = sn.Next)
            {
                Console.WriteLine(sn.StockHolding.ToString());
            }
        }
    }
}