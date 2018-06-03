using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using AlbumsProject.BLL.Entities;
using AlbumsProject.Services.Contracts;
using AlbumsProject.ViewModels;
using AutoMapper;
using DataAccessLayer.Core.Interfaces.UoW;
using AlbumsProject.Services.Services;

namespace AipBlog.Services.Services
{
    public class PostService : BaseService, IPostService
    {
        public PostService(IUnitOfWork uow) : base(uow)
        {
        }
        public IEnumerable<PostVm> GetPosts(Expression<Func<Post, bool>> filterPredicate = null)
        {
            IEnumerable<Post> posts = _uow.Repository<Post>().GetRange(filterPredicate,
                false,
                x => x.OrderByDescending(p => p.Date), null, null,
                p => p.Comments.Select(a => a.Author), a => a.Author
            );
            IEnumerable<PostVm> postVm = Mapper.Map<IEnumerable<PostVm>>(posts);
            return postVm;
        }

        public PostVm GetPost(Expression<Func<Post, bool>> filterPredicate = null)
        {
            Post post = _uow.Repository<Post>().Get(filterPredicate, false, p => p.Comments.Select(a => a.Author), a => a.Author);
            PostVm postVm = Mapper.Map<PostVm>(post);
            return postVm;
        }

        public void AddOrUpdatePost(AddPostVm postVm)
        {
            var post = Mapper.Map<Post>(postVm);
            _uow.Repository<Post>().AddOrUpdate(x => x.Id == post.Id, post);
            _uow.Save();
        }
    }
}
