using OTS2023_V9.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_V9.Services.Fakes
{
    public class FakeLoggerService : ILoggerService
    {
        public string Message { get; set; }
        public void LogError(string message)
        {
            Message = message;
        }
    }
}
