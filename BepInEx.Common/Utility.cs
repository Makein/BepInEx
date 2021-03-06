﻿using System;
using System.IO;
using System.Linq;

namespace BepInEx.Common
{
    /// <summary>
    /// Generic helper properties and methods.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// The directory that the Koikatsu .exe is being run from.
        /// </summary>
        public static string ExecutingDirectory => Path.GetDirectoryName(Environment.CommandLine);

        /// <summary>
        /// The path that the plugins folder is located.
        /// </summary>
        public static string PluginsDirectory => Path.Combine(ExecutingDirectory, "BepInEx");

        /// <summary>
        /// Combines multiple paths together, as the specfic method is not availble in .NET 3.5.
        /// </summary>
        /// <param name="parts">The multiple paths to combine together.</param>
        /// <returns>A combined path.</returns>
        public static string CombinePaths(params string[] parts) => parts.Aggregate(Path.Combine);

        /// <summary>
        /// Converts a file path into a UnityEngine.WWW format.
        /// </summary>
        /// <param name="path">The file path to convert.</param>
        /// <returns>A converted file path.</returns>
        public static string ConvertToWWWFormat(string path)
        {
            return $"file://{path.Replace('\\', '/')}";
        }
    }
}
