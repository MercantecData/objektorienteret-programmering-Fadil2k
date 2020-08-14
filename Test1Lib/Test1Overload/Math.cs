namespace Test1Overload
{
    public class Math
    {
        #region Plus method

        public int Plus(int a, int b)
        {
            return a + b;
        }

        public float Plus(float a, float b)
        {
            return a + b;
        }

        #endregion

        #region Minus method

        public int Minus(int a, int b)
        {
            return a - b;
        }

        public float Minus(float a, float b)
        {
            return a - b;
        }

        #endregion

        #region Multiply method

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public float Multiply(float a, float b)
        {
            return a * b;
        }

        #endregion

        #region Divide method

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public float Divide(float a, float b)
        {
            return a / b;
        }

        #endregion
    }
}