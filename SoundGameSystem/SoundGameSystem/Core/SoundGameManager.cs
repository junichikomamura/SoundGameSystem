using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    /// <summary>
    /// 1曲分のプレイ進行を行う
    /// </summary>
    public partial class SoundGameManager
    {
        private readonly ISoundGameContext _context;

        public SoundGameManager(ISoundGameContext context)
        {
            _context = context;
        }
    }
}
