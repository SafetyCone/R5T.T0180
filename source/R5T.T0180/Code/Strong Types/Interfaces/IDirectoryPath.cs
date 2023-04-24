using System;

using R5T.T0178;


namespace R5T.T0180
{
    /// <summary>
    /// The strong-type for directory paths.
    /// </summary>
    [StrongTypeMarker]
    public interface IDirectoryPath : IStrongTypeMarker,
        IPath
    {
    }
}
