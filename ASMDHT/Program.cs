using System;
using System.Windows.Forms;

namespace ASMDHT {
    internal sealed class Program {
        private static bool continueRunning = true;
        [STAThread]
        private static void Main(string[] args) {
            if (args != null && args.Length > 0)
                processArgs(args);
            
            if (continueRunning) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
        
        static void processArgs(string[] args) {
            if (args.Length > 1 && (args[0].Equals("-p") || args[0].Equals("--process"))) {
                continueRunning = false;
                for (int i = 1; i < args.Length; i++) {
                    string command = args[i];
                    if (command.Equals("-f") || command.Equals("--file")) {
                        
                    }
                }
            }
        }
    }
}
