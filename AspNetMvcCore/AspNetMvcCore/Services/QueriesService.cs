using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DataStructuresAndLINQ.Queries;

namespace AspNetMvcCore.Services
{
    public class QueriesService
    {
        public List<Tuple<int, int>> NumberOfCommentsPost(int userId)
        {
            return NumberOfCommentsUnderPosts(userId);
        }
    }
}
