using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    /// <summary>
    /// 1曲のゲームプレインコンテキスト
    /// </summary>
    public interface ISoundGameContext
    {
        IScoreData ScoreData { get; }

        INoteContext[] NoteContests { get; }
    }
}
