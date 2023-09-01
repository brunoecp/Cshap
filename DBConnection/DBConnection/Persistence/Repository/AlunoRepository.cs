﻿using DBConnection.Models;
using Microsoft.EntityFrameworkCore;

namespace DBConnection.Persistence.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly OracleDbContext _dbContext;



        public AlunoRepository(OracleDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public Alunos GetById(int id)
        {
            return _dbContext.alunos.Find(id);
        }



        public IEnumerable<Alunos> GetAll()
        {
            return _dbContext.alunos.ToList();
        }



        public void Add(Alunos entity)
        {
            _dbContext.alunos.Add(entity);
            _dbContext.SaveChanges();
        }



        public void Update(Alunos entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }



        public void Delete(Alunos entity)
        {
            _dbContext.alunos.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void add(Alunos entity)
        {
            throw new NotImplementedException();
        }

        public void remove(Alunos entity)
        {
            throw new NotImplementedException();
        }

        public void update(Alunos entity)
        {
            throw new NotImplementedException();
        }
    }
}
