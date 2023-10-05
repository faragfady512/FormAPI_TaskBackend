using AutoMapper;
using CapitalTask_Backend;
using CapitalTask_Backend.Dto;
using CapitalTask_Backend.Entities;
using CapitalTask_Backend.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CaptialTask_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgramsDetailsController : ControllerBase
    {
        //private readonly IProgramDetailsRepository _programDetailsRepository;
        private readonly IGenericRepository<ProgramDetails> _programDetailsRepository;
        private readonly IMapper _mapper;

        public ProgramsDetailsController(IGenericRepository<ProgramDetails> programDetailsRepository,IMapper mapper)
        {
            _programDetailsRepository = programDetailsRepository;
            _mapper = mapper;   
        }

        [HttpGet]
        public IActionResult GetAllPrograms()
        {
            try
            {
                // Use your program repository to retrieve all program details from the data store
                var programDetailsList = _programDetailsRepository.GetAll();

                // Check if any program details were found
                if (programDetailsList == null )    
                {
                    return NotFound("No programs found.");
                }

                // Return the list of program details as an HTTP response
                return Ok(programDetailsList);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the retrieval process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while retrieving programs.");
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProgramDetailsDto programDetailsDto)
        {
            if (programDetailsDto == null)
            {
                return BadRequest("Invalid program data.");
            }
            
            var programDetails = _mapper.Map<ProgramDetails>(programDetailsDto);

            try
            {
                // Use your program repository to save the program to the data store
                _programDetailsRepository.Add(programDetails);
               

                // Return a response indicating success
                return Ok("Program created successfully.");
        }
            catch (Exception ex)
            {
                //Handle any exceptions that may occur during the save process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while creating the program.");
            }

            return Ok(programDetails);
        }




    [HttpPut("{id}")]
        public IActionResult UpdateProgram(int id, [FromBody] ProgramDetailsDto programDetailsDto)
        {
            try
            {
                if (programDetailsDto == null)
                {
                    return BadRequest("Invalid program data.");
                }

                // Check if a program with the given ID exists
                var existingProgram = _programDetailsRepository.GetById(id);

                if (existingProgram == null)
                {
                    return NotFound("Program not found.");
                }

                // Map the DTO to the existing program entity
                _mapper.Map(programDetailsDto, existingProgram);

                // Update the program in the data store
                _programDetailsRepository.Update(existingProgram);

                // Return a success response
                return Ok("Program updated successfully.");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the update process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while updating the program.");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetProgramById(int id)
        {
            try
            {
                // Use your program repository to retrieve a program by its ID
                var program = _programDetailsRepository.GetById(id);

                if (program == null)
                {
                    return NotFound("Program not found.");
                }

                // Return the program as an HTTP response
                return Ok(program);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the retrieval process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while retrieving the program.");
            }
        }


    }
}
