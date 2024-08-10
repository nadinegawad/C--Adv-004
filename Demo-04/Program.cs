namespace Demo_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex01
            //Ball ball = new Ball() { Id = 1 };
            //Console.WriteLine(ball);

            //Player P01 = new Player() { PlayerName = "Messi", TeamName = "Miami" };
            //Player P02 = new Player() { PlayerName = "Alba", TeamName = "Miami" };

            //Player P03 = new Player() { PlayerName = "Pedri", TeamName = "Barcolna" };
            //Player P04 = new Player() { PlayerName = "Gavi", TeamName = "Barcolna" };
            //Player P05 = new Player() { PlayerName = "marmosh", TeamName = "Barcolna" };
            //Refree R01 = new Refree() { RefreeName = "Mohamed" };

            //ball.BallLocationChange += P01.Run;
            //ball.BallLocationChange += P02.Run;
            //ball.BallLocationChange += P03.Run;
            //ball.BallLocationChange += P04.Run;
            //ball.BallLocationChange += R01.Look;
            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };

            //ball.BallLocationChange -= P04.Run;
            //ball.BallLocationChange += P05.Run;
            //ball.Location = new Location() { X = 2, Y = 1, Z = 1 }; 
            #endregion

            #region E02
            //Channel C01 = new Channel() { ChannelName = "ABC" };
            //C01.AddVideo(new Video() { Title = "Title01", Descripation = "Desc01" });
            //Console.WriteLine(C01);

            //Subscriber S01 = new Subscriber() { name = "Ahmed" };
            //Subscriber S02 = new Subscriber() { name = "Amr" };
            //Subscriber S03 = new Subscriber() { name = "Aya" };
            //Subscriber S04 = new Subscriber() { name = "Belal" };
            //Subscriber S05 = new Subscriber() { name = "Ali" };

            //C01.UploadVideo += S01.notify;
            //C01.UploadVideo += S02.notify;
            //C01.UploadVideo += S03.notify;
            //C01.UploadVideo += S04.notify;

            //C01.AddVideo(new Video() { Title = "Title02", Descripation = "Desc02" });

            #endregion


        }
    }
}
