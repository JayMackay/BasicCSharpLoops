using System;

namespace TestLoopProgram
{
    public class LoopMethods
    {
        //FOR LOOP METHOD
        public static int LowestForLoop(int[] nums)
        {
            int lowest = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < lowest)
                {
                    lowest = nums[i];
                }
            }
            return lowest;
        }

        //FOR EACH METHOD
        public static int LowestForEach(int[] nums)
        {
            int lowest = nums[0];
            foreach(int i in nums)
            {
                if(i < lowest)
                {
                    lowest = i;
                }
            }
            return lowest;
        }

        public static int calcDiv(int num1, int num2)
        {
            try
            {
                int calcDivOutput = num1 / num2;
            }
            catch(Exception)
            {
                throw new ArgumentException($"Can not divide by {num2}");
            }
            return num1 / num2;
        }
    }
}
