using LibraryModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel.Service
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
            Console.WriteLine("+--------------------------+-----------------------+----------------------+");
            Console.WriteLine("|   Algorithm Name         |   Operation Count     |     Time (ms)        |");
            Console.WriteLine("+--------------------------+-----------------------+----------------------+");

            foreach (var result in _sortResults)
            {
                Console.WriteLine($"| {result.AlgorithmName,-24} | {result.OperationCount,21} | {result.ElapsedMilliseconds,17:F3} ms |");
            }

            Console.WriteLine("+--------------------------+-----------------------+----------------------+");
        }
    }
}
