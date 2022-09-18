namespace SoundGameSystem.Core
{
    /// <summary>
    /// 1曲のゲームプレインコンテキスト
    /// </summary>
    public interface ISoundGameContext
    {
        IScoreData ScoreData { get; }

        INoteContext[] NoteContests { get; }

        public int CurrentNoteIndexFrom { get; set; }

        public int CurrentNoteIndexTo { get; set; }

        ISoundGameTimer Timer { get; }
    }
}
