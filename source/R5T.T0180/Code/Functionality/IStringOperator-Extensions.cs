using System;

using R5T.T0132;


namespace R5T.T0180.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IDirectoryName ToDirectoryName(string value)
        {
            var output = new DirectoryName(value);
            return output;
        }

        public IDirectoryPath ToDirectoryPath(string value)
        {
            var output = new DirectoryPath(value);
            return output;
        }

        public IFileExtension ToFileExtension(string value)
        {
            var output = new FileExtension(value);
            return output;
        }

        public IFileName ToFileName(string value)
        {
            var output = new FileName(value);
            return output;
        }

        public IFileNameStem ToFileNameStem(string value)
        {
            var output = new FileNameStem(value);
            return output;
        }

        public IFilePath ToFilePath(string value)
        {
            var output = new FilePath(value);
            return output;
        }

        public IPath ToPath(string value)
        {
            var output = new Path(value);
            return output;
        }

        public IRelativeDirectoryPath ToRelativeDirectoryPath(string value)
        {
            var output = new RelativeDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="RelativeFilePath"/>
        public IRelativeFilePath ToRelativeFilePath(string value)
        {
            var output = new RelativeFilePath(value);
            return output;
        }

        public IRelativePath ToRelativePath(string value)
        {
            var output = new RelativePath(value);
            return output;
        }

        public IRootedDirectoryPath ToRootedDirectoryPath(string value)
        {
            var output = new RootedDirectoryPath(value);
            return output;
        }

        public IRootedFilePath ToRootedFilePath(string value)
        {
            var output = new RootedFilePath(value);
            return output;
        }

        public IRootedPath ToRootedPath(string value)
        {
            var output = new RootedPath(value);
            return output;
        }
    }
}
