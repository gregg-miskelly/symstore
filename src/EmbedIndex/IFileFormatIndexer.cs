﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmbedIndex
{
    public interface IFileFormatIndexer
    {
        string ComputeIndexKey(string path, Stream fileStream);
    }
}
