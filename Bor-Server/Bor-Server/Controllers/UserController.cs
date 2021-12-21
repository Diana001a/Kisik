using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bor.DataAccess.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bor.Core.Models;
using Albina.BusinesLogic.Core.Interfaces;
using AutoMapper;
using Albina.BusinesLogic.Core.Models;

namespace Bor_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }
        [HttpPost("/auth")]
        public async Task<ActionResult<UserInfoprmationDto>> Auth([FromBody]UserIdentityDto userIdentityDto)
        {
            UserIdentityBlo userIdentityBlo = _mapper.Map<UserIdentityBlo>(userIdentityDto);
            UserInformationBlo userInformationBlo = await _userService.Auth(userIdentityBlo);
            UserInfoprmationDto userInformationDto = _mapper.Map<UserInfoprmationDto>(userInformationBlo);
            return userInformationDto;
        }
        [HttpPost("/register")]
        public async Task<ActionResult<UserInfoprmationDto>> Register([FromBody]UserIdentityDto userIdentityDto)
        {
            UserIdentityBlo userIdentityBlo = _mapper.Map<UserIdentityBlo>(userIdentityDto);
            UserInformationBlo userInformationBlo = await _userService.Register(userIdentityBlo);
            UserInfoprmationDto userInformationDto = _mapper.Map<UserInfoprmationDto>(userInformationBlo);
            return userInformationDto;
        }
        [HttpPost("/update")]
        public async Task<ActionResult<UserInfoprmationDto>> Update([FromBody] UserIdentityDto userIdentityDto)
        {
           
        }
    }
}
