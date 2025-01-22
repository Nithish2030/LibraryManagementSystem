
using LibraryMgmt;

public class Program
{
    public static void Main(string[] args)
    {
        LibraryManager libraryManager = LibraryManager.Instance;

        libraryManager.HandleUserInput();
    }
}
