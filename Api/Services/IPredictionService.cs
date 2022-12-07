using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Api.Models;

namespace Api.Services;

public interface IPredictionService
{
    Task<Championship> GetAsync();

}