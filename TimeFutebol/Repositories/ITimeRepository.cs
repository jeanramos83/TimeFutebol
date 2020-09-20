using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeFutebol.Repositories
{
    public interface ITimeRepository
    {
        public IList<TimeRepository> ListarTimes();
        public TimeRepository BuscaTimeId();
        public void InserirTime();

    }
}
