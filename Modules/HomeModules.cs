using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.SetRecipient("Eric");
        myLetterVariables.SetSender("John");
        return View["hello.cshtml", myLetterVariables];
      };
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
      Get["/greeting_card"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.SetRecipient(Request.Query["recipient"]);
        myLetterVariables.SetSender(Request.Query["sender"]);
        return View["hello.cshtml", myLetterVariables];
      };
    }
  }
}
