﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SHex
{
    struct BytePositionInfo
    {
        public BytePositionInfo(long index, int characterPosition)
        {
            _index = index;
            _characterPosition = characterPosition;
        }

        public int CharacterPosition
        {
            get { return _characterPosition; }
        } int _characterPosition;

        public long Index
        {
            get { return _index; }
        } long _index;
    }
}
