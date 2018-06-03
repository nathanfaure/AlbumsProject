using AlbumsProject.ViewModels;

namespace AlbumsProject.Services.Contracts
{
    public interface ICommentService
    {
        void AddComment(AddCommentVm addCommentVm);
    }
}
