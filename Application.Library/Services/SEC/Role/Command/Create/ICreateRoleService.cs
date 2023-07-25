using Application.Library.Bases;
using Application.Library.DTOs;
using Application.Library.Views;
using Domain.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Library.Services
{
    public interface ICreateRoleService
    {
        ResultView Execute(RoleDTO role);
    }
    public class CreateRoleService : ICreateRoleService
    {
        RoleService roleService;
        public CreateRoleService(RoleService roleService)
        {
            this.roleService = roleService;
        }

        public ResultView Execute(RoleDTO role)
        {
            Role entity = new Role();
            roleService.Create(entity);
            return new ResultView()
            {
                IsSuccess = true,
                Message = "با موفقیت ذخیره شد",
            };
        }
    }

}
