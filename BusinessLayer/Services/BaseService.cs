using BusinessLayer.Interfaces;

namespace BusinessLayer.Services
{
    // shared base service for the purpose of not repeating the code in every service
    public class BaseService : IBaseService
    {
        protected readonly IUnitOfWork _unitOfWork;
        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
