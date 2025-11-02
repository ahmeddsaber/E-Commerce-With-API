using APIGenerationProject.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIGenerationProject.GenericRepository
{
    public class GenericRepository<T> where T : class
    {
        private readonly ProjectContext _context;

        public GenericRepository(ProjectContext context)
        {
            _context = context;
        }

        // Get all with optional navigation properties
        public List<T> GetAll(string includeProperties = "")
        {
            IQueryable<T> query = _context.Set<T>();

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return query.ToList();
        }

        // Get one by id with optional navigation properties
        public T GetOne(int id, string includeProperties = "")
        {
            IQueryable<T> query = _context.Set<T>();

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            // EF.Property<int>(e, "Id") يستخدم لو معرفش property Id بشكل مباشر
            return query.FirstOrDefault(e => EF.Property<int>(e, "Id") == id);
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity, int id)
        {
            var existingEntity = _context.Set<T>().Find(id);
            if (existingEntity != null)
            {
                _context.Entry(existingEntity).CurrentValues.SetValues(entity);
            }
        }

        public void Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
