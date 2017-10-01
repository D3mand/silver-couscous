using System.Threading.Tasks;

namespace External.Jacks
{
    public interface RepositoryJack<TEntity,in TKey> where TEntity: class
    {
        void Save(TEntity entity);

        void Remove(TKey key);

        TEntity Get(TKey key);
    }
}
