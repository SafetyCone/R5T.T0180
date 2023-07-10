using System;

using R5T.T0178;


namespace R5T.T0180
{
    /// <summary>
    /// The strong-type for all rooted paths.
    /// </summary>
    [StrongTypeMarker]
    public interface IRelativeDirectoryPath : IStrongTypeMarker,
        N000.IDirectoryPath,
        IRelativePath
    {
    }
}
