using System;

using R5T.T0178;


namespace R5T.T0180.N000
{
    /// <summary>
    /// Strongly-types a string a the path of a directory, either rooted (<see cref="IRootedDirectoryPath"/>) or relative (<see cref="IRelativeDirectoryPath"/>).
    /// </summary>
    [StrongTypeMarker]
    public interface IDirectoryPath : IStrongTypeMarker,
        IPath
    {
    }
}
