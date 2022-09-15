using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    /// <summary>
    /// 譜面データ
    /// </summary>
    public class ScoreData : IScoreData
    {
        public int Difficulty { get; }

        public string Name { get; }

        public INoteData[] NoteDatas { get; }

        public ScoreData(
            int difficulty, 
            string name, 
            INoteData[] noteDatas
            )
        {
            this.Difficulty = difficulty;
            this.Name = name;
            this.NoteDatas = noteDatas;
        }
    }
}
