namespace SoftUniBlog.Models
{
    public class Equipment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public EquipmentType Type { get; set; }
    }
}