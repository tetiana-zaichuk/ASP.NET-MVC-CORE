using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataStructuresAndLINQ;
//using AspNetMvcCore.Models;
using static DataStructuresAndLINQ.Queries;

namespace AspNetMvcCore.Services
{
    public class QueriesService
    {
        public List<Tuple<int, int>> NumberOfCommentsPost(int userId)
            => NumberOfCommentsUnderPosts(userId);

        public List<IGrouping<int, Comment>> CommentsListPost(int userId)
            => CommentsListUnderPosts(userId);

        public List<Models.Todo> TodoListDone(int userId) => Mapper.Map<List<Todo>, List<Models.Todo>>(TodosListDone(userId));

        public List<Models.User> UserTodoList() => Mapper.Map<List<User>, List<Models.User>>(UsersList());

        public (Models.User, Models.Post, int?, int?, Models.Post, Models.Post) StructureUserService(int userId)
            => Mapper.Map<(User, Post, int?, int?, Post, Post), (Models.User, Models.Post, int?, int?, Models.Post, Models.Post)>(StructureUser(userId));

        public (Models.Post, Models.Comment, Models.Comment, int) StructurePostService(int postId)
            => Mapper.Map<(Post, Comment, Comment, int), (Models.Post, Models.Comment, Models.Comment, int)>(StructurePost(postId));
    }
}
