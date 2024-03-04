namespace LearningTdd.Domain.Cursos
{
    public class Curso
    {
        public string Nome { get; private set; }
        public double CargaHoraria { get; private set; }
        public string PublicoAlvo { get; private set; }
        public decimal Valor { get; private set; }

        public Curso(string nome, double cargaHoraria, string publicoAlvo, decimal valor)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentException("Nome inválido");
            }

            if (cargaHoraria < 1)
            {
                throw new ArgumentException("Carga horária inválida");
            }

            if (valor < 1)
            {
                throw new ArgumentException("Valor inválido");
            }

            Nome = nome;
            CargaHoraria = cargaHoraria;
            PublicoAlvo = publicoAlvo;
            Valor = valor;
        }
    }
}
