using System;
using System.Collections.Generic;
using System.Text;

namespace WAD.DAL._7607.Repositories
{
    public class BaseRep
    {
        protected readonly SocialsCafeDbContext _dbContext;

        protected BaseRep(SocialsCafeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
