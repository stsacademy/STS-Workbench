﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS.Workbench.HomeControls
{
    public partial class ServerInstancesControl : UserControl
    {
        List<Control> controlList;
        public ServerInstancesControl()
        {
            controlList = new List<Control>();
            InitializeComponent();
        }
    }
}
