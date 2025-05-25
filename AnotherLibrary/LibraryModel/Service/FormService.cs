using LibraryModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1Test.Service
{
    public class FormService
    {
        private Random rand = new Random();
        private List<SortResult> _sortResults = new List<SortResult>();
        private List<ISortService> _sortTypes = new List<ISortService>();
        private int[] _array;
        public async Task SortAsync()
        {
            _sortResults = new List<SortResult>();

            var tasks = _sortTypes.Select(sortType => Task.Run(() =>
            {
                var inputCopy = (int[])_array.Clone(); 
                var sorted = sortType.Sort(inputCopy);
                return sorted;
            })).ToList();

            var results = await Task.WhenAll(tasks);

            _sortResults.AddRange(results);
        }
        public List<SortResult> GetListSortResult()
        {
            return _sortResults;
        }
        public void AddTypeSort(ISortService sortType)
        {
            _sortTypes.Add(sortType);
        }
        public void GenerateRandomArray(int length, int max)
        {
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(1, max + 1);
            }
            _array = array;
        }
    }
}
