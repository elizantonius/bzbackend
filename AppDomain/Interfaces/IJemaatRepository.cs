﻿using AppDomain.Models;

namespace AppDomain.Interfaces
{
    public interface IJemaatRepository
    {
        ICollection<Jemaat> GetJemaat();
        Task<Jemaat> GetById(int id);
        Task<Jemaat> Post(Jemaat jemaat);
        Task<Jemaat> Put(Jemaat jemaat);
        Task<bool> Delete(int id);
    }
}
