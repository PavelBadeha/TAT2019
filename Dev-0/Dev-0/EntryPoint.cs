namespace Dev_0
{
    /// <summary>
    ///The main class of the program    
    /// </summary>
    class EntryPoint
    {
        /// <summary>
        /// The entry point.
        /// </summary>
        static void Main()
        {
          var calculator = new CalculatorMaximumNumberRepeatingLetters("asdffrtttsssssrt");
          int maximumNumberRepeatingLetters = calculator.Calculate();
        }
    }
}
