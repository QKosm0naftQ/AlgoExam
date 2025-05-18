using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExam.Interface
{
    public class SortResult
    {
        public long OperationCount { get; set; }       
        public double ElapsedMilliseconds { get; set; }
        public string AlgorithmName { get; set; }
    }
}
