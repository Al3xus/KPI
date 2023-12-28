using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace lab4.Handler
{
    public interface IGameHandler
    {
        void ExecuteCommand();
        string ShowInfo();
    }
}
