using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L337C0d3.Array_n_String;
namespace UnitTest.Array_n_String
{
    public class Majority_Element_Test
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 3 }, 3)]
        [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        public void Is_Majority_Element(int[] nums, int value)
        {
            var me = new Majority_Element();
            int result = me.MajorityElement(nums);

            Assert.Equal(value, result);
        }
    }
}
