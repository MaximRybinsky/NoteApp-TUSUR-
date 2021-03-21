﻿using System.Collections.Generic;
using System.Linq;

namespace NoteApp
{
    /// <summary>
    /// Хранит и сортирует список заметок
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Возвращает или задает список заметок
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        /// <summary>
        /// Возвращает или задает индекс последней просматреваемой заметки
        /// </summary>
        public int SelectedNoteIndex { get; set; } = -1;

        /// <summary>
        /// Сортирует список заметок по дате редактирования
        /// </summary>
        /// <param name="notes"></param>
        /// <returns>Отсортированный по дате редактирования список заметок</returns>
        public List<Note> SortNotes(List<Note> notes)
        {
            var sortedNotes = notes.OrderByDescending(note => note.Modified).ToList();
            return sortedNotes;
        }

        /// <summary>
        /// Сортирует список заметок по дате редактирования, 
        /// оставляя заметки конкретной категории
        /// </summary>
        /// <param name="notes"></param>
        /// <param name="category"></param>
        /// <returns>Отсортированный по дате редактирования 
        /// список заметок конкретной категории</returns>
        public List<Note> SortNotes(List<Note> notes, NoteCategory category)
        {
            var categoryNotes = notes.Where(note => note.Category == category).ToList();
            var sortedNotes = categoryNotes.OrderByDescending(note => note.Modified).ToList();
            return sortedNotes;
        }
    }
}
