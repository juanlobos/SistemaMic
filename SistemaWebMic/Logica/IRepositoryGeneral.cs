using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaWebMic.Logica
{
    public interface IRepositoryGeneral
    {
        //metodo para agregar un registro
        Task Add<TEntity>(TEntity obj) where TEntity : class;
        //metodo para buscar por la id
        Task<TEntity> GetById<TEntity>(object id) where TEntity : class;
        //metodo para listar todos los registros de una tabla
        Task<List<TEntity>> GetAll<TEntity>() where TEntity : class;
        ///metodo para eliminar un objeto
        Task Remove<TEntity>(TEntity obj) where TEntity : class;
        //metodo para actualizar un objeto
        Task Update<TEntity>(TEntity obj, object key) where TEntity : class;
        //metodo para seleccionar el primer elemento de acuerdo a las condiciones de una tabla
        Task<TEntity> First<TEntity>(Expression<Func<TEntity, bool>> predicate) where TEntity : class;

        //metodo para filtrar por las condiciones que le pasemos y obtener una lista
        Task<List<TEntity>> GetList<TEntity>(Expression<System.Func<TEntity, bool>> predicate) where TEntity : class;
        //obtener el ultimo registro de una tabla
        TEntity Last<TEntity>() where TEntity : class;
    }
}