namespace BindingAttributeInheritance.Drivers
{
    [Binding]
    public class CalculatorDriver
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Setting up the calculator.");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Cleaning up the calculator.");
        }
    }
}
