using System;
using System.Collections.Generic;
using System.Text;
using SoundGameSystem.Core;

namespace SoundGameSystem.BasicNotes
{
    /// <summary>
    /// 単押しノーツデータ
    /// </summary>
    public class SinglePushNoteData<TLaneTypeEnum> : NoteData<TLaneTypeEnum>
        where TLaneTypeEnum : Enum
    {
        public SinglePushNoteData(int id, int beginTime, TLaneTypeEnum beginLaneType)
            : base(id, beginTime, beginTime, beginLaneType, beginLaneType)
        {

        }
    }
}
