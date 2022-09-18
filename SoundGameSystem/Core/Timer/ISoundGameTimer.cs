namespace SoundGameSystem.Core
{
    public interface ISoundGameTimer
    {
        /// <summary>
        /// 現在の曲の時間（ミリ秒）
        /// </summary>
        int Now { get; }
    }
}
