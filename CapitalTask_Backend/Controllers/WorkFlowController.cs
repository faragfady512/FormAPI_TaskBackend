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
    public class WorkFlowController : ControllerBase
    {
      
        private readonly IGenericRepository<WorkFlow> _workFlowRepository;
        private readonly IMapper _mapper;

        public WorkFlowController(IGenericRepository<WorkFlow> workFlowRepository, IMapper mapper)
        {
            _workFlowRepository = workFlowRepository;
            _mapper = mapper;
        }

        //need to make get and post action method 
        [HttpGet]
        public IActionResult GetWorkFlow()
        {
            try
            {
                // Use your program repository to retrieve all Workflow details from the data store
                var WorkFlowDetailsList = _workFlowRepository.GetAll();

                // Check if any Workflow details were found
                if (WorkFlowDetailsList == null)
                {
                    return NotFound("No Workflow found.");
                }

                // Return the list of Workflow details as an HTTP response
                return Ok(WorkFlowDetailsList);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the retrieval process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while retrieving workflows.");
            }
        }


        [HttpPost]
        public IActionResult Create([FromBody] WorkFlowDto workflowDto)
        {
            if (workflowDto == null)
            {
                return BadRequest("Invalid WorkFlow data.");
            }

            var workFlow = _mapper.Map<WorkFlow>(workflowDto);

            try
            {
                // Use your workFlow repository to save the program to the data store
                _workFlowRepository.Add(workFlow);


                // Return a response indicating success
                return Ok("WorkFlow Added successfully.");
            }
            catch (Exception ex)
            {
                //Handle any exceptions that may occur during the save process
                // You can log the exception or return an error response as needed
                return StatusCode(500, "An error occurred while creating the WorkFlow.");
            }

            return Ok(workFlow);
        }
    }
}
