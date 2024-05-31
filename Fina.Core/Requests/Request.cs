using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests
{
    public abstract class Request // Não pode ser instanciada, só herdada
    {
        public string UserId { get; set; } = string.Empty;

    }
}
