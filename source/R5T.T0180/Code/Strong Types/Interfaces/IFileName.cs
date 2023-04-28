using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0180
{
    /// <summary>
    /// Strongly-types a string as a file name.
    /// </summary>
    [StrongTypeMarker]
    public interface IFileName : ITyped<string>, IStrongTypeMarker
    {
    }
}
