using System;
using Business.Models;
using DataAccess.Contexts;
using DataAccess.Entities;
using DataAccess.Results;
using DataAccess.Results.Bases;
using Microsoft.EntityFrameworkCore;

namespace Business.Services
{
    public interface IRoleService
    {
        IQueryable<RoleModel> Query();
        Result Add(RoleModel model);
        Result Update(RoleModel model);
        Result Delete(int id);
    }

    public class RoleService : IRoleService
    {
        private readonly Db _db;
        public RoleService(Db db)
        {
            _db = db;
        }

       /* public IQueryable<RoleModel> Query()
        {
            return _db.Roles.Include(s => s.Name).OrderBy(s => s.Name).Select(s => new RoleModel()
            {
                Id = s.Id,
                Name = s.Name,
                GameCount = s.Users.Count
            }) ;
        }*/
        public IQueryable<RoleModel> Query()
        {
            return _db.Roles.OrderBy(s => s.Name).Select(s => new RoleModel()
            {
                Id = s.Id,
                Name = s.Name,
                GameCount = s.Users.Count,
                GameNamesOutput=string.Join("</br>",s.Users.OrderByDescending(p=>p.IsVip).ThenBy(p=>p.Name).Select(p=>p.Name))
            });
        }

        public Result Add(RoleModel model)
        {
            if (_db.Roles.Any(s => s.Name.ToLower() == model.Name.ToLower().Trim()))
                return new ErrorResult("Role with the same name exists!");

            Role newRole = new Role
            {
                Name = model.Name.Trim()
            };
            _db.Roles.Add(newRole);
            _db.SaveChanges();
            return new SuccessResult("Role added successfully.");
        }

        public Result Update(RoleModel model)
        {
            if (_db.Roles.Any(s => s.Id != model.Id && s.Name.ToLower() == model.Name.ToLower().Trim()))
                return new ErrorResult("Role with the same name exists!");

            var entity = _db.Roles.Find(model.Id);
            if (entity == null)
                return new ErrorResult("Role not found!");

            entity.Name = model.Name.Trim();
            _db.SaveChanges();

            return new SuccessResult("Role updated successfully.");
        }

        public Result Delete(int id)
        {
            var entity = _db.Roles.Include(s => s.Game).SingleOrDefault(s => s.Id == id);
            if (entity == null)
                return new ErrorResult("Role not found!");

            
            if (entity.Game != null && entity.Game.GameUsers != null && entity.Game.GameUsers.Any())
                return new ErrorResult("Role can't be deleted because it has related games!");

            _db.Roles.Remove(entity);
            _db.SaveChanges();

            return new SuccessResult("Role deleted successfully.");
        }
    }
}
