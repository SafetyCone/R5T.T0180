﻿using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0180
{
    /// <inheritdoc cref="IPath"/>
    [StrongTypeImplementationMarker]
    public class RootedFilePath : TypedBase<string>, IStrongTypeImplementationMarker,
        IRootedFilePath
    {
        public RootedFilePath(string value)
            : base(value)
        {
        }
    }
}
