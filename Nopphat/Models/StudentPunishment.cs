using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nopphat.Models
{
    public class StudentPunishment
    {
        public enum PubnishmentType
        {
            PAY = 1, PUSH = 0
        }
        public string RollNumber { get; set; }

        public int PunishmentTypeId { get; set; }

        public double Value { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}