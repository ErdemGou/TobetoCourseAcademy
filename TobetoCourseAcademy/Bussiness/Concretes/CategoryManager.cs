using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concretes
{
    public class CategoryManager
    {
        
        public void Add(Category category)
        {
            //iş kurallarını işlet
            AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();
            categoryDal.Add(category);
        }
    }
}
