﻿namespace EFRelationships.model
{
    public class Blog
    {
        public int Id { get; set; }
        public string ? Title { get; set; }
        public ICollection<Post>? Posts { get; set; }
    }
}
