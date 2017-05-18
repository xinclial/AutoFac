using FB.CMS.IRepository.IRepository;
using FB.CMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB.CMS.Repository.Repository
{
    public partial class t_Case_Main_Repositoy : BaseRepository<t_Case_Main>, I_t_Case_Main_Repositoy
    {

        public t_Case_Main_Repositoy(DataModelContext dbContext)
            : base(dbContext)
        { }
    }
}
