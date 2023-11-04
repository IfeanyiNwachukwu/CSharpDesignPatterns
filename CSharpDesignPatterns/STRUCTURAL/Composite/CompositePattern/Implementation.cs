﻿namespace CompositePattern
{
    /// <summary>
    /// Component
    /// </summary>
    public abstract class FileSystemItem
    {
        public string Name { get; set; }

        public abstract long GetSize();

        public FileSystemItem(string name)
        {
            Name = name;
        }
    }
    /// <summary>
    /// Leaf
    /// </summary>
    public class FileY : FileSystemItem
    {
        private long _size;
        public FileY(string name, long size) : base(name)
        {
            _size = size;
        }

        public override long GetSize()
        {
            return _size;
        }
    }
    /// <summary>
    /// Composite
    /// </summary>
    public class DirectoryX : FileSystemItem
    {
        private List<FileSystemItem> _fileSystemItems = new List<FileSystemItem>();

        private long _size;
        public DirectoryX(string name, long size) : base(name)
        {
            _size = size;
        }

        public void Add(FileSystemItem itemToAdd)
        {
            _fileSystemItems.Add(itemToAdd);
        }

        public void Remove(FileSystemItem itemToRemove)
        {
            _fileSystemItems.Remove(itemToRemove);
        }

        public override long GetSize()
        {
            var treeSize = _size;
            foreach (var fileSystemItem in _fileSystemItems)
            {
                treeSize += fileSystemItem.GetSize();
            }
            return treeSize;
        }
    }
}
