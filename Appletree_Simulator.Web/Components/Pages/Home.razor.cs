using Appletree_Simulator.Core;

namespace Appletree_Simulator.Web.Components.Pages;

public partial class Home
{
    private readonly Basket basket = new();
    private readonly Garden garden = new();

    private void Pick(Apple apple)
    {
        bool sucessfullPick = this.garden.TakeApple(apple.Id);

        if (!sucessfullPick)
        {
            ErrorStatus();
        }
        else
        {
            this.basket.AddAppleToBasket(apple);
        }
    }

    private static void ErrorStatus()
    {
        Console.WriteLine("There has been a problem with the PickApple Methode");
    }
}