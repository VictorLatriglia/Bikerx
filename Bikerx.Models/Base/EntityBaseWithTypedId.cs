using Bikerx.Models.Base;

namespace Bikerx.Models
{
    /// <summary>
    /// Base class for the implementation of models
    /// </summary>
    /// <typeparam name="Tid">Property that identified this Class</typeparam>
    public abstract class EntityBaseWithTypedId<TId> :  IEntityWithTypedId<TId>
    {
        /// <summary>
        /// property that identifies the class
        /// </summary>
        public virtual TId Id { get; set; }
    }
}
