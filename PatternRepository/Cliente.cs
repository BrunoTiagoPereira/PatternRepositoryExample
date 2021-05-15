namespace PatternRepository
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Inscricao { get; set; }
        public int Idade { get; set; }

        public Cliente(int id, string nome, string inscricao, int idade)
        {
            Nome = nome;
            Inscricao = inscricao;
            Idade = idade;
            Id = id;
        }
    }
}