﻿using NET_Framwork48.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Framwork48.GlobalData
{
    public class GlobalData
    {
        public static GlobalData globalData = new GlobalData();

        //是否评估 Modularity
        public bool if_assess_modularity = true;

        //程序使用的模型
        Model model_uncut = new Model();        //未经修剪的模型
        Model model_cut = new Model();          //经过修剪的模型
    }
}
