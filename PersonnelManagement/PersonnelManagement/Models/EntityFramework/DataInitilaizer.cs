using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PersonnelManagement.Models.EntityFramework
{
    public class DataInitilaizer: DropCreateDatabaseAlways<PersonnelContext>
    {

    }
}