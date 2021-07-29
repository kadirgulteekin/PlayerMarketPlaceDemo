using PlayerMarketPlace.Abstract;
using PlayerMarketPlace.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerMarketPlace.Concrete
{
    public class BaseGameManager : IGamesService
    {

        public virtual void Add(Games games)
        {
            Console.WriteLine(games.GamesName + " oyunu ekledi.\n" + "Oyunun Fiyat: " + games.GamesPrice + " TL" + "\nOyunun Kategorisi" + games.GamesCategory);
        }

        public virtual void Delete(Games games)
        {
            Console.WriteLine(games.GamesName + " oyunu sistemden kaldırıldı!");
        }

        public virtual void Update(Games games)
        {
            Console.WriteLine(games.GamesName + " oyunu güncellendi!");
        }

    }
}