namespace Singleton;

public class Game
{
    private Game()
    {
    }

    private static Game? _instance;

    public static Game GetInstance()
    {
        return _instance ??= new Game();
    }

    // Multithreading version
    // private static readonly object LockObj = new();
    // public static Game GetInstance()
    // {
    //     if (_instance == null)
    //     {
    //         lock (LockObj)
    //         {
    //             if (_instance == null)
    //             {
    //                 _instance = new Game();
    //             }
    //         }
    //     }
    //
    //     return _instance;
    // }
}