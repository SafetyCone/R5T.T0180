using System;

using R5T.T0178;


namespace R5T.T0180
{
    /// <summary>
    /// Strongly-types a string as a relative path to either a file (<see cref="IRelativeFilePath"/>) or a directory (<see cref="IRelativeDirectoryPath"/>).
    /// </summary>
    [StrongTypeMarker]
    public interface IRelativePath : IStrongTypeMarker,
        N000.IPath
    {
    }
}
