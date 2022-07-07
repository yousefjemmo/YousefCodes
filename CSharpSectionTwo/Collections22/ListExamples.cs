
using System.Collections.Generic;

namespace Collections22
{
    internal class ListExamples
    {
        public List<int> FindLargest(List<List<int>> collections)
        {
            List<int> resultList = new List<int>();
            foreach (var itemList in collections) 
            {
                int tempInt = int.MinValue;
                foreach (var item in itemList)
                {
                    if (tempInt != int.MinValue)
                    {
                        if (tempInt < item)
                        {
                            tempInt = item;
                        }
                    }
                    else
                    {
                        tempInt = item;
                    }
                }
                if (tempInt != int.MinValue)
                {
                    resultList.Add(tempInt);
                }
            }
            return resultList; 
        }
    }
}
