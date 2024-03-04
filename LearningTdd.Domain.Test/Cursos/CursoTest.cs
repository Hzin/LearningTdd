using LearningTdd.Domain.Cursos;

namespace LearningTdd.Domain.Test.Cursos
{
    public class CursoTest
    {
        //Criar um curso com os seguintes dados
        //        Nome, Carga Horária, Publico Alvo e Valor

        [Fact]
        public void Curso_CriarCurso_RetornaCurso()
        {
            var CursoEsperado = new
            {
                Nome = "Informática Básica",
                CargaHoraria = (double) 80,
                PublicoAlvo = "Estudantes",
                Valor = (decimal) 950.00
            };

            var curso = new Curso(
                CursoEsperado.Nome,
                CursoEsperado.CargaHoraria,
                CursoEsperado.PublicoAlvo,
                CursoEsperado.Valor
            );

            Assert.Equal(CursoEsperado.Nome, curso.Nome);
            Assert.Equal(CursoEsperado.CargaHoraria, curso.CargaHoraria);
            Assert.Equal(CursoEsperado.PublicoAlvo, curso.PublicoAlvo);
            Assert.Equal(CursoEsperado.Valor, curso.Valor);
        }
    }
}
