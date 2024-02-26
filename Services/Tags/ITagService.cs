﻿using OPC5_BlogApp.Data.Models;

namespace Services.Tags
{
    public interface ITagService
    {
        List<Tag> GetTags();

        Task AddTag(Tag tag);
    }
}
