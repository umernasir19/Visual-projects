using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_OPERATION_IN_MVC.Models.ViewModel.Home
{
    public class CrudOperationviewmodel
    {
        public List<CrudOperations> getall()
        {
            MVCCRUD db = new MVCCRUD();
            return db.crudopr.ToList();
        }
    }
}