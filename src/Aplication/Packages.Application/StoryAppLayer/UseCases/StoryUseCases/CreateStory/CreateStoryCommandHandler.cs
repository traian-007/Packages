﻿using MediatR;
using Packages.Application.StoryAppLayer.DTOs;
using Packages.Application.StoryAppLayer.Gateway;
using Packages.Domain.StoryDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Application.StoryAppLayer.UseCases.StoryUseCases.CreateStory
{
    public class CreateStoryCommandHandler : IRequestHandler<CreateStoryCommand, StoryDto>
    {
        private readonly IStoryRepository _storyRepository;
        public CreateStoryCommandHandler(IStoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }
        public async Task<StoryDto> Handle(CreateStoryCommand request, CancellationToken cancellationToken)
        {
            var story = new Story
            {
                Id = Guid.NewGuid(),
                Text = request.Text,
            };

            var newStory = await _storyRepository.AddAsync(story);

            var storyDto = new StoryDto
            {
                Id = newStory.Id,
                Text = newStory.Text,
            };

            return storyDto;
        }
    }
}
