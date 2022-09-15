using System;
using System.Collections.Generic;
using System.Text;
using SoundGameSystem.Core;

namespace SoundGameSystem.BasicNotes
{
    /// <summary>
    /// 単押しノーツデータ
    /// </summary>
    public class SinglePushNoteData : NoteData
    {
        public SinglePushNoteData(int id, int beginTime, int beginLaneType)
            : base(id, beginTime, beginTime, beginLaneType, beginLaneType)
        {

        }
    }
}
