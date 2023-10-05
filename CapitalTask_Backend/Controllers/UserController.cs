using AutoMapper;
using CapitalTask_Backend.Dto;
using CapitalTask_Backend.Entities;
using CapitalTask_Backend.Interfaces;
using CapitalTask_Backend.Repositories;
using CaptialTask_Backend.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.AccessControl;

namespace CapitalTask_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {


        private readonly IGenericRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public UserController(IGenericRepository<User> userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public  IActionResult GetAllUsers()
        {
            try
            {
                var UsersData = _userRepository.GetAll();

                if (UsersData == null)
                {
                    return NotFound("No User Found");
                }
                return Ok(UsersData);

            }
            catch (Exception ex)
            {

                // Handle any exceptions that may occur during the retrieval process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while GetAll Users.");

            }
            
        
        }

        [HttpPost]
        public IActionResult AddUser(UserDto userDto)
        {

            if (userDto == null)
            {
                return BadRequest("Invalid user data.");
            }

            var UsersDetails = _mapper.Map<User>(userDto);

            try
            {
                // Use your program repository to save the program to the data store
                _userRepository.Add(UsersDetails);
              


                // Return a response indicating success
                return Ok("user created successfully.");
            }
            catch (Exception ex)
            {
                //Handle any exceptions that may occur during the save process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while creating the program.");
            }

            return Ok(UsersDetails);

        }
    }
}
