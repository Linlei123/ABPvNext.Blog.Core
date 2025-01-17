﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bcvp.Blog.Core.BlogCore.Files
{
    public class RawFileDto
    {
        public byte[] Bytes { get; set; }

        public bool IsFileEmpty => Bytes == null || Bytes.Length == 0;

        public RawFileDto()
        {

        }

        public static RawFileDto EmptyResult()
        {
            return new RawFileDto() { Bytes = new byte[0] };
        }
    }
}
