using System;
using Common.MathLib;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace mathlib.tests.Steps
{
    [Binding]
    public class FibonacciNumberSteps
    {
        [Given(@"I want to get (.*) fibonacci number")]
        public void GivenIWantToGetFibonacciNumber(int nth)
        {
            ScenarioContext.Current.Set(nth, "nth");
        }
        
        [When(@"I execute the service")]
        public void WhenIExecuteTheService()
        {
            var nth = ScenarioContext.Current.Get<int>("nth");
            var number = Fibonacci.GetBinonacciNumber(nth);
            ScenarioContext.Current.Set(number, "number");
        }
        
        [Then(@"I should get the following (.*)")]
        public void ThenIShouldGetTheFollowing(int expected)
        {
            var actual = ScenarioContext.Current.Get<int>("number");
            actual.Should().Be(expected);
        }
    }
}