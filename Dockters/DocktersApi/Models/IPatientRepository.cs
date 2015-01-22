using System;
using System.Collections.Generic;
using WebAPI.Models;

namespace DocktersApi.Models
{
    public interface IPatientRepository
    {
        IEnumerable<PatientDataItem> AllItems { get; }
        void Add(PatientDataItem item);
        PatientDataItem GetById(int id);
        bool TryDelete(int id);
    }
}