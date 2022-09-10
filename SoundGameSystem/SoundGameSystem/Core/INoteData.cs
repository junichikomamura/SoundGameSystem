using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    /// <summary>
    /// ノーツ1つ分のデータ
    /// </summary>
    public interface INoteData<TLaneType> where TLaneType : Enum
    {
        /// <summary>
        /// ノーツ識別用のID
        /// </summary>
        int Id { get; }

        /// <summary>
        /// ノーツの開始時間（ミリ秒）
        /// </summary>
        int BeginTime { get; }

        /// <summary>
        /// ノーツの終了時間（ミリ秒）
        /// </summary>
        /// <remarks>
        /// ロングノーツ系でなければ<see cref="BeginTime"/>と同じ値になる
        /// </remarks>
        int EndTime { get; }

        /// <summary>
        /// ノーツ開始時のレーンタイプ
        /// </summary>
        TLaneType BeginLaneType { get; }

        /// <summary>
        /// ノーツ終了時のレーンタイプ
        /// </summary>
        /// <remarks>
        /// スマホのスライド等で終了時にレーンが変わっている場合に使用する
        /// 基本的には<see cref="BeginLaneType"/>と同じになる
        /// </remarks>
        TLaneType EndLaneType { get; }
    }
}
