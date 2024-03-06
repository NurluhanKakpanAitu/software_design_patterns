using OriginalAdapter;
using OriginalAdapter.Adapter;

class Program
{
    static void Main(string[] args)
    {
        var target = new Adapter();
        var client = new Client(target);
        client.ShowResult();
    }
}