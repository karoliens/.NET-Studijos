using System.Text;

namespace P014_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            //Teksto isgavimas is StringBuilder
            Console.WriteLine(sb.ToString());

            //Teksto pridejimas per StringBuilder
            sb.Append("Labas");
            sb.AppendLine("pasauli");
            sb.AppendLine("labas C#");
            //Console.WriteLine(sb.ToString());

            Console.WriteLine("-----------------------------");
            //Teksto iterpimas
            sb.Insert(14, " AAAAAA ");
            Console.WriteLine(sb.ToString());
        }
    }
}