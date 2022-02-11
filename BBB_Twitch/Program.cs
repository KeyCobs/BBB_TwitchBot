using System;

namespace BBB_Twitch
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            string ip = "irc.chat.twitch.tv";
            int port = 6667;
            string password = Environment.GetEnvironmentVariable("TWITCH_OAUTH"); // change

            string botUserName = "Big_Brain_Bot";
        }
    }
}
