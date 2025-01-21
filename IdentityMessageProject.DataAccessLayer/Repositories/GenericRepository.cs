using IdentityMessageProject.DataAccessLayer.Abstract;
using IdentityMessageProject.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityMessageProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly MessageContext _messageContext;

        //yapıcı metodu olusturuldu
        public GenericRepository(MessageContext messageContext)
        {
            _messageContext = messageContext;
        }

        //sınıfın ıcıne interface'in metodlarını implemente ettim
        public void Delete(int id)
        {
           var value =  _messageContext.Set<T>().Find(id);
            _messageContext.Set<T>().Remove(value);
            _messageContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _messageContext.Set<T>().ToList();//gerıye deger dondurecek
        }

        public T GetById(int id)
        {
            return _messageContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _messageContext.Set<T>().Add(entity);
            _messageContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _messageContext.Set<T>().Update(entity);
            _messageContext.SaveChanges();
        }
    }
}
