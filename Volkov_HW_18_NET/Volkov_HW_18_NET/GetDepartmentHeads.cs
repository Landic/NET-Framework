using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_18_NET
{
    internal class GetDepartmentHeads
    {
        public List<Teacher> Get(List<IDepartment> dep)
        {
            List<Teacher> heads = new List<Teacher>();
            foreach (IDepartment department in dep)
            {
                if(department.Head != null)
                {
                    heads.Add(department.Head);
                }
            }
            return heads;
        }

    }
}
