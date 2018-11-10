using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// Adapter
    /// </summary>
    public class NewTaro : Taro, IChairperson
    {
        public void OrganizeClass()
        {
            EnjoyWithAllClassmate();
        }
    }
}
