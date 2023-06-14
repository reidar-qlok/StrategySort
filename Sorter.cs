using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategySort
{
    public class Sorter
    {
        private ISortStrategy _sortStrategy;
        public void SetSortStrategy(ISortStrategy sortStrategy)
        {
            _sortStrategy = sortStrategy;
        }

        public void Sort(List<int> data)
        {
            _sortStrategy.Sort(data);
        }
    }
}
