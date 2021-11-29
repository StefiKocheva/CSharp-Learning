using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SulsApp.ViewModels.Home
{
    public class LoggedInViewModel
    {
        public IEnumerable<IndexProblemViewModel> Problems { get; set; }
    }
}
