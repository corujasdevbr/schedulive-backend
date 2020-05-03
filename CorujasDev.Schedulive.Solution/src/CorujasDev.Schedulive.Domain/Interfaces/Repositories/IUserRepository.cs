﻿using CorujasDev.Schedulive.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace CorujasDev.Schedulive.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        #region Read
        IQueryable<UserDomain> GetAll();
        UserDomain GetById(Guid id);
        IQueryable<UserDomain> FindBy(Expression<Func<UserDomain, bool>> predicate);
        #endregion

        #region Write
        void Add(UserDomain car);
        void Update(UserDomain car);
        #endregion
    }
}
