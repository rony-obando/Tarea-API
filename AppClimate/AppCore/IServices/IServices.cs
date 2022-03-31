using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IServices<T>
    {
        void Create(T t);
        void Delete(T t);
        T FindAll(int id);
    }
}
