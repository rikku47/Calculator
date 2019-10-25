namespace Calculator.MathEx
{
    public class Result
    {
        public Result(int integer = 0, float @float = 0, double @double = 0)
        {
            Integer = integer;
            Float = @float;
            Double = @double;
        }

        public int Integer { get; set; }
        public float Float { get; set; }
        public double Double { get; set; }
    }
}
