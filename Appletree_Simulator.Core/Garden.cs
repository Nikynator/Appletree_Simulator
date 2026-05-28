namespace Appletree_Simulator.Core;

public class Garden
{
    private readonly Appletree appletree = new();

    public List<Apple> GetApples()
    {
        return this.appletree.Apples;
    }

    public bool TakeApple(Guid id)
    {
        bool applePicked = this.appletree.PickApple(id);

        return applePicked;
    }
}