namespace ClassLibrary1
{
    public class DescendingSort
    {
        private int[] _array;

        public DescendingSort(int[] array)
        {
            _array = array;
        }

        public void Sort()
        {
            for (int i = 0; i < _array.Length - 1; i++)
            {
                for (int j = 0; j < _array.Length - i - 1; j++)
                {
                    if (_array[j] < _array[j + 1]) 
                    {
                        
                        int temp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = temp;
                    }
                }
            }
        }

        public int[] GetSortedArray()
        {
            return _array;
        }
    }
}