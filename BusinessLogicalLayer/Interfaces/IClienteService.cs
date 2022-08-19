﻿using Entities;
using Shared.DataResponses;
using Shared.Responses;
using Shared.SingleResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer.Interfaces
{
    public interface IClienteService
    {
        Response Insert(Cliente cliente);
        Response Update(Cliente cliente);
        Response Delete(Cliente cliente);
        DataResponse<Cliente> GetAll();
        SingleResponse<Cliente> GetById(int id);
    }
}
