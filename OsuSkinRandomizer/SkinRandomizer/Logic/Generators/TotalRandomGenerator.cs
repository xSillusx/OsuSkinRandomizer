﻿using SkinRandomizer.Interfaces;
using SkinRandomizer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SkinRandomizer.Logic.Generators
{
    public class TotalRandomGenerator : BaseGenerator
    {
        /// <summary>
        /// TotalRandomGenerator creates a playable skin, which sticks to a list of skinnable elements and searches for these, so they skin elements align
        /// </summary>
        public override void Generate()
        {
            string resultSkinDirectory = base.pathToOsuSkinFolder + @"\" + base.skinResultName + @"\";
            foreach (SkinnableFile file in base.relevantFiles) // go over the result skin list and copy everys file over
            {
                string sourcePath = base.pathToOsuSkinFolder + @"\" + file.skinName + @"\" + file.skinnableName + file.extension;
                string targetPath = resultSkinDirectory + file.skinnableName + file.extension;
                if (!System.IO.File.Exists(targetPath))
                {
                    System.IO.File.Copy(sourcePath, targetPath);
                }
            }
        }
    }
}
