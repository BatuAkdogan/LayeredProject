﻿using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project4.DataAccess
{
  public  interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll();
        List<T> GetById(int id);
        void Add(T entity);


        void Update(T entity);
        void Delete(T entity);
    }
}
