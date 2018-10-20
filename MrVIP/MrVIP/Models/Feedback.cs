using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MrVIP.Models
{
    [Serializable]
    public class Feedback
    {
        public string Topic;

        [Prompt("Enter a detail for your feedback")]
        public string Detail;

        [Prompt("What is your first name?")]
        public string FirstName;

        [Describe("sirname")]
        public string LastName;

        [Pattern(@"^\d{10}$")]
        public string PhoneNumber;

        [Prompt("What is the best date and time for a callback?")]
        public DateTime? BestTimeOfDayToCall;

        public string Suggestion;

        [Prompt("Please list the most important feature you think we should add?. {||}")]
        public List<Feature> Features;

        // How much do you like this Chatbot Mr.Vip? (I love it. I just like it. I don't like.)
        //public Like Like;

        [Prompt("How often do you use it?")]
        public Frequency UserFrequency;

        public static IForm<Feedback> BuildForm()
        {
            return new FormBuilder<Feedback>().Build();
        }
    }

    public enum Feature
    {
        TextOnlyChat = 1,
        ChatWithImages = 2,
        VoiceChat = 3,
        Other = 4
    }

    public enum Frequency
    {
        Daily = 1,
        TwiceInAWeek = 2,
        Weekly = 3,
        Monthly = 4
    }
}