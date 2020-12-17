using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        void Delete(int id);
        IEnumerable<PostCategory> GetAll();
        IEnumerable<PostCategory> GetAllByParentId(int parenId);
        PostCategory GetByID(int id);
        void Save();
    }
    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRepository _iPostCategoryRepository;
        IUnitOfWork _IUnitOfWork;
        public PostCategoryService(IPostCategoryRepository PostCategoryRepository,IUnitOfWork unitOfWork)
        {
            this._iPostCategoryRepository = PostCategoryRepository;
            this._IUnitOfWork = unitOfWork;
        }
        //public void Add(PostCategory postCategory)
        //{
        //    _iPostCategoryRepository.Add(postCategory);
        //}

        public void Delete(int id)
        {
            _iPostCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
           return _iPostCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int parenId)
        {
            return _iPostCategoryRepository.GetMulti(x => x.Status && x.ParentID == parenId);
        }

        public PostCategory GetByID(int id)
        {
            return _iPostCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _IUnitOfWork.Commit();
        }

        public void Update(PostCategory postCategory)
        {
            _iPostCategoryRepository.Update(postCategory);
        }

        PostCategory IPostCategoryService.Add(PostCategory postCategory)
        {
            return _iPostCategoryRepository.Add(postCategory);
        }
    }
}
