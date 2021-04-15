using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEO.classes
{
    class ToTxt
    {
        public static void WriteToFile(List<Individual> genList, int t, double tau,  double d)
        {
            StreamWriter file = new StreamWriter("Plik1.txt");
            file.WriteLine($"Parametry T: {t}   Tau: {tau} d: {d} \n");
            for (int i = 0; i < genList.Count; i++)
            {
                file.WriteLine("Pokolenie " + i + "\n");
                file.WriteLine("lp | VbReal | VbBin | f(VbReal)");
                file.WriteLine($"{i+1} | {genList[i].Xreal} | {genList[i].Xbit} | {genList[i].Fx}");
                file.WriteLine("\n");
            }
            file.Close();
        }
    }
}
