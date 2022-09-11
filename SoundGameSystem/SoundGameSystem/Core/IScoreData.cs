using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    /// <summary>
    /// 譜面データ
    /// </summary>
    public interface IScoreData<TDifficultyEnum, TLaneTypeEnum> 
        where TDifficultyEnum : Enum
        where TLaneTypeEnum : Enum
    {
        /// <summary>
        /// 譜面の難易度
        /// </summary>
        TDifficultyEnum Difficulty { get; }

        /// <summary>
        /// 曲名
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 全てのノーツデータ
        /// </summary>
        public INoteData<TLaneTypeEnum>[] NotesDatas { get; }
    }
}
