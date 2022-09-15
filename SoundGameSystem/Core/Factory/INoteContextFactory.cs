using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    public interface INoteContextFactory
    {
        public INoteContext Make(INoteData noteData);
    }
}
