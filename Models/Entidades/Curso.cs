namespace Cursos.Models.Entidades
{
    public class Curso
    {
        public int Id { get; set; }
        public string thumbnail { get; set; }
        public string nome { get; set; }
        //[DisplayName("O que você vai aprender")]
        public string resumo { get; set; }

        public string descricao  { get; set; }
        public string publicoAlvo { get; set; }

        public int cargaHoraria { get; set; }

       /* public enum formato
        {
            "Aulas ao vivo e online",
            "Aulas gravadas",
            "Aulas presenciais", 
            "Desafio Prático", 
        }*/



    }
}
