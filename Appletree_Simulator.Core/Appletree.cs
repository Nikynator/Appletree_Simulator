namespace Appletree_Simulator.Core;

public class Appletree
{
    public List<Apple> Apples { get; }

    public Appletree()
    {
        AppleFactory factory = new();
        this.Apples = factory.CreateApples(10);
    }

    public bool PickApple(Guid id)
    {
        Apple? apple = this.Apples.FirstOrDefault(apple => apple.Id == id);

        if (apple == null)
        {
            return false;
        }

        this.Apples.Remove(apple);
        return true;
    }
}