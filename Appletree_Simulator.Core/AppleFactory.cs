using System;

namespace Appletree_Simulator.Core;

public class AppleFactory
{
    public Apple[] CreateApples(int applesAmount)
    {
        Apple[] apples = new Apple[applesAmount];

        for (int idNumberIndex = 0; idNumberIndex < applesAmount; idNumberIndex++)
        {
            Guid id = Guid.NewGuid();

            apples[idNumberIndex] = new Apple(id);
        }
        return apples;
    }
}