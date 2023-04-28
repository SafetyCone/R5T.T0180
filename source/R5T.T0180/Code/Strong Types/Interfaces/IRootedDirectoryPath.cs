using System;

using R5T.T0178;


namespace R5T.T0180
{
    /// <summary>
    /// Strongly-types a string as a rooted directory path.
    /// (For relative directory paths, see <see cref="IRelativeDirectoryPath"/>.)
    /// </summary>
    [StrongTypeMarker]
    public interface IRootedDirectoryPath : IStrongTypeMarker,
        N000.IDirectoryPath,
        IRootedPath
    {
    }
}
