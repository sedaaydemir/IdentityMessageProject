using IdentityMessageProject.DataAccessLayer.Abstract;
using IdentityMessageProject.DataAccessLayer.Context;
using IdentityMessageProject.DataAccessLayer.Repositories;
using IdentityMessageProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityMessageProject.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(MessageContext messageContext) : base(messageContext)
        {
        }
    }
}
