using System;

using R5T.T0178;


namespace R5T.T0180
{
    /// <summary>
    /// Strongly-types a string as a rooted path, which could could be either a file (<see cref="IRootedFilePath"/>) or directory (<see cref="IRootedDirectoryPath"/>).
    /// </summary>
    [StrongTypeMarker]
    public interface IRootedPath : IStrongTypeMarker,
        N000.IPath
    {
    }
}
