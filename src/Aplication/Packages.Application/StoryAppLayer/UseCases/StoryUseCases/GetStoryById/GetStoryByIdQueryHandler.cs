﻿using MediatR;
using Packages.Application.StoryAppLayer.DTOs;
using Packages.Application.StoryAppLayer.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Application.StoryAppLayer.UseCases.StoryUseCases.GetStoryById
{
    public class GetStoryByIdQueryHandler : IRequestHandler<GetStoryByIdQuery, StoryDto>
    {
        private readonly IStoryRepository _storyRepository;
        public GetStoryByIdQueryHandler(IStoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }
        public async Task<StoryDto> Handle(GetStoryByIdQuery request, CancellationToken cancellationToken)
        {
            var story = await _storyRepository.GetByIdAsync(request.Id);

            var storyDto = new StoryDto { Id = story.Id, Text = story.Text };

            return storyDto;
        }
    }
}
