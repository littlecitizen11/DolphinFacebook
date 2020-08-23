using MamaFacebook.Abstract;
using System;

namespace DolphinFacebook
{
    class DolphinsFacebookClient : IFacebookClient
    {
        public event Action<string> NewWallPost;
        private IDisplay _displayer;


        public DolphinsFacebookClient(IDisplay displayer)
        {
            _displayer = displayer;
        }
        public void Subscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost += _displayer.DisplayWallPost;
        }

        public void Unsubscribe(IFacebookClient publisher)
        {
            publisher.NewWallPost -= _displayer.DisplayWallPost;
        }

        public void WriteNewWallPost(string wallPost)
        {
            NewWallPost?.Invoke(wallPost);
        }

    }
}
