using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Xml.XPath;


int GetPredictSum(string sequencesStr)
{
    int result = 0;

    string[] sequences = sequencesStr.Split("\r\n");

    foreach (string sequence in sequences)
    {
        int[] values = sequence.Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < values.Length - 1; i++)
        {
            
        }
    }

    return result;
}