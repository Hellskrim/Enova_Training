using MediatR;
 
namespace EnovaGit.Core.Mediator
{
    public class Mediator: IMediator
    {
        //ten "mediator"nie powstaøby w naturalnych warunkach ;) "Potrzeba matka wynalazków"

         private readonly MediatR.IMediator _mediator;

        public Mediator(MediatR.IMediator mediator)
        {
            _mediator = mediator;
        }

        public object SendMessage() //where T :IResponse
        {
            _mediator.Send(new DataSourceRequest());
            return new object();
        }
    }
}
