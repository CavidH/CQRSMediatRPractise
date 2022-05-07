// Cavid Haciyev
// 2022/05/07   20:34

using System.Collections.Generic;
using CQRSMediatRPractise.DAL;
using CQRSMediatRPractise.Models;
using MediatR;

namespace CQRSMediatRPractise.MediatR.Queries
{
    public class GetAllCarQuery : IRequest<List<Car>>
    {
      
    }
}