using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.Common;

public class ApiError
{
    public string Title { get; set; }
    public string Message { get; set; }

    public ApiError(string title, string message)
    {
        Title = title;
        Message = message;
    }
}