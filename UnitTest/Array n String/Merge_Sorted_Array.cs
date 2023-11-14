using L337C0d3.Array_n_String;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Array_n_String
{
    public class Merge_Sorted_Array
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
        [InlineData(new int[] { 1 }, 1, new int[] {}, 0, new int[] {1})]
        [InlineData(new int[] { 0 }, 0, new int[] {1}, 1, new int[] { 1 })]
        public void Merge_Sorted_Array_Success(ref int[] nums1, int m, int[] nums2, int n, int[] value)
        {
            var msa = new MergeSortedArray();
            msa.Merge(nums1, m, nums2, n);

            Assert.Equal(value, nums1);
        }
    }
}
