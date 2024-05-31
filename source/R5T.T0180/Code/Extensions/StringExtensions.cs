using System;


namespace R5T.T0180.Extensions
{
    public static class StringExtensions
    {
        public static IDirectoryName ToDirectoryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToDirectoryName(value);
        }

        public static IDirectoryPath ToDirectoryPath(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToDirectoryPath(value);
            return output;
        }

        public static IFileName ToFileName(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToFileName(value);
            return output;
        }

        public static IFileNameStem ToFileNameStem(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToFileNameStem(value);
            return output;
        }

        public static IFilePath ToFilePath(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToFilePath(value);
            return output;
        }

        public static IPath ToPath(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToPath(value);
            return output;
        }

        public static IRelativeDirectoryPath ToRelativeDirectoryPath(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToRelativeDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IStringOperator.ToRelativeFilePath(string)"/>
        public static IRelativeFilePath ToRelativeFilePath(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToRelativeFilePath(value);
            return output;
        }

        public static IRelativePath ToRelativePath(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToRelativePath(value);
            return output;
        }

        public static IRootedDirectoryPath ToRootedDirectoryPath(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToRootedDirectoryPath(value);
            return output;
        }

        public static IRootedFilePath ToRootedFilePath(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToRootedFilePath(value);
            return output;
        }

        public static IRootedPath ToRootedPath(this string value)
        {
            var output = Instances.StringOperator_Extensions.ToRootedPath(value);
            return output;
        }
    }
}
