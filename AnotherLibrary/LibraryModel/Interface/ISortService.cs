using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel.Interface
{
    public interface ISortService
    {
        SortResult Sort(int[] array);
    }
}
