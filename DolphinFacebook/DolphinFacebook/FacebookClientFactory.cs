using MamaFacebook.Abstract;


namespace DolphinFacebook
{
    public class FacebookClientFactory : IFacebookClientFactory
    {
        public IFacebookClient CreateClient(IDisplay display)
        {
            return new DolphinsFacebookClient(display);
        }
    }
}
