using System;

using R5T.T0178;


namespace R5T.T0180
{
    /// <summary>
    /// Strongly-types a string as the relative path of a file.
    /// (For rooted file paths, see <see cref="IRootedFilePath"/>.)
    /// </summary>
    [StrongTypeMarker]
    public interface IRelativeFilePath : IStrongTypeMarker,
        N000.IFilePath,
        IRelativePath
    {
    }
}
