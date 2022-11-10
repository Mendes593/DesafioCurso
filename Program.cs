using System.Globalization;
using CursoProfNelio.Entidades;

namespace CursoProfNelio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  duplicar arquivo.
             * string caminhoTxt1 = @"C:\Users\wolli\OneDrive\Documentos\Curso\Texto1.txt";
            string caminhoTxt2 = @"C:\Users\wolli\OneDrive\Documentos\Curso\Texto2.txt";

             try
             {
                 FileInfo fileInfo = new FileInfo(caminhoTxt1);
                 fileInfo.CopyTo(caminhoTxt2);
                 string[] linha = File.ReadAllLines(caminhoTxt1);
                 foreach (string line in linha)
                 {
                     Console.WriteLine(line);
                 }
             }

             catch(IOException e)
             {
                 Console.WriteLine("An error occorred");
                 Console.WriteLine(e.Message);
             }--------------------------------------------------------------------------
            */

            /* ------------LEITURA DE ARQUIVO--------------------------------
            string path = @"C:\Users\wolli\OneDrive\Documentos\Curso\Texto1.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occorred");
                Console.WriteLine(e.Message);
            }

            finally
            {
                if (sr != null) sr.Close();
            }*/


            /*----------------------LEITURA DE ARQUIVO COM BLOCO USING--------------------
            string path = @"C:\Users\wolli\OneDrive\Documentos\Curso\Texto1.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occorred.");
                Console.WriteLine(e.Message);
            }
            */

            /*string path = @"C:\Users\wolli\OneDrive\Documentos\Curso\Nova pasta";
            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("PASTAS: ");
                foreach(string a in folders)
                {
                    Console.WriteLine(a);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("ARQUIVOS: ");
                foreach (string texto in files)
                {
                    Console.WriteLine(texto);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occorred.");
                Console.WriteLine(e.Message);
            }*/

            /*RESOLUÇÃO DO EXERCICIO-----------------------------
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\Curso";
                string targetFilePath = targetFolderPath + @"\PRODUTOS.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {          
                        string[] fields = line.Split(',');

                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product prod = new Product(name, price, quantity);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }*/


        }
    }
}