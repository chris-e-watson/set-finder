using System.Collections.Generic;

namespace SetFinder.Service
{
    /// <summary>
    /// Describes a service which provides the functionality to find, from a
    /// given set of values, a combination of none or more those values, whose
    /// combined value reaches, but does not exceed, a given target value.
    /// </summary>
    public interface ISetFinder
    {
        #region Properties

        /// <summary>
        /// Gets or sets a set of values.
        /// </summary>
        ICollection<decimal> Values { get; set; }


        /// <summary>
        /// Gets or sets the target value.
        /// </summary>
        decimal Target { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Finds the set.
        /// </summary>
        /// <returns>
        /// The <see cref="ICollection{Decimal}"/> of values, which is a subset
        /// of <see cref="Values"/>, whose combined reaches, but not exceed, the
        /// <see cref="Target"/> value; or, if no such combination can be found,
        /// an empty <see cref="ICollection{Decimal}"/>.
        /// </returns>
        /// <exception cref="Values" was <c>null</c>.
        ICollection<decimal> FindSet();

        #endregion
    }
}
