﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface ITopicRepository : IRepo<Topic>
    {
        Task<IEnumerable<Topic>> GetAllWithDetailsAsync();
        Task<IEnumerable<Topic>> GetAllByAuthorIdAsync(int authorId);
        Task<Topic> GetByIdWithDetailsAsync(int id);
    }
}
