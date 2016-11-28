using System.Collections.Generic;

namespace SoftUniBlog.Models
{
    public class EquipmentType
    {
        public EquipmentType()
        {
            this.Equipments = new List<Equipment>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}