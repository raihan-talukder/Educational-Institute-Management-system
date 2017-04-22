using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using erp.Entities.Bases;
using Newtonsoft.Json;

namespace Erp.Entities.Bases
{
    public abstract class BaseEntityByNo : BaseEntity, INotifyPropertyChanged
    {
        private int _entityNo;

        public int EntityNo
        {
            get { return _entityNo; }
            set
            {
                _entityNo = value;
                OnPropertyChanged("EntityNo");
            }
        }
    }
}   