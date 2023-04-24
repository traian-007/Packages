using MediatR;
using Packages.Application.StoryAppLayer.DTOs;
using Packages.Application.StoryAppLayer.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Application.StoryAppLayer.UseCases.StoryUseCases.UpdateStory
{
    public class UpdateStoryCommandHandler : IRequestHandler<UpdateStoryCommand, StoryDto>
    {
        private readonly IStoryRepository _storyRepository;
        public UpdateStoryCommandHandler(IStoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }
        public async Task<StoryDto> Handle(UpdateStoryCommand request, CancellationToken cancellationToken)
        {
            var story = await _storyRepository.GetByIdAsync(request.Id);

            if (story == null)
            {
                throw new NotImplementedException();
            }

            story.Text = request.Text;

            var updatedStory = await _storyRepository.UpdateAsync(story);
            
            if (updatedStory == null)
            {
                throw new NotImplementedException();
            }

            return new StoryDto { Id = updatedStory.Id, Text = updatedStory.Text };
        }
    }
}
