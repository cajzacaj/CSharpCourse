using System;
using System.IO;

namespace Watcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var watcher = new FileSystemWatcher();
            watcher.Path = @"C:\TMP";
            watcher.EnableRaisingEvents = true;

            watcher.Created += Watcher_Created;
            watcher.Renamed += Watcher_Renamed;
            watcher.Deleted += Watcher_Deleted;
            watcher.Changed += Watcher_Changed;

            Console.ReadKey();
        }

        private static void Watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.Name} was deleted");
        }

        private static void Watcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"{e.Name} was renamed from {e.OldName}");
        }

        private static void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.Name} was created");
        }

        private static void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.Name} was changed: {e.ChangeType}");
        }
    }
}
