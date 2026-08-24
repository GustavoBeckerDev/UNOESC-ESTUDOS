public static class TransportEnumExtension
{
    public static char GetChar(this TransportEnumn transport)
    {
        switch (transport)
        {
            case TransportEnumn.BIKE:
                return 'B';
            case TransportEnumn.BUS:
                return 'U';
            case TransportEnumn.CAR:
                return 'C';
            case TransportEnumn.SUBWAY:
                return 'S';
            case TransportEnumn.WALK:
                return 'W';
        }
    }




}