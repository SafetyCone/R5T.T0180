using System;

using R5T.T0132;


namespace R5T.T0180
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public DirectoryName ToDirectoryName(string value)
        {
            var output = new DirectoryName(value);
            return output;
        }

        public DirectoryPath ToDirectoryPath(string value)
        {
            var output = new DirectoryPath(value);
            return output;
        }

        public FileExtension ToFileExtension(string value)
        {
            var output = new FileExtension(value);
            return output;
        }

        public FileName ToFileName(string value)
        {
            var output = new FileName(value);
            return output;
        }

        public FileNameStem ToFileNameStem(string value)
        {
            var output = new FileNameStem(value);
            return output;
        }

        public FilePath ToFilePath(string value)
        {
            var output = new FilePath(value);
            return output;
        }

        public Path ToPath(string value)
        {
            var output = new Path(value);
            return output;
        }

        public RelativeDirectoryPath ToRelativeDirectoryPath(string value)
        {
            var output = new RelativeDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="RelativeFilePath"/>
        public RelativeFilePath ToRelativeFilePath(string value)
        {
            var output = new RelativeFilePath(value);
            return output;
        }

        public RelativePath ToRelativePath(string value)
        {
            var output = new RelativePath(value);
            return output;
        }

        public RootedDirectoryPath ToRootedDirectoryPath(string value)
        {
            var output = new RootedDirectoryPath(value);
            return output;
        }

        public RootedFilePath ToRootedFilePath(string value)
        {
            var output = new RootedFilePath(value);
            return output;
        }

        public RootedPath ToRootedPath(string value)
        {
            var output = new RootedPath(value);
            return output;
        }
    }
}
