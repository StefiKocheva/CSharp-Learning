using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SulsApp.Services
{
    public interface IProblemsService
    {
        void CreateProblem(string name, int points);
    }
}
