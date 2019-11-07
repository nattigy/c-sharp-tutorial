using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class Numbers
    {
        string[] nums = new string[10];
        public void push(string chr)
        {
            nums[nums.Length - 1] = chr;
        }

        public string pop()
        {
            string val = nums[nums.Length - 1];
            nums[nums.Length - 1] = null;
            return val;
        }
    }

}
