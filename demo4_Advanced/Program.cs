using demo4_Advanced.FifaGame;
using System.Threading.Tasks;
using demo4_Advanced.Youtoube;
namespace demo4_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ex01
            /*         Ball ball = new Ball() { ID = 1 };
                     Console.WriteLine(ball);
                     ball.Locationn = new Location() { x = 1, y = 1, z = 1 };
                     Console.WriteLine(ball);
                     Player p1 = new Player() { PlayerName = "messi", TeamName = "miami" };
                     Player p2 = new Player() { PlayerName = "Alba", TeamName = "miami" };
                     Refree R01 = new Refree() { RefreeName = "Ibrahim" };
                     ball.Ballchanged += p1.Run;
                     ball.Ballchanged += p2.Run;
                     ball.Ballchanged += R01.look;
                     ball.Locationn = new Location() { x = 1, y = 2, z = 3 };
                     Console.WriteLine(ball);*/

            #endregion

            #region ex02


            /*         Channel channel = new Channel()
                     {
                         ChannelName = "ABS"
                     };
                     channel.addvideo(new Video() { Title = "Title", Description = "Description " });

                     Subcriber sub1 = new Subcriber() { SubcriberName = "Ahmed" };
                     Subcriber sub2 = new Subcriber() { SubcriberName = "Mohammed" };
                     Subcriber sub3 = new Subcriber() { SubcriberName = "Amira" };
                     Subcriber sub4 = new Subcriber() { SubcriberName = "osama" };
                     Subcriber sub5 = new Subcriber() { SubcriberName = "mostafa" };

                     channel.Uploadvideo += sub1.notify;
                     channel.Uploadvideo += sub2.notify;
                     channel.Uploadvideo += sub3.notify;

                     channel.addvideo(new Video() { Title = "Title1", Description = "Description02" }); */


            #endregion


            #region hashtable --gernaric 
            Dictionary<string, long> Note = new Dictionary<string, long>();
            Note.Add("ahmed", 99999);
            Note.Add("ali", 88888);
            Note.Add("osama", 77777);

            foreach (var note in Note)
            {
                Console.WriteLine($"{note.Key} , {note.Value} ");
            }
            #endregion




        }
    }
}
