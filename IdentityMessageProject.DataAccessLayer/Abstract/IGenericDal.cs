using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityMessageProject.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        //butun etity leri kapsayacak yapı--- crud butun entity ler için ortak
        void Insert(T entity);//add
        void Update(T entity);
        void Delete(int id);
        List<T> GetAll();
        T GetById(int id);


    }
}
