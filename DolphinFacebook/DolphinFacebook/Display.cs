using System;
using System.Collections.Generic;
using System.Text;
using MamaFacebook.Abstract;


namespace DolphinFacebook
{
    public class Display : IDisplay
    {
        public void DisplayWallPost(string wallPost) => Console.WriteLine("The post is : {0}", wallPost);


    }
}
