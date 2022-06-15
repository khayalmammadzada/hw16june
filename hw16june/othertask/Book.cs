﻿using System;
namespace othertask
{
    public class Book : Product
    {

        public string Author;
        public string Genre;
        public override string GetInfo()
        {
            return $"Name: {Name} - Author: {Author} - Genre: {Genre} - Price: {Price}";
        }
    }
}
