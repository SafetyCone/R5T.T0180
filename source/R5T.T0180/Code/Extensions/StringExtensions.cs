using System;


namespace R5T.T0180.Extensions
{
    public static class StringExtensions
    {
        public static DirectoryName ToDirectoryName(this string value)
        {
            return Instances.StringOperator.ToDirectoryName(value);
        }

        public static DirectoryPath ToDirectoryPath(this string value)
        {
            var output = Instances.StringOperator.ToDirectoryPath(value);
            return output;
        }

        public static FileExtension ToFileExtension(this string value)
        {
            var output = Instances.StringOperator.ToFileExtension(value);
            return output;
        }

        public static FileName ToFileName(this string value)
        {
            var output = Instances.StringOperator.ToFileName(value);
            return output;
        }

        public static FileNameStem ToFileNameStem(this string value)
        {
            var output = Instances.StringOperator.ToFileNameStem(value);
            return output;
        }

        public static FilePath ToFilePath(this string value)
        {
            var output = Instances.StringOperator.ToFilePath(value);
            return output;
        }

        public static Path ToPath(this string value)
        {
            var output = Instances.StringOperator.ToPath(value);
            return output;
        }

        public static RelativeDirectoryPath ToRelativeDirectoryPath(this string value)
        {
            var output = Instances.StringOperator.ToRelativeDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="IStringOperator.ToRelativeFilePath(string)"/>
        public static RelativeFilePath ToRelativeFilePath(this string value)
        {
            var output = Instances.StringOperator.ToRelativeFilePath(value);
            return output;
        }

        public static RelativePath ToRelativePath(this string value)
        {
            var output = Instances.StringOperator.ToRelativePath(value);
            return output;
        }

        public static RootedDirectoryPath ToRootedDirectoryPath(this string value)
        {
            var output = Instances.StringOperator.ToRootedDirectoryPath(value);
            return output;
        }

        public static RootedFilePath ToRootedFilePath(this string value)
        {
            var output = Instances.StringOperator.ToRootedFilePath(value);
            return output;
        }

        public static RootedPath ToRootedPath(this string value)
        {
            var output = Instances.StringOperator.ToRootedPath(value);
            return output;
        }
    }
}
