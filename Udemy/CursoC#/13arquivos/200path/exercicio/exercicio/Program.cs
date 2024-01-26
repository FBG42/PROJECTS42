namespace exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = @"c:/temp/source.txt";
            string output = @"c:/temp/output.txt";

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(sourceFile);
                string[] lines = File.ReadAllLines(sourceFile);

                foreach(string line in lines)
                {
                    string product = "";
                    double value = 0d;
                    int quantity = 0;
                    double total = 0d;

                    string[] informacoesProduto = line.Split(',');
                    
                    product = informacoesProduto[0];
                    value = double.Parse(informacoesProduto[1]);
                    quantity = int.Parse(informacoesProduto[2]);

                    Console.WriteLine(informacoesProduto[0]);
                    Console.WriteLine(informacoesProduto[1]);
                    Console.WriteLine(informacoesProduto[2]);

                    total = quantity * value;
                    Console.WriteLine(total.ToString("F", System.Globalization.CultureInfo.InvariantCulture));

                    string lineText = $"{product}, {total}";

                    using (StreamWriter sw = File.AppendText(output))
                    {
                        sw.WriteLine(lineText);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}