﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_World_Manager.Models
{
    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
