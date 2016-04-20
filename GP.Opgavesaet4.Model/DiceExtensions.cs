public static class DiceExtensions
{
    public static int[] ThrowTimes(this Dice dice, int numberOfThrows)
    {
        if (numberOfThrows < 1) return new int[0];
        var throws = new int[numberOfThrows];
        for (var i = 0; i < numberOfThrows; i++)
        {
            dice.Throw();
            throws[i] = dice.show();
        }
        return throws;
    }
}