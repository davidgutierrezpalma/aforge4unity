﻿//
// Portability Class Library
//
// Copyright © Cureos AB, 2013
// info at cureos dot com
//

namespace System.IO
{
    public sealed class FileStream : MemoryStream
    {
        #region CONSTRUCTORS

        public FileStream(string path, FileMode mode)
        {
            throw new NotImplementedException();
        }

        public FileStream(string path, FileMode mode, FileAccess access, FileShare share)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}