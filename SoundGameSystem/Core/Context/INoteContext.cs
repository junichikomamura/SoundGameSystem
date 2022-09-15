using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    /// <summary>
    /// ノーツコンテキスト
    /// </summary>
    public interface INoteContext
    {
        public INoteData NoteData { get; }
    }
}
