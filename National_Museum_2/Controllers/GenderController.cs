﻿using Microsoft.AspNetCore.Mvc;
using National_Museum_2.DTO.Gender;
using National_Museum_2.Model;
using National_Museum_2.Repository;
using National_Museum_2.Service;

namespace National_Museum_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GenderController : ControllerBase
    {
        private readonly IGenderService _genderService;

        public GenderController(IGenderService genderService)
        {

            _genderService = genderService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<ActionResult<IEnumerable<Gender>>> GetAllGender()
        {
            var gender = await _genderService.GetAllGenderAsync();
            return Ok(gender);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Gender>> GetGenderById(int id)
        {
            var gender = await _genderService.GetGenderByIdAsync(id);
            if (gender == null)
                return NotFound();

            return Ok(gender);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateGender([FromBody] CreateGenderRequest gender)
        {

            await _genderService.CreateGenderAsync(gender);
            return CreatedAtAction(nameof(GetGenderById), new { id = gender }, gender);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateGender([FromBody] UpdateGenderRequest gender)
        {

            var existingGender = await _genderService.GetGenderByIdAsync(gender.genderId);
            if (existingGender == null)
                return NotFound();

            await _genderService.UpdateGenderAsync(gender);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> SoftDeleteGender(int id)
        {
            var gender = await _genderService.GetGenderByIdAsync(id);
            if (gender == null)
                return NotFound();

            await _genderService.SoftDeleteGenderAsync(id);
            return NoContent();
        }
    }
}
