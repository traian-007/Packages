using MediatR;
using Packages.Application.StoryAppLayer.DTOs;
using Packages.Application.StoryAppLayer.Gateway;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Application.StoryAppLayer.UseCases.StoryUseCases.DeleteStory
{
    public class DeleteStoryCommandHandler : IRequestHandler<DeleteStoryCommand, StoryDto>
    {
        private readonly IStoryRepository _storyRepository;
        public DeleteStoryCommandHandler(IStoryRepository storyRepository) {
            _storyRepository = storyRepository;
        }
        public async Task<StoryDto> Handle(DeleteStoryCommand request, CancellationToken cancellationToken)
        {
            var deletedStory = await _storyRepository.RemoveAsync(request.Id);

            var storyDto = new StoryDto { Id = deletedStory.Id, Text = deletedStory.Text };

            return storyDto;
        }
    }
}
