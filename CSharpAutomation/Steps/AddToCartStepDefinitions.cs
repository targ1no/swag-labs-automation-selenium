using System;
using TechTalk.SpecFlow;

namespace CSharpAutomation
{
    [Binding]
    public class AddToCartStepDefinitions
    {
        [Given(@"that the user wants to add an item to the cart")]
        public void GivenThatTheUserWantsToAddAnItemToTheCart()
        {
            throw new PendingStepException();
        }

        [When(@"he chooses the product and clicks on the ""([^""]*)"" button")]
        public void WhenHeChoosesTheProductAndClicksOnTheButton(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"click on the cart icon in the upper right corner of the page")]
        public void WhenClickOnTheCartIconInTheUpperRightCornerOfThePage()
        {
            throw new PendingStepException();
        }

        [Then(@"he should be able to view the item successfully added to the cart")]
        public void ThenHeShouldBeAbleToViewTheItemSuccessfullyAddedToTheCart()
        {
            throw new PendingStepException();
        }
    }
}
