using System.Collections.Generic;
using Org.BouncyCastle.Asn1.Cms;
using TimeFutebol.Model;

namespace TimeFutebol.Repositories
{
    public class TimeRepository : ITimeRepository
    {
        public TimeRepository BuscaTimeId()
        {
            throw new System.NotImplementedException();
        }

        public void InserirTime()
        {
            var validator = new TimeValidator();
            var result = validator.validate(ListarTimes);
            if (result.IsValid)
                else
                        throw new Exception(result.Erros.FirstOrDefault().ToString());
        }

        public IList<TimeRepository> ListarTimes()
        {
            throw new System.NotImplementedException();
        }
    }

    internal class TimeValidator
    {
        public TimeValidator()
        {
        }

        internal object validate(object timeFutebol)
        {
            throw new System.NotImplementedException();
        }

        internal object validate(System.Func<IList<TimeRepository>> listarTimes)
        {
            throw new System.NotImplementedException();
        }
    }
}