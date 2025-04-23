namespace CustomList
{
    internal class CustomList<T>
    {
        public T[] _list = [];
        /* add dobalyaet element item v list esli eqo net v massive  */
        public void Add(T item)
        {

            if (_list.Contains(item)) return;

            Array.Resize(ref _list, _list.Length + 1);
            _list[^1] = item;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= _list.Length) return false;

            Array.Copy(_list, index + 1, _list, index, _list.Length - index - 1);
            Array.Resize(ref _list, _list.Length - 1);
            return true;
        }

        public bool Remove(T item)
        {
            return RemoveAt(IndexOf(item));
        }
        /*  IndexOf index elementa item vnutri massiva _list */
        public int IndexOf(T item)
        {
            return Array.IndexOf(_list, item);
        }


        /*Size,Capacity */
        /**
         * 0    1     2     3      4      5       6
         * A    B     C     D      F      G       
         * 
         * 
         * */

    }
}
