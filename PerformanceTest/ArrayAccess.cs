using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTest
{
	internal class ArrayAccess
	{
		private List<int> _ListData;
		private int[] _ArrayData;

		public ArrayAccess() {
			int elementCount = 10000;

			_ListData = new List<int>(elementCount);
			_ArrayData = new int[elementCount];

			for (int i = 0; i < elementCount; ++i) {
				_ListData[i] = i;
				_ArrayData[i] = i;
			}
		}


		public void iterateListA() {
			for (int i = 0; i < _ListData.Count; ++i) {
				
			}
		}
	}


}
