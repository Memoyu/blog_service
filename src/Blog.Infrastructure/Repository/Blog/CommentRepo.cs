﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Core.Domains.Entities.Blog;
using Blog.Core.Interface.IRepositories.Blog;
using Blog.Core.Security;
using Blog.Infrastructure.Repository.Base;
using FreeSql;

namespace Blog.Infrastructure.Repository.Blog
{
    public class CommentRepo : AuditBaseRepo<CommentEntity>, ICommentRepo
    {
        public CommentRepo(UnitOfWorkManager unitOfWorkManager, ICurrentUser currentUser) : base(unitOfWorkManager, currentUser)
        {
        }
    }
}
