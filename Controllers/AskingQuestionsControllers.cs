using AllForOne.Service;
using Microsoft.AspNetCore.Mvc;


namespace AllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AskingQuestionsControllers : ControllerBase
    {
        private readonly AskingQuestionsServices _askingQuestionsServices;
        public AskingQuestionsControllers(AskingQuestionsServices askingQuestionsServices)
        {
            _askingQuestionsServices = askingQuestionsServices;
        }
        
        [HttpPost]
        [Route("SetReply/{yourName}/{whatTimeDidyouWakeUp}")]
        public string SetReply(string yourName, string whatTimeDidyouWakeUp)
        {
            _askingQuestionsServices.SetReply(yourName, whatTimeDidyouWakeUp);
            return _askingQuestionsServices.reply;
        }
    }
}