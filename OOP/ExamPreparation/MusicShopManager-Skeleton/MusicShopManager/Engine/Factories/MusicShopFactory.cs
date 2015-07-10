namespace MusicShop.Engine.Factories
{
   using MusicShop.Models;

    using MusicShopManager.Interfaces;
    using MusicShopManager.Interfaces.Engine;

    public class MusicShopFactory : IMusicShopFactory
    {
        public IMusicShop CreateMusicShop(string name)
        {
            return new MusicShop(name);
        }
    }
}
