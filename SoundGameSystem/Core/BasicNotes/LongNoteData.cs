using System;
using System.Collections.Generic;
using System.Text;
using SoundGameSystem.Core;

namespace SoundGameSystem.BasicNotes
{
    /// <summary>
    /// ロングノーツデータ
    /// </summary>
    public class LongNoteData<TLaneTypeEnum> : NoteData
    {
        public LongNoteData(
            int id,
            int beginTime,
            int endTime,
            int beginLaneType,
            int endLaneType
            )
            : base(id, beginTime, endTime, beginLaneType, endLaneType)
        {
        }
    }
}
