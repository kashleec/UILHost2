﻿using System;
using System.Data;
using Repository.Pattern.Infrastructure;
using UILHost.Repository.Pattern.Repositories;

namespace UILHost.Repository.Pattern.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity>() where TEntity : class, IObjectState;
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified);
        bool Commit();
        void Rollback();
        dynamic GetCustomRepository<T>();
        dynamic GetCustomRepository(Type type);
    }
}