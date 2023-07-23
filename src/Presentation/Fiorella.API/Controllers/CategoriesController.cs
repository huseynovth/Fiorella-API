using Fiorella.Aplication.Abstraction.Services;
using Fiorella.Aplication.DTOs.CategoryDTOs;
using Fiorella.Persistence.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

namespace Fiorella.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryservice;

        public CategoriesController(ICategoryService categoryservice)
        {
            _categoryservice = categoryservice;
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(int id) 
        {
            try
            {
                CategoryGetDto result=await _categoryservice.GetByIdAsync(id);
                return Ok(result);  
            }
            catch (NotFoundException ex)
            {
                return StatusCode(ex.StatusCode, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
 
        }
        [HttpPost]
        public async Task<IActionResult> Post(CategoryCreateDto categoryCreateDto)  
        {
            try
            {
                await _categoryservice.CreateAsync(categoryCreateDto);
                return StatusCode((int)HttpStatusCode.Created);
            }
            catch (DuplicatedException ex)
            {

                return StatusCode(ex.StatusCode, new {message= ex.Message });   
            }catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message) ;
            }
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            try
            {
                List <CategoryGetDto> result=await _categoryservice.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
