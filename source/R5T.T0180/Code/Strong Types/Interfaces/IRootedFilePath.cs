using System;

using R5T.T0178;


namespace R5T.T0180
{
    /// <summary>
    /// Strongly-types a string as the rooted path of a file.
    /// (See <see cref="IRelativeFilePath"/> for a relative path of a file.)
    /// </summary>
    [StrongTypeMarker]
    public interface IRootedFilePath : IStrongTypeMarker,
        N000.IFilePath,
        IRootedPath
    {
    }
}
