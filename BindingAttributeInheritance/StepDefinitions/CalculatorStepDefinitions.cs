using BindingAttributeInheritance.Drivers;

namespace BindingAttributeInheritance.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions : CalculatorDriver
    {
        private int _firstNumber;

        private int _secondNumber;

        private int _result;

        [Given("the first number is {int}")]
        public void GivenTheFirstNumberIs(int number)
        {
            _firstNumber = number;
        }

        [Given("the second number is {int}")]
        public void GivenTheSecondNumberIs(int number)
        {
            _secondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _firstNumber + _secondNumber;
        }

        [Then("the result should be {int}")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.That(result, Is.EqualTo(_result));
        }
    }
}
