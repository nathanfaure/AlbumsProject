using AlbumsProject.BLL.Entities;
using AlbumsProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AlbumsProject.Services.Contracts
{
    public interface IPostService
    {
        IEnumerable<PostVm> GetPosts(Expression<Func<Post, bool>> filterPredicate = null);
        PostVm GetPost(Expression<Func<Post, bool>> filterPredicate = null);
        void AddOrUpdatePost(AddPostVm postVm);
    }
}
