public class Cars()
{
    public string Model { get; set; }

    public int Year { get; set; }

    public ColorsEnum CarColor{ get; set; }
}

public enum ColorsEnum
{
    RED,
    BLUE,
    WHITE,
    BLACK
}