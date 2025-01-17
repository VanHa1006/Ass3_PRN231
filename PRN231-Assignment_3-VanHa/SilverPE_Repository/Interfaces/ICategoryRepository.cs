﻿using SilverPE_BOs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverPE_Repository.Interfaces
{
    public interface ICategoryRepository
    {
        public Task<Category> GetCategory(string id);
        public Task<List<Category>> GetCategories();
    }
}
