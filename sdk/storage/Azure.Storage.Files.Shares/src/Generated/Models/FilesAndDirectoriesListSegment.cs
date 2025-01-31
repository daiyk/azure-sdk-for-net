// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> Abstract for entries that can be listed from Directory. </summary>
    internal partial class FilesAndDirectoriesListSegment
    {
        /// <summary> Initializes a new instance of FilesAndDirectoriesListSegment. </summary>
        /// <param name="directoryItems"></param>
        /// <param name="fileItems"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="directoryItems"/> or <paramref name="fileItems"/> is null. </exception>
        internal FilesAndDirectoriesListSegment(IEnumerable<DirectoryItem> directoryItems, IEnumerable<FileItem> fileItems)
        {
            if (directoryItems == null)
            {
                throw new ArgumentNullException(nameof(directoryItems));
            }
            if (fileItems == null)
            {
                throw new ArgumentNullException(nameof(fileItems));
            }

            DirectoryItems = directoryItems.ToList();
            FileItems = fileItems.ToList();
        }

        /// <summary> Initializes a new instance of FilesAndDirectoriesListSegment. </summary>
        /// <param name="directoryItems"></param>
        /// <param name="fileItems"></param>
        internal FilesAndDirectoriesListSegment(IReadOnlyList<DirectoryItem> directoryItems, IReadOnlyList<FileItem> fileItems)
        {
            DirectoryItems = directoryItems;
            FileItems = fileItems;
        }

        public IReadOnlyList<DirectoryItem> DirectoryItems { get; }
        public IReadOnlyList<FileItem> FileItems { get; }
    }
}
