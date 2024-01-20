﻿using Clinique2000_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique2000_Services.IServices
{
    public interface IAdresseService : IServiceBaseAsync<Adresse>
    {
        Task<bool> VerifierCodePostalValideAsync(string codePostal);
    }
}