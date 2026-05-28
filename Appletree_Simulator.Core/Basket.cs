namespace Appletree_Simulator.Core;

public class Basket
{

    public readonly List<Apple> Apples = new();

    public void AddAppleToBasket(Apple apple)
    {
        this.Apples.Add(apple);
    }
}