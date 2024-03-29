﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Repositories
{
    public interface IBaseRepository2<T, TId>
    {
        Task<T> GetByIdAsync(TId id);
        Task<bool> IsExistAsync(TId id);
    }
}
