using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    /// <summary>
    /// ノーツデータの基底クラス
    /// </summary>
    public abstract class NoteData : INoteData        
    {
        public int Id { get; }

        public int BeginTime { get; }

        public int EndTime { get; }

        public int BeginLaneType { get; }

        public int EndLaneType { get; }

        public NoteData(
            int id,
            int beginTime,
            int endTime,
            int beginLaneType,
            int endLaneType
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
