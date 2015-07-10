﻿namespace MusicShopManager.Interfaces.Engine
{
    using MusicShop.Models;

    public interface IArticleFactory
    {
        IMicrophone CreateMirophone(string make, string model, decimal price, bool hasCable);

        IDrums CreateDrums(string make, string model, decimal price, string color, int width, int height);

        IElectricGuitar CreateElectricGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, int numberOfAdapters, int numberOfFrets);

        IAcousticGuitar CreateAcousticGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, bool caseIncluded, StringMaterialType stringMaterial);

        IBassGuitar CreateBassGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood);
    }
}
