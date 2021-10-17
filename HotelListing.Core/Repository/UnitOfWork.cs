﻿using HotelListing.Core.IRepository;
using HotelListing.Data;
using System;
using System.Threading.Tasks;

namespace HotelListing.Core.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private readonly IGenericRepository<Country> _countries;
        private readonly IGenericRepository<Hotel> _hotels;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<Country> Countries => _countries ?? new GenericRepository<Country>(_context);

        public IGenericRepository<Hotel> Hotels => _hotels ?? new GenericRepository<Hotel>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}