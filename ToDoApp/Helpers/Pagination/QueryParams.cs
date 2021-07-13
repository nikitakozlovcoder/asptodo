using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Helpers.Pagination
{
    public class QueryParams
    {
       
        public int? Page { get; set; }
        
        public int? Limit { get; set; }

        

    }
}
