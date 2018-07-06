using System;
using System.Collections.Generic;
using System.Linq;
using DataStructuresAndLINQ;
using static DataStructuresAndLINQ.Queries;

namespace AspNetMvcCore.Services
{
    public class QueriesService
    {
        public List<Tuple<int, int>> NumberOfCommentsPost(int userId)
            => NumberOfCommentsUnderPosts(userId);

        public List<IGrouping<int, Comment>> CommentsListPost(int userId)
            =>CommentsListUnderPosts(userId);
        
        public List<Todo> TodoListDone(int userId) => TodosListDone(userId);
        
        public List<User> UserList() => UsersList();
        
        public (Post p, Comment l, Comment c, int n) StructurePostService(int postId)
        {
            return StructurePost(postId);
        }

        public void StructureUserService(int userId)
        {
            StructureUser(userId);
            return ;
        }
    }
}
