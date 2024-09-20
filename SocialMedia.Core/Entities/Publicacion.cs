namespace SocialMedia.Core.Entities
{
    public partial class Publicacion
    {

        public Publicacion()
        {
            Comentarios = new HashSet<Comentario>();
        }

        public int IdPublicacion { get; set; }

        public int IdUsuario { get; set; }

        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; } = null!;

        public string? Imagen { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

        public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();
    }
}