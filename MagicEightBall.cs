using System;

namespace MagicEightBall
{
  public class MagicEightBall
  {
    string[] answers = {"It is certain",
        "It is decidedly so",
        "Without a doubt",
        "Yes – definitely",
        "You may rely on it",
        "As I see it, yes",
        "Most likely",
        "Outlook good",
        "Yes",
        "Signs point to yes",
        "Reply hazy, try again",
        "Ask again later",
        "Better not tell you now",
        "Cannot predict now",
        "Concentrate and ask again",
        "Don't count on it",
        "My reply is no",
        "My sources say no",
        "Outlook not so good",
        "Very doubtful",
    };

    public string GetAnswer()
    {
      Random random = new Random();
      int answerIndex = random.Next(0, answers.Length);

      return answers[answerIndex];
    }
  }
}