﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P04_EF_Applying_To_API.Data;
using P04_EF_Applying_To_API.Models;
using P04_EF_Applying_To_API.Models.Dto;

namespace P04_EF_Applying_To_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : ControllerBase
    {
        private readonly RestaurantContext _db;
        public DishesController(RestaurantContext db)
        {
            _db = db;
        }

        /// <summary>
        /// Fetches all registered dishes in the DB
        /// </summary>
        /// <returns>All dishes in DB</returns>
        [HttpGet("dishes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<GetDishDTO>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<GetDishDTO>> GetDishes()
        {
            return Ok(_db.Dishes
                .Include(d => d.RecipeItems)
                .Select(d => new GetDishDTO(d))
                .ToList());
        }

        /// <summary>
        /// Fetch registered dish with a specified ID from DB
        /// </summary>
        /// <param name="id">Requested dish ID</param>
        /// <returns>Dish with specified ID</returns>
        [HttpGet("dishes/{id:int}", Name = "GetDish")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(GetDishDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<GetDishDTO>> GetDishById(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            // Tam, kad istraukti duomenis naudokite
            // First, FirstOrDefault, Single, SingleOrDefault, ToList
            var dish = _db.Dishes
                .Include(d => d.RecipeItems)
                .FirstOrDefault(d => d.DishId == id);
            
            if(dish == null)
            {
                return NotFound();
            }

            return Ok(new GetDishDTO(dish));
        }

        [HttpPost("dishes")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(GetDishDTO))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<CreateDishDTO> CreateDish(CreateDishDTO dishDTO)
        {
            if(dishDTO == null)
            {
                return BadRequest();
            }

            Dish model = new()
            {
                Country = dishDTO.Country,
                SpiceLevel = dishDTO.SpiceLevel,
                Type = dishDTO.Type,
                Name = dishDTO.Name,
                CreateDateTime = dishDTO.CreateDateTime,
                ImagePath = dishDTO.ImagePath
            };

            _db.Dishes.Add(model);
            _db.SaveChanges();

            return CreatedAtRoute("GetDish", new { id = model.DishId }, dishDTO);
        }

        [HttpDelete("dishes/delete/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteDish(int id)
        {
            if(id == 0) 
            { 
                return BadRequest();
            }

            var dish = _db.Dishes
                .FirstOrDefault(d => d.DishId== id);

            if(dish == null)
            {
                return NotFound();
            }

            _db.Dishes.Remove(dish);
            _db.SaveChanges();

            return NoContent();
        }

        [HttpPut("dishes/update/{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult UpdateDish(int id, UpdateDishDTO updateDishDTO)
        {
            if(id == 0 || updateDishDTO == null)
            {
                return BadRequest();
            }

            var foundDish = _db.Dishes
                .FirstOrDefault(d => d.DishId== id);

            if(foundDish == null)
            {
                return NotFound();
            }

            foundDish.Name= updateDishDTO.Name;
            foundDish.ImagePath= updateDishDTO.ImagePath;
            foundDish.Type= updateDishDTO.Type;
            foundDish.SpiceLevel= updateDishDTO.SpiceLevel;
            foundDish.Country= updateDishDTO.Country;

            _db.Dishes.Update(foundDish);
            _db.SaveChanges();

            return NoContent();
        }
    }
}
