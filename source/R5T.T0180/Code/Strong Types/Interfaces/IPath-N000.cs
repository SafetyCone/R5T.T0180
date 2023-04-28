using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0180.N000
{
    /// <summary>
    /// Strongly types a string as a path that may be either rooted (<see cref="IRootedPath"/>) or relative (<see cref="IRelativePath"/>).
    /// </summary>
    [StrongTypeMarker]
    public interface IPath : IStrongTypeMarker,
        ITyped<string>
    {
    }
}
