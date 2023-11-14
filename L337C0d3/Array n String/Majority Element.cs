using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L337C0d3.Array_n_String
{
    public class Majority_Element
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            int len = nums.Length / 2;
            foreach (int i in nums)
            {
                if (myDict.ContainsKey(i))
                {
                    myDict[i]++;
                }
                else
                {
                    myDict.Add(i, 1);
                }
                if (myDict[i] > len)
                {
                    return i;
                }
            }
            return 1;
        }
    }
}
