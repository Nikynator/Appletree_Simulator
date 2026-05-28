namespace Appletree_Simulator.Core;

public class Appletree
{
    public Apple[] Apples { get; }

    public Appletree()
    {
        AppleFactory factory = new AppleFactory();
        this.Apples = factory.CreateApples(10);
    }

    public bool PickApple(Guid id)
    {
        for (int i = 0; i < this.Apples.Length; i++)
        {
            if (this.Apples[i] != null && this.Apples[i].Id == id)
            {
                this.Apples[i] = null!;
                return true;
            }
        }
        return false;
    }
}