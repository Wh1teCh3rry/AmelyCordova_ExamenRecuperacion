using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmelyCordova_ExamenRecuperacion.ACModels
{
    public class Message
    {
        public List<object> pomeranian { get; set; }
    }

    public class Root
    {
        public string status { get; set; }
        public Message message { get; set; }
    }
}
