using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Models;

namespace DocktersApi.Models
{
    public class PatientRepository : IPatientRepository
    {
        readonly List<PatientDataItem> _items = new List<PatientDataItem>();

        public PatientRepository()
        {
            _items.Add(new PatientDataItem
            {
                Id = 1,
                Name = "Jan",
                Age = 30,
                Measurements = new List<Measurement> {
                    new Measurement {Temperature = 37, Diastole =70, Systole =120,  Timestamp = DateTime.Now },
                    new Measurement {Temperature = 36, Diastole =75, Systole =120,  Timestamp = DateTime.Now },
                    new Measurement {Temperature = 38, Diastole =100, Systole =160,  Timestamp = DateTime.Now },
                    new Measurement {Temperature = 37, Diastole =110, Systole =150,  Timestamp = DateTime.Now },
                    new Measurement {Temperature = 39, Diastole =80, Systole =120,  Timestamp = DateTime.Now },
                    new Measurement {Temperature = 40, Diastole =75, Systole =100,  Timestamp = DateTime.Now },
                    new Measurement {Temperature = 38, Diastole =60, Systole =100,  Timestamp = DateTime.Now },
                    new Measurement {Temperature = 36, Diastole =100, Systole =180,  Timestamp = DateTime.Now },
                }
            });
        }

        public IEnumerable<PatientDataItem> AllItems
        {
            get
            {
                return _items;
            }
        }

        public PatientDataItem GetById(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public void Add(PatientDataItem item)
        {
            item.Id = 1 + _items.Max(x => (int?)x.Id) ?? 0;
            _items.Add(item);
        }

        public bool TryDelete(int id)
        {
            var item = GetById(id);
            if (item == null)
            {
                return false;
            }
            _items.Remove(item);
            return true;
        }
    }

}