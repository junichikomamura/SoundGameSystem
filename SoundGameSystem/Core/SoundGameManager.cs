using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    /// <summary>
    /// 1曲分のプレイ進行を行う
    /// </summary>
    public partial class SoundGameManager
    {
        public ISoundGameContext Context { get; }
        public SoundGameSequencer Sequencer { get; }

        public SoundGameManager(ISoundGameContext context)
        {
            Context = context;
            Sequencer = new SoundGameSequencer(context);
        }

        public void Update()
        {
            this.Sequencer.Update();
        }
    }
}
