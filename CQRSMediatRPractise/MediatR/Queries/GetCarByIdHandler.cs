// Cavid Haciyev
// 2022/05/07   20:03

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRSMediatRPractise.DAL;
using CQRSMediatRPractise.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediatRPractise.MediatR.Queries
{
    public class GetCarByIdHandler : IRequestHandler<GetCarByIdQuery, Car>
    {
        private readonly AppDbContext _context;
        public GetCarByIdHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Car> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {

            return await _context.Cars.Where(p => p.Id == request.Id).FirstOrDefaultAsync();
            //get peoduct from repository

        }
    }
}