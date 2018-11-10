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
    public class NewHanako : Hanako
    {
        public Taro taro = new Taro();

        public override void CallingTaro()
        {
            taro.EnjoyWithAllClassmate();
        }
    }
}
