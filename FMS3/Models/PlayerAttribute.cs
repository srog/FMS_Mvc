using System;
using System.ComponentModel.DataAnnotations;
using FMS3.Enums;

namespace FMS3.Models
{
    public class PlayerAttribute
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int AttributeId { get; set; }
        [Display(Name = "Rating")]
        public int AttributeValue { get; set; }
        [Display(Name = "Attribute")]
        public string AttributeName => Enum.GetName(typeof(PlayerAttributeEnum), AttributeId);
    }
}