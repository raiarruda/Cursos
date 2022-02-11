﻿namespace Cursos.Models.Entidades
{
    public class PostagemBlog
    {
        public int Id { get; set; }
        public string tituloPost { get; set; }
        
        public string imagemCapa { get; set; }

        public string conteudo { get; set; }
        public int? gostei { get; set; } = 0;
        public int? naoGostei { get; set; } = 0;

        public DateTime dataPublicacao { get; set; }

        public string autor { get; set; }
    }
}
