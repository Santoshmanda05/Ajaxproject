using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ajaxproject.Models
{
    public class DBOperations
    {
        static DemoEntities D = new DemoEntities();
        public static List<DEPTDATA> GetDept()
        {
            List<DEPTDATA> dlist = (from c in D.DEPTDATAs
                                    select c).ToList();
            return dlist;
        }
        public static List<EMPDATA> GetEmps(int deptno)
        {
            List<EMPDATA> elist = (from c in D.EMPDATAs
                                   where c.DEPTNO == deptno
                                   select c).ToList();
            return elist;
        }
    }
}