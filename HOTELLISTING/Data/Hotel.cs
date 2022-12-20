﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace HOTELLISTING.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        [NotNull]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Rating { get; set; }
        [ForeignKey(nameof(CountryId))]
        public int CountryId { get; set; }
        public Country Country { get; set; }


    }
}
