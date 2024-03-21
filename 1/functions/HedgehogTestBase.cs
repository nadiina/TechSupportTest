public class HedgehogTestBase
{
    public static int MinEncounters(int[] hedgehogs, int desiredColor)
    {
        int moves = 0;
        if (hedgehogs[0] == 0 && hedgehogs[1] == 0 && hedgehogs[2] == 0)
        {
            return -1;
        }

        if (hedgehogs[(desiredColor + 1) % 3] == hedgehogs[(desiredColor + 2) % 3])
        {
            moves += hedgehogs[(desiredColor + 1) % 3];
            hedgehogs[(desiredColor + 1) % 3] -= hedgehogs[(desiredColor + 1) % 3];
            hedgehogs[(desiredColor + 2) % 3] -= hedgehogs[(desiredColor + 2) % 3];
        }
        if (hedgehogs[(desiredColor + 1) % 3] == 0 || hedgehogs[(desiredColor + 2) % 3] == 0)
        {
            return -1;
        }
        moves += HandleColorComparison(hedgehogs, desiredColor, moves);

        return moves;
    }

    private static int HandleColorComparison(int[] hedgehogs, int desiredColor, int moves)
    {
        if (hedgehogs[(desiredColor + 1) % 3] > hedgehogs[(desiredColor + 2) % 3])
        {
            moves += hedgehogs[(desiredColor + 2) % 3];
            hedgehogs[desiredColor] += 2 * hedgehogs[(desiredColor + 2) % 3];
            hedgehogs[(desiredColor + 1) % 3] -= hedgehogs[(desiredColor + 2) % 3];
            hedgehogs[(desiredColor + 2) % 3] -= hedgehogs[(desiredColor + 2) % 3];

            if (hedgehogs[(desiredColor + 2) % 2] > hedgehogs[desiredColor])
            {
                return -1;
            }
            else
            {
                moves += hedgehogs[(desiredColor + 1) % 3];
            }

        }
        if (hedgehogs[(desiredColor + 1) % 3] < hedgehogs[(desiredColor + 2) % 3])
        {
            moves += hedgehogs[(desiredColor + 1) % 3];
            hedgehogs[desiredColor] += 2 * hedgehogs[(desiredColor + 1) % 3];
            hedgehogs[(desiredColor + 2) % 3] -= hedgehogs[(desiredColor + 1) % 3];
            hedgehogs[(desiredColor + 1) % 3] -= hedgehogs[(desiredColor + 1) % 3];

            if (hedgehogs[(desiredColor + 1) % 3] > hedgehogs[(desiredColor)])
            {
                return -1;
            }
            else
            {
                moves += hedgehogs[(desiredColor + 2) % 3];
            }
        }
        return moves;
    }

}