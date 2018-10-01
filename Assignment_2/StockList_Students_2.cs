using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
        //@author: qing qi
        //param   (StockList)listToMerge : second list to be merged 
        //summary      : merge two different list into a single result list
        //return       : merged list
        //return type  : StockList
        public StockList MergeList(StockList listToMerge)
        {
            StockList resultList = new StockList();
            StockNode stockNode = this.head;
            for (; stockNode != null; stockNode = stockNode.Next)
            {
                if (listToMerge.Contains(stockNode.StockHolding) == null)
                {
                    listToMerge.AddStock(stockNode.StockHolding);
                }
                else
                {
                    continue;
                }
            }
            resultList = listToMerge;
            return resultList;
        }

        //@author: qing qi
        //param        : NA
        //summary      : finds the stock with most number of holdings
        //return       : stock with most shares
        //return type  : Stock
        public Stock MostShares()
        {

            StockNode sn = this.head;
            Stock mostShareStock = sn.StockHolding;
            for (; sn != null; sn = sn.Next)
            {
                if (sn.StockHolding.Holdings > mostShareStock.Holdings)
                {
                    mostShareStock = sn.StockHolding;
                }
            }
            return mostShareStock;
        }

        //@author: qing qi
        //param        : NA
        //summary      : finds the number of nodes present in the list
        //return       : length of list
        //return type  : int
        public int Length()
        {
            int length = 0;
            StockNode sn = this.head;
            for (; sn != null; sn = sn.Next)
            {
                length++;
            }
            return length;
        }
    }
}