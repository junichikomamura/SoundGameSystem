using System;
using System.Collections.Generic;
using System.Text;
using SoundGameSystem.Core;

namespace SoundGameSystem.BasicNotes
{
    /// <summary>
    /// 単押しノーツデータ
    /// </summary>
    public class SinglePushNoteData<TLaneType> : NoteData<TLaneType>
        where TLaneType : Enum
    {
        public SinglePushNoteData(int id, int beginTime, TLaneType beginLaneType)
            : base(id, beginTime, beginTime, beginLaneType, beginLaneType)
        {

        }
    }
}
