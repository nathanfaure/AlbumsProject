using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Core.Interfaces.UoW;

namespace AlbumsProject.Services.Services
{
    public class BaseService
    {
        protected readonly IUnitOfWork _uow;
        public BaseService(IUnitOfWork uow)
        {
            _uow = uow;
        }
    }
}
