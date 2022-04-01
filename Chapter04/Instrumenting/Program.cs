using static System.Console;
using System.Diagnostics;

Trace.Listeners.Add(new TextWriterTraceListener(
    File.CreateText(Path.Combine(Environment.GetFolderPath(
        Environment.SpecialFolder.DesktopDirectory), "log.txt"))));
// text writer is buffered, so this option calls // Flush() on all listeners after writing Trace.AutoFlush = true;

Trace.AutoFlush = true;

Debug.WriteLine("Debug says, I am watching!");
Trace.WriteLine("Trace says, I am watching!");