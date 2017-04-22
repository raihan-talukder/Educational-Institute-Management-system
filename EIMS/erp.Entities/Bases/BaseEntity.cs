using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace erp.Entities.Bases
{
    public abstract class BaseEntity : INotifyPropertyChanged
    {
        [Key]
        public virtual Guid ID { get; set; }

        [JsonIgnore]
        public bool IsDeleted { get; set; }

        [JsonIgnore]
        public virtual DateTime LastChanged { get; set; }

        [JsonIgnore]
        public virtual Guid LastChangedBy { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}