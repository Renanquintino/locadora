
namespace Pereirão.Entities
{
    class Veiculo
    {
        public string Categoria { get; set; }

        public Veiculo()
        {
        }

        public Veiculo(string categoria)
        {
            Categoria = categoria;
            
        }
    }
}
