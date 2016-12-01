using Nancy;
using System.Collections.Generic;
using System;
using ScrabbleScore.Objects;

namespace ScrabbleScore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        Score newScore = new Score(Request.Form["word"]);
        int finalScore = newScore.ScoreCalc();
        return View["results.cshtml", newScore];
      };

    }
  }
}
