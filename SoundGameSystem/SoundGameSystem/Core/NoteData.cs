using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    /// <summary>
    /// ノーツデータの基底クラス
    /// </summary>
    public abstract class NoteData<TLaneType> : INoteData<TLaneType>
        where TLaneType : Enum        
    {
        public int Id { get; }

        public int BeginTime { get; }

        public int EndTime { get; }

        public TLaneType BeginLaneType { get; }

        public TLaneType EndLaneType { get; }

        public NoteData(
            int id,
            int beginTime,
            int endTime,
            TLaneType beginLaneType,
            TLaneType endLaneType
            )
        {
            this.Id = id;
            this.BeginTime = beginTime;
            this.EndTime = endTime;
            this.BeginLaneType = beginLaneType;
            this.EndLaneType = endLaneType;
        }
    }

}
