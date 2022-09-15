using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoundGameSystem.Core
{
    public class SoundGameContext : ISoundGameContext
    {
        public IScoreData ScoreData { get; }

        public INoteContext[] NoteContests { get; }

        public SoundGameContext(
            IScoreData scoreData, 
            INoteContextFactory noteContextFactory
            )
        {
            this.ScoreData = scoreData;

            this.NoteContests = scoreData.NoteDatas
                .Select(x => noteContextFactory.Make(x))
                .ToArray();
        }
    }
}
