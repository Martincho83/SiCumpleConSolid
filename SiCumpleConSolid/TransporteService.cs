

namespace SiCumpleConSolid
{
    public class TransporteService
    {
        private readonly ITransporte _transporte;
        private readonly IRepository<ITransporte> _repository;

        public TransporteService(ITransporte transporte, IRepository<ITransporte> repository)
        {
            _transporte = transporte;
            _repository = repository;
        }

        public void MoverTransporte()
        {
            _transporte.Mover();
        }

        public void GuardarTransporte()
        {
            _repository.Guardar(_transporte);
        }
    }

}
