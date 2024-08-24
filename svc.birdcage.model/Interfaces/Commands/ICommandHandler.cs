namespace svc.birdcage.model.Commands;

public interface ICommandHandler<TCommand, TResponse>
{
    Task<TResponse> Handle(TCommand command);
}
