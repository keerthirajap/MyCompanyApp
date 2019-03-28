﻿using Domain;
using RepositoryInterface;
using ServiceInterface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceConcrete
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            this._adminRepository = adminRepository;
        }
        public async Task<List<User>> GetUsers()
        {
            return await this._adminRepository.GetUsers(); 
        }

        public async Task<long> AddUser(User user)
        {
            return await this._adminRepository.AddUser(user);
        }
    }
}