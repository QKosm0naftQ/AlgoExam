using AlgoExam.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExam.Service
{
    public class OutPutLine
    {
        private List<SortResult> _sortResults = new List<SortResult>();
        public void AddItem(SortResult result)
        {
            _sortResults.Add(result);
        }
        public void PrintTable()
        {
            Console.WriteLine("+----------------------+---------------------+----------------------+");
            Console.WriteLine("|   Algorithm Name     |   Operation Count   |     Time (ms)        |");
            Console.WriteLine("+----------------------+---------------------+----------------------+");

            foreach (var result in _sortResults)
            {
                Console.WriteLine($"| {result.AlgorithmName,-20} | {result.OperationCount,19} | {result.ElapsedMilliseconds,20:F3} |");
            }

            Console.WriteLine("+----------------------+---------------------+----------------------+");
        }
    }
}
