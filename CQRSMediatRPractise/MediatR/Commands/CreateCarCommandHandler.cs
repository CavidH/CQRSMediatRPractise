// Cavid Haciyev
// 2022/05/07   20:45

using System;
using System.Threading;
using System.Threading.Tasks;
using CQRSMediatRPractise.DAL;
using CQRSMediatRPractise.Models;
using MediatR;

namespace CQRSMediatRPractise.MediatR.Commands
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Guid>
    {
        private readonly AppDbContext _context;
        public CreateCarCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            await _context.Cars.AddAsync(new Car
            {
                Name = request.Name,
                HP = request.HP,
                Weight = request.HP
            });
            await _context.SaveChangesAsync();
            return Guid.NewGuid();
        }
    }
}