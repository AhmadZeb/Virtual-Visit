﻿namespace VirtualVisit.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IContactRepository Contacts { get; }
    }
}
