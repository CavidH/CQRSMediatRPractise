// Cavid Haciyev
// 2022/05/07   20:42

using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace CQRSMediatRPractise.MediatR.Commands
{
    public class CreateCarCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double HP { get; set; }

        
    }

}