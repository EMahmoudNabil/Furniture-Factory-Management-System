using Api_Task_Techtroll.co.Application.DTOs;
using Api_Task_Techtroll.co.Application.Services.ComponentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Task_Techtroll.co.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComponentController : ControllerBase
    {
        private readonly IComponentService _componentService;

        public ComponentController(IComponentService componentService)
        {
            _componentService = componentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var components = await _componentService.GetAllAsync();
            return Ok(components);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var component = await _componentService.GetByIdAsync(id);
            return component == null ? NotFound() : Ok(component);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateComponentDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var id = await _componentService.CreateAsync(dto);
            return CreatedAtAction(nameof(Get), new { id }, null);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateComponentDto dto)
        {
            if (id != dto.Id) return BadRequest("ID mismatch");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var success = await _componentService.UpdateAsync(dto);
            return success ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _componentService.DeleteAsync(id);
            return success ? NoContent() : NotFound();
        }

        [HttpGet("byProduct/{productId}")]
        public async Task<IActionResult> GetComponentsByProductId(int productId)
        {
            var components = await _componentService.GetComponentsByProductId(productId);
            return Ok(components);
        }
    }
}
