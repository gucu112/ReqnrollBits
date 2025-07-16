namespace BindingAttributeInheritance.StepDefinitions
{
    [Binding]
    public sealed class PhoneStepDefinitions : Steps
    {
        private bool _wasCalled = false;

        [Given("the phone number {int}")]
        public void GivenThePhoneNumber(string phoneNumber)
        {
            ScenarioContext["PhoneNumber"] = phoneNumber;
        }

        [Given("the second phoner number {int}")]
        public void GivenTheSecondPhoneNumber(string phoneNumber)
        {
            GivenThePhoneNumber(phoneNumber);
        }

        [When("the phone call is made")]
        public void WhenTheTwoNumbersAreAdded()
        {
            var phoneNumber = (string)ScenarioContext["PhoneNumber"];
            MakePhoneCall(phoneNumber);
        }

        [Then("the phone call happened")]
        public void ThenTheResultShouldBe()
        {
            Assert.That(_wasCalled, Is.True);
        }

        private void MakePhoneCall(string phoneNumber)
        {
            _wasCalled = true;
            Console.WriteLine($"Making a phone call to {phoneNumber}.");
        }
    }
}
