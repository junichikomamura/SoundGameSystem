using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SoundGameSystem.Core;
using System.Linq;

namespace SoundGameSystem.Unity
{
    /// <summary>
    /// Contextの情報をインスペクタで見るためのもの
    /// </summary>
    public class SGContextInspectorView : MonoBehaviour
    {
        [SerializeField]
        private int _currentNoteIndexFrom, _currentNoteIndexTo;

        [SerializeField]
        private NotesContainer[] _notesContexts;

        private ISoundGameContext _context;

        public void Bind(ISoundGameContext context)
        {
            _context = context;
            _notesContexts = context.NoteContests
                .Select(x => new NotesContainer(x.NoteData))
                .ToArray();
        }

        private void Update()
        {
            UpdateView();
        }

        private void UpdateView()
        {
            if (_context == null)
                return;

            _currentNoteIndexFrom = _context.CurrentNoteIndexFrom;
            _currentNoteIndexTo = _context.CurrentNoteIndexTo;
        }

        [Serializable]
        public class NotesContainer
        {
            [SerializeField]
            int _id;
            [SerializeField]
            int _beginTime;
            [SerializeField]
            int _endTime;
            [SerializeField]
            int _beginLaneType;
            [SerializeField]
            int _endLaneType;

            public NotesContainer(INoteData data)
            {
                _id = data.Id;
                _beginTime = data.BeginTime;
                _endTime = data.EndTime;
                _beginLaneType = data.BeginLaneType;
                _endLaneType = data.EndLaneType;
            }
        }

    }

}
