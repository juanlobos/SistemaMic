using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaWebMic.Conexion;

namespace SistemaWebMic.Logica
{
    public class RepositoryGeneral : IRepositoryGeneral
    {
        private readonly ConexionContext _db;
        public RepositoryGeneral(ConexionContext db)
        {
            _db = db;
        }
        //metodo para agregar un registro
        public async Task Add<TEntity>(TEntity obj) where TEntity : class
        {
            await _db.Set<TEntity>().AddAsync(obj);
            await _db.SaveChangesAsync();
        }
        ///metodo para buscar un registro el primero
        public async Task<TEntity> First<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            return await _db.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }
        //metodo para listar todos los registros de una tabla
        public async Task<List<TEntity>> GetAll<TEntity>() where TEntity : class
        {
            return await _db.Set<TEntity>().ToListAsync();
        }
        //metodo para buscar por la id
        public async Task<TEntity> GetById<TEntity>(object id) where TEntity : class
        {
            return await _db.Set<TEntity>().FindAsync(id);
        }
        //metodo que trae una coleccion de acuerdo al predicado(condiciones) que le pasemos
        public async Task<List<TEntity>> GetList<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            return await _db.Set<TEntity>().Where(predicate).ToListAsync();
        }
        //obtener el ultimo registro de una tabla
        public TEntity Last<TEntity>() where TEntity : class
        {
            return _db.Set<TEntity>().ToList().LastOrDefault();
        }
        //metodo para eliminar un objeto
        public async Task Remove<TEntity>(TEntity obj) where TEntity : class
        {
            _db.Set<TEntity>().Remove(obj);
            await _db.SaveChangesAsync();
        }
        //metodo para actualizar un registro
        public async Task Update<TEntity>(TEntity obj, object key) where TEntity : class
        {
            var existing = await _db.Set<TEntity>().FindAsync(key);
            if (existing != null)
            {
                _db.Entry(existing).CurrentValues.SetValues(obj);
                await _db.SaveChangesAsync();
            }
        }
    }
}