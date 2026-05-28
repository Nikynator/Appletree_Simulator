namespace Appletree_Simulator.Core;

public class Basket
{

    public readonly List<Apple> Apples = new List<Apple>();

    public void AddAppleToBasket(Apple apple)
    {
        this.Apples.Add(apple);
    }
}