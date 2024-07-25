namespace ConsoleUmrechnungDatentypten {

    internal class Program {

        static void Main(string[] args) {

            bool appRunning = true;
            while (appRunning) {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.WriteLine("ConsoleUmrechnungDatentypten \n");

                Console.WriteLine("{1,-40} = {0,20:N3} GiB", GetSizeInGiB(53546856464864),  "GetSizeInGiB(53546856464864)");
                Console.WriteLine("{1,-40} = {0,20:N3} GiB", GetSizeInGiB(5354685644),      "GetSizeInGiB(5354685644)");
                Console.WriteLine("{1,-40} = {0,20:N3} GiB", GetSizeInGiB(5464864),         "GetSizeInGiB(5464864)");
                Console.WriteLine("{1,-40} = {0,20:N3} GiB", GetSizeInGiB(1024*1024*1024),  "GetSizeInGiB(1024*1024*1024)");
                Console.WriteLine();
                Console.WriteLine("{1,-40} = {0,20:N3} KB",  GetSize("KB", 1024 * 1024),    "GetSize(\"KB\", 1024 * 1024)");
                Console.WriteLine("{1,-40} = {0,20:N3} KiB", GetSize("KiB", 1024 * 1024),   "GetSize(\"KiB\", 1024 * 1024)");

                int[] sample1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                int[] sample2 = { 100, 200, 300, 400, 500, 600, 70, 8, 9, 10 };


                //Console.WriteLine("BerechneSumme: " + BerechneSumme());

                Console.Write("\n\nProgramm beenden (e)? ");
                try {
                    string exitApp = Console.ReadLine();
                    if (exitApp.ToUpper() == "E") {
                        appRunning = false;
                    }
                } catch {
                    // no error message, just keep going and repeat the app
                }
            }
        }

        private static double GetSizeInGiB(double sizeInKB) {
            
            return sizeInKB * 1000.0 / 1024.0 / 1024.0 / 1024.0;
        }

        // allgemeine Methode, die Anzahl Bytes in Zieleinheit umrechnet:
        // z.B. KiB, KB, MiB, MB, usw.
        private static double GetSize(string zielEinheit, double sizeInB) {

            double size = 0;
            switch (zielEinheit) {
                case "B":
                    size = sizeInB;
                    break;
                case "KB":
                    size = sizeInB / 1000.0;
                    break;
                case "MB":
                    size = sizeInB / 1000.0 / 1000.0;
                    break;
                case "GB":
                    size = sizeInB / 1000.0 / 1000.0 / 1000.0;
                    break;

                case "KiB":
                    size = sizeInB / 1024.0;
                    break;
                case "MiB":
                    size = sizeInB / 1024.0 / 1024.0;
                    break;
                case "GiB":
                    size = sizeInB / 1024.0 / 1024.0 / 1024.0;
                    break;
                default:
                    break;
            }

            return size;
        }

        private static int BerechneSumme(int[] ar) {

            int sum = 0;
            for (int i = 0; i < ar.Length; i++) {
                sum += ar[i];
            }

            return sum;
        }

        private static void ShowErrorInputMessage() {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nUngültige Eingabe: Nur positive Ganzzahlen > 0 sind erlaubt\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Wieviele Fibonacci-Zahlen sollen berechnet werden? ");
        }

    }
}
