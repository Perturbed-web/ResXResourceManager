﻿namespace tomenglertde.ResXManager.Model
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using JetBrains.Annotations;

    /// <summary>
    /// Resource manager specific extension methods.
    /// </summary>
    public static class ResourceManagerExtensions
    {
        [NotNull]
        [ItemNotNull]
        public static IList<ProjectFile> GetAllSourceFiles([NotNull] this DirectoryInfo solutionFolder, [NotNull] IFileFilter fileFilter)
        {
            var solutionFolderLength = solutionFolder.FullName.Length + 1;

            var fileInfos = solutionFolder.EnumerateFiles("*.*", SearchOption.AllDirectories);

            var allProjectFiles = fileInfos
                .Select(fileInfo => new ProjectFile(fileInfo.FullName, solutionFolder.FullName, @"<unknown>", null))
                .Where(fileFilter.IncludeFile)
                .Where(file => file.IsResourceFile() || fileFilter.IsSourceFile(file))
                .ToArray();

            var fileNamesByDirectory = allProjectFiles.GroupBy(file => file.GetBaseDirectory()).ToArray();

            foreach (var directoryFiles in fileNamesByDirectory)
            {
                var directoryPath = directoryFiles?.Key;

                if (string.IsNullOrEmpty(directoryPath))
                    continue;

                var directory = new DirectoryInfo(directoryPath);
                var project = FindProject(directory, solutionFolder.FullName);

                var projectName = "<no project>";
                var uniqueProjectName = (string)null;

                if (project != null)
                {
                    projectName = Path.ChangeExtension(project.Name, null);

                    var fullProjectName = project.FullName;
                    if (fullProjectName.Length >= solutionFolderLength) // project found is in solution tree
                    {
                        uniqueProjectName = fullProjectName.Substring(solutionFolderLength);
                    }
                }

                foreach (var file in directoryFiles)
                {
                    file.ProjectName = projectName;
                    file.UniqueProjectName = uniqueProjectName;
                }
            }

            return allProjectFiles;
        }

        [CanBeNull]
        private static FileInfo FindProject([NotNull] DirectoryInfo directory, [NotNull] string solutionFolder)
        {
            while ((directory != null) && (directory.FullName.Length >= solutionFolder.Length))
            {
                var projectFiles = directory.EnumerateFiles(@"*.*proj", SearchOption.TopDirectoryOnly);

                var project = projectFiles.FirstOrDefault();
                if (project != null)
                {
                    return project;
                }

                directory = directory.Parent;
            }

            return null;
        }
    }
}
