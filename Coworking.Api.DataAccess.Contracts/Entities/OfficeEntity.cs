﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Coworking.Api.DataAccess.Contracts.Entities
{
    public class OfficeEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public bool Active { get; set; }
        public int IdAdmin { get; set; }
        public bool HasIndividualWorkSpaces { get; set; }
        public int NumberWorkSpace { get; set; }
        public decimal PriceWorkSpaceDaily { get; set; }
        public decimal PriceWorkSpaceMonthly { get; set; }
        
        public virtual AdminEntity Admin { get; set; }

        public virtual ICollection<Offices2RoomsEntity> Office2Room { get; set; }

        public virtual BookingEntity Booking { get; set; }

    }
}
