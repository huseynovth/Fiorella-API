using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Aplication.DTOs.ResponceDTOs;

public class ExceptionResponceDto
{
    public int StatusCode { get; set; }
    public string CustomMessage { get; set; }

    public ExceptionResponceDto(int statusCode, string customMesage)
    {
        StatusCode = statusCode;
        CustomMessage = customMesage;


    }
}

