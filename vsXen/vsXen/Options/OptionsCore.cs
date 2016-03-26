﻿/*
The MIT License (MIT)

Copyright (c) 2015 Nukeation Studios.

Permission is hereby granted, free of charge, to any person obtaining a copy 
of this software and associated documentation files (the "Software"), to deal 
in the Software without restriction, including without limitation the rights 
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
copies of the Software, and to permit persons to whom the Software is 
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in 
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
IN THE SOFTWARE.

https://github.com/daxpandhi/vsXen

*/


using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using PropertyTools.DataAnnotations;
using CM = System.ComponentModel;

namespace vsXen.Options
{
    [Serializable]
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Global")]
    [SuppressMessage("ReSharper", "CollectionNeverUpdated.Global")]
    public sealed class OptionsCore
    {
        [CM.Category("Xen Coding")]
        [CM.DisplayName("Custom Shortcuts")]
        [CM.Description("Add custom shortcuts to augment the predefined list.")]
        [HeaderPlacement(HeaderPlacement.Above), Height(100)]
        public List<Shortcut> Shorts
        { get; set; } = new List<Shortcut>();


    }

    public class Shortcut
    {
        [CM.DisplayName("Shortcut")]
        public string Key
        { get; set; }
        [CM.DisplayName("Expanded")]
        public string Value
        { get; set; }
    }
}
