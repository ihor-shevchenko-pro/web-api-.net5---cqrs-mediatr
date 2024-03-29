﻿using MediatR;
using System;

namespace Notes.Application.CQRS.Note.Commands.CreateNote
{
    public class CreateNoteCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }
}
