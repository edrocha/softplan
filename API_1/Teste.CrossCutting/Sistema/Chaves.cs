namespace Teste.CrossCutting.Sistema
{
    public class Chaves
    {
        public string ConnectionString { get; set; }

        public Chaves()
        {
            //Provisório
            ConnectionString = "Data Source=algumip;User Id=usuario;Password=senha;";
        }
    }
}
