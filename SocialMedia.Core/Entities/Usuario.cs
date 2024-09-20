namespace SocialMedia.Core.Entities
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string Email { get; set; } = null!;

        public DateOnly FechaNacimiento { get; set; }

        public string? Telefono { get; set; }

        public bool Activo { get; set; }

        public virtual ICollection<Comentario> Comentarios { get; set; } = new List<Comentario>();

        public virtual ICollection<Publicacion> Publicacions { get; set; } = new List<Publicacion>();
    }
}