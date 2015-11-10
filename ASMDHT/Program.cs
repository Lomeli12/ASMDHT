using System;
using System.Drawing;
using System.Windows.Forms;

namespace ASMDHT {
    internal sealed class Program {

        [STAThread]
        private static void Main(string[] args) {
            if (!processArgs(args)) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
        
        static bool processArgs(string[] args) {
            if (args != null && args.Length > 0) {
                if (args[0].Equals("-c") || args[0].Equals("--create")) {
                    var smdhFile = new SMDH();
                    string fileName = "";
                    if (args.Length >= 2) {
                        for (int i = 1; i < args.Length; i++) {
                            string arg = args[i];
                            if ((arg.Equals("-f") || arg.Equals("--file")) && (i + 1) < args.Length) {
                                i++;
                                fileName = args[i];
                                continue;
                            } else if ((i + 1) >= args.Length) {
                                Console.WriteLine("Missing argument! " + arg + " requires an additional argument");
                                break;
                            }
                            if ((arg.Equals("-t") || arg.Equals("--title")) && (i + 1) < args.Length) {
                                i++;
                                for (int j = 0; j < 16; j++) smdhFile.SetShortDescription(j, args[i]);
                                continue;
                            } else if ((i + 1) >= args.Length) {
                                Console.WriteLine("Missing argument! " + arg + " requires an additional argument");
                                return false;
                            }
                            if ((arg.Equals("-a") || arg.Equals("--author")) && (i + 1) < args.Length) {
                                i++;
                                for (int j = 0; j < 16; j++) smdhFile.SetPublisher(j, args[i]);
                                continue;
                            } else if ((i + 1) >= args.Length) {
                                Console.WriteLine("Missing argument! " + arg + " requires an additional argument");
                                break;
                            }
                            if ((arg.Equals("-d") || arg.Equals("--description")) && (i + 1) < args.Length) {
                                i++;
                                for (int j = 0; j < 16; j++) smdhFile.SetLongDescription(j, args[i]);
                                continue;
                            } else if ((i + 1) >= args.Length) {
                                Console.WriteLine("Missing argument! " + arg + " requires an additional argument");
                                break;
                            }
                            if ((arg.Equals("-b") || arg.Equals("--bigicon")) && (i + 1) < args.Length) {
                                i++;
                                try {
                                    if (!String.IsNullOrWhiteSpace(args[i])) smdhFile.BigIcon = new Bitmap(args[i]);
                                } catch (Exception e) {
                                    Console.WriteLine(e.Message);
                                    break;
                                }
                                continue;
                            } else if ((i + 1) >= args.Length) {
                                Console.WriteLine("Missing argument! " + arg + " requires an additional argument");
                                break;
                            }
                            if ((arg.Equals("-s") || arg.Equals("--smallicon")) && (i + 1) < args.Length) {
                                i++;
                                try {
                                    if (!String.IsNullOrWhiteSpace(args[i])) smdhFile.SmallIcon = new Bitmap(args[i]);
                                } catch (Exception e) {
                                    Console.WriteLine(e.Message);
                                    break;
                                }
                                continue;
                            } else if ((i + 1) >= args.Length) {
                                Console.WriteLine("Missing argument! " + arg + " requires an additional argument");
                                break;
                            }
                        }
                        if (!String.IsNullOrWhiteSpace(fileName)) {
                            try {
                                smdhFile.Save(fileName);
                            } catch (Exception e) {
                                Console.WriteLine("Failed to create " + fileName);
                                Console.WriteLine(e.Message);
                            }
                        } else {
                            Console.WriteLine("Requires at least -f argument for file name");
                            Console.WriteLine("ASMDHT -c -f filename.smdh <-t title> <-a author> <-d description> <-b large_icon_location> <-s small_icon_location>");
                      
                        }
                    }
                    return true;
                } else if (args[0].Equals("?") || args[0].Equals("--help") || args[0].Equals("-h")) {
                    Console.WriteLine("ASMDHT -c -f filename.smdh <-t title> <-a author> <-d description> <-b large_icon_location> <-s small_icon_location>");
                    return true;
                }
            }
            return false;
        }
    }
}
