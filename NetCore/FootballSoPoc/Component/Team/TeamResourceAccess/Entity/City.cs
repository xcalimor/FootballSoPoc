using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeamResourceAccess.Entity
{
    public class City
    {
        public Guid CityId { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }

    }
}
