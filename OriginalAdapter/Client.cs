using OriginalAdapter.Adapter;

namespace OriginalAdapter;

public class Client(ITarget target)
{
    private readonly ITarget _target = target;

    public void ShowResult()
    {
        _target.ClientChar('h');
        _target.ClientDouble(3.2);
        _target.ClientInt(5);
    }
}