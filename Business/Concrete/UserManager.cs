using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilites.Results;
using Core.Utilites.Security.Hashing;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IDataResult<User> GetByEmail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UsersListed);
        }

        public IDataResult<User> GetUser(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(p => p.Id == userId), Messages.UserGet);
        }
       

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdate);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDelete);
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdd);
        }

        public IResult ChangeUserInfo(ChangeUserInfoDto userInfo)
        {
            var user = GetByEmail(userInfo.Email).Data;
            user.FirstName = userInfo.FirstName;
            user.LastName = userInfo.LastName;

            _userDal.Update(user);


            return new SuccessResult();
        }

        public IResult ChangeUserPassword(ChangeUserPasswordDto userInfo)
        {
            byte[] passwordHash, passwordSalt;
            var userToCheck = GetByEmail(userInfo.Email);
            if (userToCheck.Data == null)
            {
                return new ErrorResult(Messages.EmailNotFound);
            }
            if (!HashingHelper.VerifyPasswordHash(userInfo.OldPassword, userToCheck.Data.PasswordHash, userToCheck.Data.PasswordSalt))
            {
                return new ErrorResult(Messages.InvalidPassword);
            }
            HashingHelper.CreatePasswordHash(userInfo.NewPassword, out passwordHash, out passwordSalt);
            userToCheck.Data.PasswordHash = passwordHash;
            userToCheck.Data.PasswordSalt = passwordSalt;
            Update(userToCheck.Data);
            return new SuccessResult(Messages.PasswordChanged);
        }
    }
}
