using AppCore.IServices;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public abstract class BaseWeather<T> : IServices<T>
    {
        private IModel<T> model;
        public void Create(T t)
        {
            model.Create(t);
        }

        public void Delete(T t)
        {
           model.Delete(t);
        }

        public T FindAll(int id)
        {
            return model.FindAll(id);
        }
    }
}
