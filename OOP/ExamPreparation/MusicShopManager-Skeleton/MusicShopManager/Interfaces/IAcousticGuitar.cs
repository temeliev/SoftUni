namespace MusicShopManager.Interfaces
{
    using MusicShop.Models;

    public interface IAcousticGuitar : IGuitar
    {
        bool CaseIncluded { get; }

        StringMaterialType StringMaterial { get; }
    }
}
