﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notatnik.Server.Services.UserService;
using Notatnik.Shared;
using Notatnik.Shared.Dtos.NoteDto;
using System.Data;

namespace Notatnik.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[ValidateAntiForgeryToken]
    [Authorize(Roles = "User")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("create-user-note")]
        public async Task<ActionResult<ServiceResponse<NoteDto>>> CreateUserNote(NoteDto noteDto)
        {
            var response = await _userService.CreateUserNote(noteDto);
            if (!response.Success)
            {
                return BadRequest("Bad");
            }

            return Ok(response.Data);
        }
    }
}
