﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataWorksApp
{
    public class Node
    {
        public string Name {  get; set; }
        public ObservableCollection<Node> Nodes { get; set; } = new(); 
    }
}
