[ApiController]
public class TasksController(IEmailService emailService) : ControllerBase
{

    [HttpPost("task")]
    public async Task<IActionResult> SendSnsDirectEmail()
    {
        try
        {
            return Ok("Task Created!! Big one!!!");
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    [HttpPost("task")]
    public async Task<IActionResult> SendSnsDirectEmail()
    {
        try
        {
            return Ok("Task Created!! Big one!!!");
        }
        catch (System.Exception)
        {

            throw;
        }
    }
}