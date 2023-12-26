﻿using Microsoft.AspNetCore.Mvc;

using StreamMasterApplication.SchedulesDirect.Commands;

namespace StreamMasterAPI.Controllers;

public class TestController : ApiControllerBase
{
    [HttpPut]
    [Route("[action]")]
    public async Task<ActionResult<bool>> EPGSync()
    {
        return await Mediator.Send(new EPGSync()).ConfigureAwait(false);
    }
}