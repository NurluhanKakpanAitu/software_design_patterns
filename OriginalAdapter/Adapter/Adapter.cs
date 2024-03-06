namespace OriginalAdapter.Adapter;

public class Adapter : Original, ITarget
{
    public void ClientDouble(double input)
    {
        OriginalDouble(input);
    }

    public void ClientInt(int input)
    {
        base.OriginalInt(input * 2);
    }

    public void ClientChar(char input)
    {
        for (var i = 0; i < 5; i++)
        {
            base.OriginalChar(input);
        }
    }
}