using System;

using R5T.T0178;


namespace R5T.T0180.N000
{
    /// <summary>
    /// Strongly types a string as the path of a file, either rooted (<see cref="IRootedFilePath"/>) or relative (<see cref="IRelativeFilePath"/>).
    /// </summary>
    [StrongTypeMarker]
    public interface IFilePath : IStrongTypeMarker,
        IPath
    {
    }
}
