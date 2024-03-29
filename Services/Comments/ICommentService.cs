﻿using OPC5_BlogApp.Data.Models;

namespace Services.Posts
{
    public interface ICommentService
    {
        Task AddComment(Comment comment);

        List<Comment> GetComments();

        Task<int> GetCommentsCount(int postId);
    }
}
