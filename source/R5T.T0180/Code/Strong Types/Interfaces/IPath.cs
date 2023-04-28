using System;

using R5T.T0178;


namespace R5T.T0180
{
    /// <summary>
    /// Establishes that paths are assumed to be rooted by default.
    /// (Quality-of-life name for <see cref="IRootedPath"/>.)
    /// <para><inheritdoc cref="IRootedPath" path="/summary"/></para>
    /// </summary>
    [StrongTypeMarker]
    public interface IPath : IStrongTypeMarker,
        IRootedPath
    {
    }
}
