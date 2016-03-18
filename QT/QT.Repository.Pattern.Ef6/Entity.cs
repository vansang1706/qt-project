using System.ComponentModel.DataAnnotations.Schema;
using QT.Repository.Pattern.Infrastructure;

namespace QT.Repository.Pattern.Ef6
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}
