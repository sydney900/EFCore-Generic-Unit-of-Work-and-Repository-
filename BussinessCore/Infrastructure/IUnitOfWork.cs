﻿using System;
using System.Threading.Tasks;

namespace BussinessCore.Infrastructure
{
    public interface IUnitOfWork: IDisposable 
    {
        IRepository<T> Repository<T>() where T : BaseEntity;
        int SaveChanges();
        Task<int> SaveChangesAsync();
        void BeginTransaction();
        bool Commit();
        void Rollback();
        void Dispose(bool disposing);
    }
}
