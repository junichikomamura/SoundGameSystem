using System;
using System.Collections.Generic;
using System.Text;
using SoundGameSystem.Core;

namespace SoundGameSystem.BasicNotes
{
    /// <summary>
    /// ロングノーツデータ
    /// </summary>
    public class LongNoteData<TLaneTypeEnum> : NoteData<TLaneTypeEnum> 
        where TLaneTypeEnum : Enum
    {
        public LongNoteData(
            int id,
            int beginTime,
            int endTime,
            TLaneTypeEnum beginLaneType,
            TLaneTypeEnum endLaneType
            )
            : base(id, beginTime, endTime, beginLaneType, endLaneType)
        {
        }
    }
}
