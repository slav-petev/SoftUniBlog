﻿using System.Collections.Generic;
using System.IO;

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

        public static string NormalizeName(string name)
        {
            var illegalChars = Path.GetInvalidFileNameChars();

            var normalizedName = name;
            foreach (var character in illegalChars)
            {
                normalizedName = name.Replace(character, '-');
            }            

            return normalizedName;
        }
    }
}