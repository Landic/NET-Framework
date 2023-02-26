using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_18_NET
{
    internal interface IDepartment
    {
        void Lesson();
        Teacher Head { get; }
        List<Teacher> Teachers { get; }
    }
}
