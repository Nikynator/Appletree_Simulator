namespace Appletree_Simulator.Core;

public class Garden
{
    private readonly Appletree Appletree = new Appletree();

    public Apple[] GetApples()
    {
        return this.Appletree.Apples;
    }

    public bool TakeApple(Guid id)
    {
        this.Appletree.PickApple(id);

        return true;
    }
}