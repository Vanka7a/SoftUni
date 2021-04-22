﻿using System.Xml.Serialization;

namespace ProductShop.Dtos.Export.UsersWithProducts
{
    [XmlType("Product")]
    public class UserProductDto
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }
    }
}
