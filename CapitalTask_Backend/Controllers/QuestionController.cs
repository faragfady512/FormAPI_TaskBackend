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
    public class QuestionController : ControllerBase
    {
        private readonly IGenericRepository<Question> _questionRepository;
        private readonly IMapper _mapper;

        public QuestionController(IGenericRepository<Question> questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        //need to make get and post action method 
        [HttpGet]
        public IActionResult GetQuestion()
        {
            try
            {
                // Use your program repository to retrieve all Workflow details from the data store
                var Questions = _questionRepository.GetAll();

                // Check if any Questions details were found
                if (Questions == null)
                {
                    return NotFound("No Questionsfound.");
                }

                // Return the list of Questions details as an HTTP response
                return Ok(Questions);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the retrieval process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while retrieving Questions.");
            }
        }


        [HttpPost]
        public IActionResult Create([FromBody] QuestionDto questionDto)
        {
            if (questionDto == null)
            {
                return BadRequest("Invalid Question data.");
            }

            var questions = _mapper.Map<Question>(questionDto);

            try
            {
                // Use your workFlow repository to save the program to the data store
                _questionRepository.Add(questions);


                // Return a response indicating success
                return Ok("question Added successfully.");
            }
            catch (Exception ex)
            {
                //Handle any exceptions that may occur during the save process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while creating the questions.");
            }

            return Ok(questions);
        }
    }
}
