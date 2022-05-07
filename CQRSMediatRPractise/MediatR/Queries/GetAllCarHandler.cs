// Cavid Haciyev
// 2022/05/07   20:36

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CQRSMediatRPractise.DAL;
using CQRSMediatRPractise.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediatRPractise.MediatR.Queries
{
    public class GetAllCarHandler : IRequestHandler<GetAllCarQuery, List<Car>>
    {
        private readonly AppDbContext _context;
        public GetAllCarHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Car>> Handle(GetAllCarQuery request, CancellationToken cancellationToken)
        {
            return await _context.Cars.ToListAsync();
        }
    }
}