using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD_OPERATION_IN_MVC.Models
{
    public class MVCCRUD:DbContext
    {
        public DbSet<CrudOperations> crudopr { get; set; }
    }
}