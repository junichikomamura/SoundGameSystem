using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    /// <summary>
    /// ノーツコンテキスト
    /// </summary>
    public class NoteContext : INoteContext
    {
        public INoteData NoteData { get; }

        public NoteContext(INoteData noteData)
        {
            this.NoteData = noteData;
        }
    }
}
