﻿using FilteredOutputWindowVSX.Interface;
using FilteredOutputWindowVSX.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilteredOutputWindowVSX.Models
{
   public class StringFilterContainer:NotifyBase
    {
        public Guid Id { get; set; }
        public StringFilterItem Filter { get; set; }
        private string _name;

        public string Name { get => _name; set { _name = value; NotifyPropertyChanged(); } }

        public StringFilterContainer ShallowCopy()
        {
            Id = Guid.NewGuid();
            return (StringFilterContainer)MemberwiseClone();
        }
    }
}
