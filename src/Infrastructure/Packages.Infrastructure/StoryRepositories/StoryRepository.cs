﻿using Microsoft.EntityFrameworkCore;
using Packages.Application.StoryAppLayer.Gateway;
using Packages.Domain.StoryDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Repository.StoryRepositories
{
    public class StoryRepository
    {
        /*private readonly StoryDbContext _storyDbContext;

        public StoryRepository(StoryDbContext storyDbContext)
        {
            _storyDbContext = storyDbContext;
        }
        public async Task<Story> AddAsync(Story story)
        {
            await _storyDbContext.AddAsync(story);
            await _storyDbContext.SaveChangesAsync();

            return story;
        }

        public async Task<IEnumerable<Story>> GetAsync()
        {
            return await _storyDbContext.Story.ToListAsync();
        }

        public async Task<Story> GetByIdAsync(Guid id)
        {
            return await _storyDbContext.Story.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Story> RemoveAsync(Guid id)
        {
            var storyToRemove = await GetByIdAsync(id);
            _storyDbContext.Story.Remove(storyToRemove);
            await _storyDbContext.SaveChangesAsync();
            return storyToRemove;
        }

        public async Task<Story> UpdateAsync(Story story)
        {
            _storyDbContext.Story.Update(story);
            await _storyDbContext.SaveChangesAsync();

            return story;
        }
    }*/
    }
}
