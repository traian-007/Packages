﻿using MediatR;
using Packages.Application.StoryAppLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Application.StoryAppLayer.UseCases.StoryUseCases.CreateStory
{
    public class CreateStoryCommand : IRequest<StoryDto>
    {
        public string? Text { get; set; }
    }
}
