using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposetory.Interface
{
    internal interface IReposetory<T>where T : class
    {

        public void Add(T item);
        public void Update(int id, T item);
        public void Delete(T item);
        public T GetById(int id);
        public List<T> GetAll();
    }
}
