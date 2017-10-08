using Engine.Entities;
using System.Threading.Tasks;

namespace External.Jacks
{
    public interface RepositoryJack<TEntity,in TKey> where TEntity: class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Remove(TKey key);
        TEntity Get(TKey key);
    }
}
