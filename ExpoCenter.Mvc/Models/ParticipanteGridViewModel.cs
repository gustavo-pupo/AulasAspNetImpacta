namespace ExpoCenter.Mvc.Models
{
    public class ParticipanteGridViewModel
    {
        private string cpf;

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Cpf { get => long.Parse(cpf).ToString(@"000\.000\.000-00"); set => cpf = value; }

        public bool Selecionado { get; set; }
    }
}