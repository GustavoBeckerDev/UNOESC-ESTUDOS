public static class TransportEnumExtension
{
    public static char GetChar(this TransportEnum transport)
    {
        switch (transport)
        {
            case TransportEnum.BIKE:
                return 'B';
            case TransportEnum.BUS:
                return 'U';
            case TransportEnum.CAR:
                return 'C';
            case TransportEnum.SUBWAY:
                return 'S';
            case TransportEnum.WALK:
                return 'W';
            default:
                return 'D';
        }
    }




}