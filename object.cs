using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    public class LargeDataCollection : IDisposable
    {
        private bool disposed = false;
        private object[] data;

        public LargeDataCollection(object[] initialData)
        {
            data = initialData;
        }
        public void Add(object element)
        {
        
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = element;
        }
        public void Remove(object element)
        {
           
            int index = Array.IndexOf(data, element);
            if (index >= 0)
            {
                for (int i = index; i < data.Length - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                Array.Resize(ref data, data.Length - 1);
            }
        }
        public object GetElement(int index)
        {
      
            if (index >= 0 && index < data.Length)
            {
                return data[index];
            }
            throw new IndexOutOfRangeException("Index is out of range.");
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    
                }
                data = null;
                disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~LargeDataCollection()
        {
            Dispose(false);
        }

    }
}
