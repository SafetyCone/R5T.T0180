using System;

using R5T.T0178;


namespace R5T.T0180
{
    /// <summary>
    /// A relative path to a file.
    /// </summary>
    [StrongTypeMarker]
    public interface IRelativeFilePath : IStrongTypeMarker,
        IFilePath,
        IRelativePath
    {
    }
}
