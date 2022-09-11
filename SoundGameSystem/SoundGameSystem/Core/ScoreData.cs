using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    /// <summary>
    /// 譜面データ
    /// </summary>
    public class ScoreData<TDifficultyEnum, TLaneTypeEnum> : 
        IScoreData<TDifficultyEnum, TLaneTypeEnum>
        where TDifficultyEnum : Enum
        where TLaneTypeEnum : Enum
    {
        public TDifficultyEnum Difficulty { get; }

        public string Name { get; }

        public INoteData<TLaneTypeEnum>[] NotesDatas { get; }

        public ScoreData(
            TDifficultyEnum difficulty, 
            string name, 
            INoteData<TLaneTypeEnum>[] notesDatas
            )
        {
            this.Difficulty = difficulty;
            this.Name = name;
            this.NotesDatas = notesDatas;
        }
    }
}
