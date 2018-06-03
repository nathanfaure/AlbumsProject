using AlbumsProject.BLL.Entities;
using AlbumsProject.Services.Contracts;
using AlbumsProject.ViewModels;
using AutoMapper;
using DataAccessLayer.Core.Interfaces.UoW;

namespace AlbumsProject.Services.Services
{
    public class CommentService: BaseService, ICommentService
    {
        public CommentService(IUnitOfWork uow) : base(uow)
        {
        }
        public void AddComment(AddCommentVm addCommentVm)
        {
            var comment = Mapper.Map<Comment>(addCommentVm);
            _uow.Repository<Comment>().Add(comment);
            _uow.Save();
        }

        
    }
}
