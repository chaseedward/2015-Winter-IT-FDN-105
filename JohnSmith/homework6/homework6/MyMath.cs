namespace homework6_myMath
{
    public class MyMath
    {
        // 
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public float Divide(float num1, float num2)
        {
            if (num2 != 0.0)
            {
                return (num1 / num2);
            }
            else
            {
                return 0;
            }
        }
    }
}