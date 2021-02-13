using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal;

public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult< List<Category>> GetAll()
        {
            //iş kodları
            
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoriesListed);
        }

        public IDataResult<List<Category>> GetById(int CategoryId)
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(p => p.CategoryId == CategoryId));
        }
    }
}
