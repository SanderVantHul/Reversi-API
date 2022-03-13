﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReversiWebApi.Models;

namespace ReversiWebApi.Repositories
{
    public interface ISpelRepository
    {
        Task AddSpel(Spel spel);

        Task<List<Spel>> GetSpellen();

        Task<Spel> GetSpel(string spelToken);

        Task<List<Spel>> GetSpellenMetWachtendeSpeler();

        Task<Spel> GetSpelMetSpelerToken(string spelerToken);

        Task Complete();
    }
}
