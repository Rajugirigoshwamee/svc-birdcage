namespace svc.birdcage.hawk.Commands;

public interface ICommandHandler<TCommand, TResponse>
{
    Task<TResponse> Handle(TCommand command);
}
