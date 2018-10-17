using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    interface IDoTricks
    {
        bool UnderstandsCommand { get; set; }

        string DoTrick();

    }
}
