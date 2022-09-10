using System;
using System.Collections.Generic;
using System.Text;
using SoundGameSystem.Core;

namespace SoundGameSystem.BasicNotes
{
    /// <summary>
    /// ロングノーツデータ
    /// </summary>
    public class LongNoteData<TLaneType> : NoteData<TLaneType> 
        where TLaneType : Enum
    {
        public LongNoteData(
            int id,
            int beginTime,
            int endTime,
            TLaneType beginLaneType,
            TLaneType endLaneType
            )
            : base(id, beginTime, endTime, beginLaneType, endLaneType)
        {
        }
    }
}
