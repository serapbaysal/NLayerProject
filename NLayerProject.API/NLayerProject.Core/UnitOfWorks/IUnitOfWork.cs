﻿using NLayerProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.UnitOfWorks
{
    interface IUnitOfWork
    {
        IProductRepository Products
        {
            get;
      
        }
        ICategoryRepository categories
        {
            get;
        }
        Task CommitAsync();

        void Commit();

    }
}
