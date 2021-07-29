
using PlayerMarketPlace.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerMarketPlace.Abstract
{
    interface IGamesService
    {
        void Add(Games games);
        void Delete(Games games);
        void Update(Games games);

    }
}