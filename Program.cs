using System;
using System.Diagnostics;
using System.IO;

namespace CinePulse.Mvc
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            if (appDir.EndsWith(@"\bin\", StringComparison.OrdinalIgnoreCase) || 
                appDir.EndsWith(@"\bin", StringComparison.OrdinalIgnoreCase))
            {
                appDir = Directory.GetParent(appDir.TrimEnd('\\')).FullName;
            }

            string iisExpressPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                @"IIS Express\iisexpress.exe"
            );

            if (!File.Exists(iisExpressPath))
            {
                iisExpressPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                    @"IIS Express\iisexpress.exe"
                );
            }

            if (!File.Exists(iisExpressPath))
            {
                Console.WriteLine("IIS Express not found at standard installation paths.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("=====================================================");
            Console.WriteLine("  CinePulse OTT Platform - ASP.NET MVC (.NET 4.8)");
            Console.WriteLine("=====================================================");
            Console.WriteLine($"Starting IIS Express for: {appDir}");
            Console.WriteLine("Local URL: http://localhost:5215/");
            Console.WriteLine("=====================================================");

            var startInfo = new ProcessStartInfo
            {
                FileName = iisExpressPath,
                Arguments = $"/path:\"{appDir}\" /port:5215",
                UseShellExecute = false
            };

            try
            {
                using (var process = Process.Start(startInfo))
                {
                    // Open browser
                    Process.Start("http://localhost:5215/");
                    Console.WriteLine("Web browser launched. Press Ctrl+C in this console to stop server.");
                    process?.WaitForExit();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error launching IIS Express: {ex.Message}");
            }
        }
    }
}
