using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Helpers.Pagination
{
    public class Paginator<T> where T : class
    {
        private QueryParams _params;
        public Paginator(QueryParams queryParams) => _params = queryParams;

        public IQueryable<T> GetPagedBuilder(DbSet<T> dbset)
        {
            if(_params.Limit != null && _params.Page != null)
            {
                return dbset.Skip(((int)_params.Page - 1) * (int)_params.Limit).Take((int)_params.Limit);
            }
            return dbset;


        }
    }
}
