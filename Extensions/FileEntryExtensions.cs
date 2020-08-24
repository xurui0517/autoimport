using System;
using System.IO;
using System.Linq;
using BlazorInputFile;

namespace MappingsSquad.Extensions
{
    public static class FileEntryExtensions
    {
        public static bool IsAccepted(this IFileListEntry file)
        {
            var allowedExtensions = new[] { ".xsl", ".xlsx", ".csv" };
            var extension = Path.GetExtension(file.Name);
            return allowedExtensions.Contains(extension);
        }

        public static bool IsNotAccepted(this IFileListEntry file)
        {
            return !file.IsAccepted();
        }
    }
}
