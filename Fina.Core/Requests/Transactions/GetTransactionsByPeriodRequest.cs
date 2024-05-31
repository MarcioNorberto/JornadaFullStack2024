using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fina.Core.Requests.Transactions
{
    public class GetTransactionsByPeriodRequest : PagedRequest
    {
        // Se~não passar nenhuma data, vai pegar registros do mês atual
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
