// ============================================
// Program #147 — CustomEventArgs
// Category  : 15_Delegates_Events
// Difficulty: Intermediate
// Description: Create event with custom EventArgs data
// ============================================

using System;

namespace CSharp30Programs.DelegatesEvents
{
    class Program_147_CustomEventArgs
    {
        static void Main(string[] args)
        {
            DownloadManager manager = new DownloadManager();
            manager.ProgressChanged += (sender, e) =>
                Console.WriteLine($"Progress: {e.Percentage}%");

            manager.StartDownload();
        }


        class ProgressEventArgs : EventArgs
        {
            public int Percentage { get; }

            public ProgressEventArgs(int percentage)
            {
                Percentage = percentage;
            }
        }

        class DownloadManager
        {
            public event EventHandler<ProgressEventArgs>? ProgressChanged;

            public void StartDownload()
            {
                for (int i = 25; i <= 100; i += 25)
                {
                    ProgressChanged?.Invoke(this, new ProgressEventArgs(i));
                }
            }
        }
    }
}
