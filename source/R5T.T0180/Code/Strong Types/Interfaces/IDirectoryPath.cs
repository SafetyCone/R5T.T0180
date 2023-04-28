using System;

using R5T.T0178;


namespace R5T.T0180
{
    /// <summary>
    /// Establishes that directory paths are assumed to be rooted by default.
    /// (Quality-of-life name for <see cref="IRootedDirectoryPath"/>.)
    /// <para><inheritdoc cref="IRootedDirectoryPath" path="/summary"/></para>
    /// </summary>
    [StrongTypeMarker]
    public interface IDirectoryPath : IStrongTypeMarker,
        IRootedDirectoryPath
    {
    }
}
