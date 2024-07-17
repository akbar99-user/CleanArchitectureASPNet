using Domain.Entities;
using Domain.Interface.Application;
using Infrastructure.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace Infrastructure.Controllers
{
    [Route("api/[controller]")]
    public class ProgramStudiController : Controller
    {
        private readonly IProgramStudiApplication _application;
        public ProgramStudiController(IProgramStudiApplication application)
        {
            _application = application;
        }
        [HttpGet("GetRecords")]
        public async Task<ActionResult> GetRecords()
        {
            try
            {
                var result = await _application.GetRecords();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("GetRecord")]
        public async Task<ActionResult> GetRecord(int id)
        {
            try
            {
                var result = await _application.GetRecord(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("Insert")]
        public async Task<ActionResult> Insert(ProgramStudi entity)
        {
            try
            {
                var result = await _application.Insert(entity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Update")]
        public async Task<ActionResult> Update(ProgramStudi entity)
        {
            try
            {
                var result = await _application.Update(entity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var result = await _application.Delete(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
