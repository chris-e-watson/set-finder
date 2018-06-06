using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetFinder.Service
{
    /// <summary>
    /// Provides the functionality to find, from a given set of values, a
    /// combination of none or more those values, whose combined value reaches,
    /// but does not exceed, a given target value.
    /// </summary>
    public class SetFinder : ISetFinder
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the target value.
        /// </summary>
        public decimal Target { get; set; }


        /// <summary>
        /// Gets or sets a set of values.
        /// </summary>
        public ICollection<decimal> Values { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Finds the set.
        /// </summary>
        /// <returns></returns>
        /// <returns>
        /// The <see cref="ICollection{Decimal}"/> of values, which is a subset
        /// of <see cref="Values"/>, whose combined reaches, but not exceed, the
        /// <see cref="Target"/> value; or, if no such combination can be found,
        /// an empty <see cref="ICollection{Decimal}"/>.
        /// </returns>
        /// <exception cref="Values" was <c>null</c>.
        public ICollection<decimal> FindSet()
        {
            throw new NotImplementedException();

            // TODO: Implement SetFinder.FindSet().
        }

        #endregion
    }
}
