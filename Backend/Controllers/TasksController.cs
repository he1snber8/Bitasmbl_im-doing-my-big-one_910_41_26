[ApiController]
public class TasksController(IEmailService emailService) : ControllerBase
{

    [HttpPost("task")]
    public async Task<IActionResult> SendSnsDirectEmail()
    {
        try
        {
            return Ok("Task Created!!");
        }
        catch (System.Exception)
        {

            throw;
        }
    }
}