using Microsoft.Extensions.Configuration;
using System;
using static System.Console;
using System.Diagnostics;
using System.IO;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write to a text file in the project folder
            Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText("log.txt")));
            Trace.AutoFlush = true; // TextWriter is buffered so this calls Flush() after writing
            Debug.WriteLine("Debug says I am watching!");
            Trace.WriteLine("Trace says, I am watching!");

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",
                optional: true,
                reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            var ts = new TraceSwitch(displayName: "PacketSwitch",
                description: "This switch is set via a JSON config.");
            configuration.GetSection("PacketSwitch").Bind(ts);
            Trace.WriteLineIf(ts.TraceError, "Trace error");
            Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
            Trace.WriteLineIf(ts.TraceInfo, "Trace information");
            Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");
        }
    }
}
