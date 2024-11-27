using Evently.Common.Domain;
using MediatR;

namespace Evently.Common.Application.Messaging;

public interface IBaseCommand;

public interface ICommand : IRequest<Result>, IBaseCommand;

public interface ICommand<T> : IRequest<Result<T>>, IBaseCommand;



