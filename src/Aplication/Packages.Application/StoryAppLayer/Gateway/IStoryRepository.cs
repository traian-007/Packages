﻿using Packages.Domain.StoryDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Application.StoryAppLayer.Gateway
{
    public interface IStoryRepository
    {
        Task<IEnumerable<Story>> GetAsync();
        Task<Story> GetByIdAsync(Guid id);
        Task<Story> AddAsync(Story story);
        Task<Story> UpdateAsync(Story story);
        Task<Story> RemoveAsync(Guid id);
    }
}
