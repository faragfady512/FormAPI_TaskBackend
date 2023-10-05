using AutoMapper;
using CapitalTask_Backend.Dto;
using CapitalTask_Backend.Entities;
using CapitalTask_Backend.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CapitalTask_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationController : ControllerBase
    {
       
        private readonly IGenericRepository<Education> _EducationRepository;
        private readonly IMapper _mapper;

        public EducationController(IGenericRepository<Education> educationRepository, IMapper mapper)
        {
            _EducationRepository = educationRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllPrograms()
        {
            try
            {
                // Use your education repository to retrieve all program details from the data store
                var education = _EducationRepository.GetAll();

                // Check if any education details were found
                if (education == null)
                {
                    return NotFound("No education found.");
                }

                // Return the list of program details as an HTTP response
                return Ok(education);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the retrieval process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while retrieving programs.");
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] EducationDto educationDto)
        {
            if (educationDto == null)
            {
                return BadRequest("Invalid education data.");
            }

            var EducationDetails = _mapper.Map<Education>(educationDto);

            try
            {
                // Use your edcation repository to save the program to the data store
                _EducationRepository.Add(EducationDetails);


                // Return a response indicating success
                return Ok("education created successfully.");
            }
            catch (Exception ex)
            {
                //Handle any exceptions that may occur during the save process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while creating the program.");
            }

            return Ok(EducationDetails);
        }




        [HttpPut("{id}")]
        public IActionResult UpdateProgram(int id, [FromBody] EducationDto educationDto)
        {
            try
            {
                if (educationDto == null)
                {
                    return BadRequest("Invalid education data.");
                }

                // Check if a education with the given ID exists
                var existingeducation = _EducationRepository.GetById(id);

                if (existingeducation == null)
                {
                    return NotFound("Education not found.");
                }

                // Map the DTO to the existing education entity
                _mapper.Map(educationDto, existingeducation);

                // Update the education in the data store
                _EducationRepository.Update(existingeducation);

                // Return a success response
                return Ok("Edcuation updated successfully.");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the update process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while updating the education.");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetProgramById(int id)
        {
            try
            {
                // Use your program repository to retrieve a program by its ID
                var education = _EducationRepository.GetById(id);

                if (education == null)
                {
                    return NotFound("education not found.");
                }

                // Return the program as an HTTP response
                return Ok(education);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the retrieval process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while retrieving the education.");
            }
        }


    }
}
