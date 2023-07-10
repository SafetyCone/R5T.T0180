using System;

using R5T.T0178;


namespace R5T.T0180
{
    /// <summary>
    /// Establishes that file paths are assumed to be rooted by default.
    /// (Quality-of-life name for <see cref="IRootedFilePath"/>.)
    /// <para><inheritdoc cref="IRootedFilePath" path="/summary"/></para>
    /// </summary>
    [StrongTypeMarker]
    public interface IFilePath : IStrongTypeMarker,
        IRootedFilePath
    {
    }
}
