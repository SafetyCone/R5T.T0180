using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0180
{
    /// <inheritdoc cref="IRelativeFilePath"/>
    [StrongTypeImplementationMarker]
    public class RelativeFilePath : TypedBase<string>, IStrongTypeImplementationMarker,
        IRelativeFilePath
    {
        public RelativeFilePath(string value)
            : base(value)
        {
        }
    }
}
