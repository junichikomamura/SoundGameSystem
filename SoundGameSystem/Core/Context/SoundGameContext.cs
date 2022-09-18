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

        public int CurrentNoteIndexFrom { get; set; }

        public int CurrentNoteIndexTo { get; set; }

        public ISoundGameTimer Timer { get; }

        public SoundGameContext(
            IScoreData scoreData, 
            INoteContextFactory noteContextFactory,
            ISoundGameTimer timer
            )
        {
            this.ScoreData = scoreData;

            this.NoteContests = scoreData.NoteDatas
                .Select(x => noteContextFactory.Make(x))
                .ToArray();

            this.Timer = timer;
        }
    }
}
