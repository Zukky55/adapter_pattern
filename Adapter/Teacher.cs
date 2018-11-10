using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// Client
    /// </summary>
    public class Teacher
    {
        public static void Main(string[] args)
        {
            //IChairperson chairperson = new NewTaro();
            //chairperson.OrganizeClass();
            NewHanako hanako = new NewHanako();
            hanako.CallingTaro();
        }
    }
}
