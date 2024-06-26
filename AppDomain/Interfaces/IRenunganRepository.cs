﻿using AppDomain.Models;

namespace AppDomain.Interfaces
{
    public interface IRenunganRepository
    {
        ICollection<Renungan> GetRenungans();
        Task<Renungan> GetById(int id);
        Task<Renungan> Post(Renungan renungan);
        Task<Renungan> Put(Renungan renungan);
        Task<bool> Delete(int Renunganid);
    }
}
