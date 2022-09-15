using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    /// <summary>
    /// 譜面データ
    /// </summary>
    public interface IScoreData
    {
        /// <summary>
        /// 譜面の難易度
        /// </summary>
        int Difficulty { get; }

        /// <summary>
        /// 曲名
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 全てのノーツデータ
        /// </summary>
        public INoteData[] NoteDatas { get; }
    }
}
