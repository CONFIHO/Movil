using Confiho.MVVM.Model;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Google.Crypto.Tink.Shaded.Protobuf;

namespace Confiho.MVVM.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class StadisticsVM
    {
        public ObservableCollection<TransactionsSummary> Summary { get; set; }
        Presupuesto Presupuesto { get; set; }
        public StadisticsVM(Presupuesto presupuesto) {
            this.Presupuesto = presupuesto;
        }

        public void GetTransactionsSummary()
        {
            var data = Presupuesto.budget_history.expense;
            foreach (var transaction in data)
            {
                transaction.date = DateTime.ParseExact(transaction.expense_date, "yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture);
            }
            var result = new List<TransactionsSummary>();
            var groupedTransactions = data.GroupBy(x => x.date.Date);

            foreach (var group in groupedTransactions)
            {
                var transactionsSummary = new TransactionsSummary
                {
                    TransactionsDate = group.Key,
                    TransactionsTotal = (decimal)group.Sum(x => x.value),
                    ShownDate = group.Key.ToString("MM/dd"),
                };
                    result.Add(transactionsSummary);
                }

            result = result.OrderBy(x => x.TransactionsDate).ToList();
            Summary = new ObservableCollection<TransactionsSummary>(result);
        }
    }
}
