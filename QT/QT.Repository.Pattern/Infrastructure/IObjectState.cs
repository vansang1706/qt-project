using System.ComponentModel.DataAnnotations.Schema;

namespace QT.Repository.Pattern.Infrastructure
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}
