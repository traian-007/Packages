using Microsoft.AspNetCore.Mvc;
using Packages.Api.Controllers.SeedWork;
using Packages.Application.StoryAppLayer.UseCases.StoryUseCases.CreateStory;
using Packages.Application.StoryAppLayer.UseCases.StoryUseCases.GetStories;
using Packages.Application.StoryAppLayer.UseCases.StoryUseCases.GetStoryById;
using Packages.Application.StoryAppLayer.UseCases.StoryUseCases.UpdateStory;
using Packages.Application.StoryAppLayer.UseCases.StoryUseCases.DeleteStory;

namespace Packages.Api.Controllers
{
    public class StoriesController : PackagesBaseController
    {
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetStoriesQuery query)
        {
            var stories = await Mediator.Send(query);

            return Ok(stories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var story = await Mediator.Send(new GetStoryByIdQuery { Id = id});

            return Ok(story);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateStoryCommand command)
        {
            var story = await Mediator.Send(command);
            return CreatedAtAction("Get", new {id = story.Id}, story);
        }

        [HttpPut("{id}")] //stories/id
        public async Task<IActionResult> Put([FromRoute] Guid id, [FromBody] UpdateStoryCommand command)
        {
            if(id != command.Id)
            {
                return BadRequest();
            }

            var story = await Mediator.Send(command);
            return Ok(story);
        }

        [HttpDelete("{id}")] //stories/id
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var story = await Mediator.Send(new DeleteStoryCommand { Id = id});
            return Ok(story);
        }
    }
    

}
