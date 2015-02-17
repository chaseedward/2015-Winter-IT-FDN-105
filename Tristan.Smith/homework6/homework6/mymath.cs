namespace homework6
{
    public class MyMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public float Add(int a, float b)
        {
            return (float)a + b;
        }
        public float Add(float a, int b)
        {
            return a + (float)b;
        }
        public float Add(float a, float b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public float Subtract(float a, int b)
        {
            return a - (float)b;
        }
        public float Subtract(int a, float b)
        {
            return (float)a - b;
        }
        public float Subtract(float a, float b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public float Multiply(float a, int b)
        {
            return a * (float)b;
        }
        public float Multiply(int a, float b)
        {
            return (float)a * b;
        }
        public float Multiply(float a, float b)
        {
            return a * b;
        }
        public float Divide(int a, int b)
        {
            return (float)a / (float)b;
        }
        public float Divide(float a, int b)
        {
            return a / (float)b;
        }
        public float Divide(int a, float b)
        {
            return (float)a / b;
        }
        public float Divide(float a, float b)
        {
            return a / b;
        }
    }
}