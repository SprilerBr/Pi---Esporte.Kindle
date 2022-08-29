﻿using Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface ITipoFuncionarioDALService
    {
        Task<DataResponse<TipoFuncionario>> GetAllTipos(); 
    }
}
