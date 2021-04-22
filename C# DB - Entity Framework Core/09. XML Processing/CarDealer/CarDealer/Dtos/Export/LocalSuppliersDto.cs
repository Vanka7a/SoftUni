﻿using System.Xml.Serialization;

namespace CarDealer.Dtos.Export
{
    // typo in the exercise
    [XmlType("suplier")]
    public class LocalSuppliersDto
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("parts-count")]
        public int PartsCount { get; set; }
    }
}
