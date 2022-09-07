﻿using DataAccessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository _efCategoryRepository;

        public CategoryManager(EfCategoryRepository efCategoryRepository)
        {
            _efCategoryRepository = efCategoryRepository;
        }

        public void CategoryAdd(Category category)
        {

            _efCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {

           _efCategoryRepository.Delete(category);  
        }

        public void CategoryUpdate(Category category)
        {
            _efCategoryRepository.Update(category);
        }

        public Category GetById(int Id)
        {
            return _efCategoryRepository.GetById(Id);
        }

        public List<Category> GetList()
        {
            return _efCategoryRepository.GetListAll();
        }
    }
}