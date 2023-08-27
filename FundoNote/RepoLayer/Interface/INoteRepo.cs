﻿using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using RepoLayer.Enitities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RepoLayer.Interface
{
    public interface INoteRepo
    {
        public Task<NoteEntitiy> AddNote(NoteRegistrationModel note, long userId);
        public Task<List<NoteEntitiy>> GetAllNotes(long userId);
        public Task<NoteEntitiy> UpdateNote(NoteUpdateModel model, long userId);
        public Task<NoteEntitiy> DeleteNote(long noteId);
        public Task<NoteEntitiy> ArchieveNote(long noteId, long userId);
        public Task<NoteEntitiy> TrashNote(long noteId, long userId);
        public Task<NoteEntitiy> PinUnPin(long noteId, long userId);
        public Task<NoteEntitiy> ChangeColor(long noteId, int userId, string newColor);
    }
}
