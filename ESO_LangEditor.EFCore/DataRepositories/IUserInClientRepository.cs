﻿using ESO_LangEditor.Core.Entities;
using ESO_LangEditor.EFCore.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESO_LangEditor.EFCore.DataRepositories
{
    public interface IUserInClientRepository : IBaseRepository<UserInClient>, IBaseRepository2<UserInClient, Guid>
    {
    }
}
