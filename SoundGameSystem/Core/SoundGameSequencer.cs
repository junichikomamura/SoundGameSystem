using System;
using System.Collections.Generic;
using System.Text;

namespace SoundGameSystem.Core
{
    public class SoundGameSequencer
    {
        private readonly ISoundGameContext _context;

        private int _now;

        private int DisplayTimeFrom => _now - 500;
        private int DisplayTimeTo => _now + 1000;

        public SoundGameSequencer(ISoundGameContext context)
        {
            _context = context;
            UpdateTime(0, forceUpdate: true);
        }

        public void Update()
        {
            UpdateTime(_context.Timer.Now, forceUpdate: false);
        }

        private void UpdateTime(int now, bool forceUpdate)
        {
            if (now == _now && !forceUpdate)
                return;

            // 実際のゲームプレイでは時間が戻ることはないはずだが、Editorなどではあり得るかもしれない
            // その場合は0に一旦リセット
            if (now < _now)
            {
                _context.CurrentNoteIndexFrom = 0;
                _context.CurrentNoteIndexTo = 0;
            }

            _now = now;

            UpdateCurrentIndexFrom();
            UpdateCurrentIndexTo();       
        }

        /// <summary>
        /// 表示範囲内のIndexFromを更新
        /// </summary>
        private void UpdateCurrentIndexFrom()
        {
            // 最初のノーツの開始時間前の時間だったら0確定なのでここで終わり
            if (_now < _context.NoteContests[0].NoteData.BeginTime)
            {
                _context.CurrentNoteIndexFrom = 0;
                return;
            }

            int indexFromTmp = _context.CurrentNoteIndexFrom;

            // 表示ノーツFrom
            var notesFrom = _context.NoteContests[indexFromTmp];

            // 表示範囲内だったら終わり
            // 範囲外だったら範囲内のものが来るまで1つずつ進める

            while (true)
            {
                if (IsWithinTime(notesFrom))
                {
                    _context.CurrentNoteIndexFrom = indexFromTmp;
                    break;
                }
                else
                {
                    if (!TryGetNotesContext(++indexFromTmp, out notesFrom))
                        break;
                    continue;
                }
            }
        }

        /// <summary>
        /// 表示範囲内のIndexToを更新
        /// </summary>
        private void UpdateCurrentIndexTo()
        {
            int indexToTmp = _context.CurrentNoteIndexTo = _context.CurrentNoteIndexFrom; // Fromから初めて範囲内を探る

            // 表示ノーツTo
            var notesTo = _context.NoteContests[indexToTmp];

            // 最後の表示範囲内のノーツを探す
            while (true)
            {
                if (IsWithinTime(notesTo))
                {
                    _context.CurrentNoteIndexTo = indexToTmp;
                    if (!TryGetNotesContext(++indexToTmp, out notesTo))
                        break;
                    continue;
                }

                break;
            }
        }

        private bool TryGetNotesContext(int index, out INoteContext noteContext)
        {
            if (index < 0 || index >= _context.NoteContests.Length)
            {
                noteContext = null;
                return false;
            }
            noteContext = _context.NoteContests[index];
            return true;
        }

        private bool IsWithinTime(INoteContext note)
        {
            var result = 
                (note.NoteData.BeginTime >= DisplayTimeFrom && note.NoteData.BeginTime < DisplayTimeTo) || // Beginが範囲内
                (note.NoteData.EndTime >= DisplayTimeFrom && note.NoteData.EndTime < DisplayTimeTo) || // Endが範囲内
                (note.NoteData.BeginTime < DisplayTimeFrom && note.NoteData.EndTime > DisplayTimeTo) // 長過ぎる場合
                ;
            return result;
        }
    }
}
