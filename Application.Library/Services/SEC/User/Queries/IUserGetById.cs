﻿using Application.Library.Bases;
using Application.Library.DatabaseContext;
using Application.Library.Models.Views.SEC;

namespace Application.Library.Services
{
    public interface IUserGetById
    {
        ResultView<UserView> Execute(long Id);

    }
    public class UserGetById : IUserGetById
    {
        private readonly IDatabaseContext _context;
        public UserGetById(IDatabaseContext context)
        {
            _context = context;
        }
        public ResultView<UserView> Execute(long Id)
        {
            return new ResultView<UserView>()
            {
                IsSuccess = true,
                Message = new List<string>()
                {
                    "با موفقیت ذخیره شده",
                },
                Data = new UserView()
                {

                }
            };
        }
    }
}
