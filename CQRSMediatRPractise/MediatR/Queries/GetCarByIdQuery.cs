// Cavid Haciyev
// 2022/05/07   19:55

 
using CQRSMediatRPractise.Models;
using MediatR;

namespace CQRSMediatRPractise.MediatR.Queries
{
    public class GetCarByIdQuery : IRequest<Car>
    {
        public int Id { get; set; }
    }
}