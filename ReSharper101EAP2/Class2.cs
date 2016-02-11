﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedParameter.Global
// ReSharper disable UseNameofExpression

namespace CsharpFeatures
{
    public class Class2
    {

        // Rename refactoring

        /// <summary>
        /// Adds new package source to the list
        /// </summary>
        /// <param name="sourcePath">Package source path</param>
        /// <param name="name">Arbitrary identifier</param>
        public void AddSource(string sourcePath, string name)
        {
            if (sourcePath == null)
                throw new ArgumentNullException("sourcePath");
            if (name == null)
                throw new ArgumentNullException("name");




        }
    }
}
