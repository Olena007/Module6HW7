using ASP_hometask1.Entity;
using ASP_hometask1.Interfaces;

namespace ASP_hometask1.Services
{
    public class InitialProvider : IActions
    {
        private IProvider _provider;

        public InitialProvider(IProvider provider)
        {
            _provider = provider;
        }

        public int Create(Flora flora)
        {
            _provider.Create(flora);
            return flora.id;
        }

        public bool Delete(int id)
        {
            _provider.Delete(id);
            return true;
        }

        public Flora Read(int id)
        {
            return _provider.Read(id);
        }

        public string  Update(Flora flora)
        {
            _provider.Update(flora);

            return flora.name;
        }
    }
}
