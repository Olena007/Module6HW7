using ASP_hometask1.Entity;

namespace ASP_hometask1.Interfaces
{
    public interface IActions
    {
        int Create(Flora flora);

        Flora Read(int id);

        string Update(Flora flora);

        bool Delete(int id);
    }
}
