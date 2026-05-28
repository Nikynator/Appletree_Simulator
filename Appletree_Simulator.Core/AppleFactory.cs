namespace Appletree_Simulator.Core;

public class AppleFactory
{
    public List<Apple> CreateApples(int applesAmount)
    {
        List<Apple> apples = new();

        for (int i = 0; i < applesAmount; i++)
        {
            Guid id = Guid.NewGuid();
            apples.Add(new Apple(id));
        }

        return apples;
    }
}