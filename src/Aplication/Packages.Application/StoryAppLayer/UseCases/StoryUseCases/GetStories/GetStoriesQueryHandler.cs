﻿using MediatR;
using Packages.Application.StoryAppLayer.DTOs;
using Packages.Application.StoryAppLayer.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Application.StoryAppLayer.UseCases.StoryUseCases.GetStories
{
    public class GetStoriesQueryHandler : IRequestHandler<GetStoriesQuery, IEnumerable<StoryDto>>
    {
        private readonly IStoryRepository _storyRepository;
        public GetStoriesQueryHandler(IStoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }
        public async Task<IEnumerable<StoryDto>> Handle(GetStoriesQuery request, CancellationToken cancellationToken)
        {
            var stories = await _storyRepository.GetAsync();

            var storiesDto = stories.Select(x => new StoryDto { Id = x.Id,Text = x.Text});

            return storiesDto;
        }
    }
}
