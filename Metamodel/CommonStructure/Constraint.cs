///////////////////////////////////////////////////////////
//  Constraint.cs
//  Implementation of the Class Constraint
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:57
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.Values;

namespace UML.CommonStructure
{
    /// <summary>
    ///     A Constraint is a condition or restriction expressed in natural language text
    ///     or in a machine readable language for the purpose of declaring some of the
    ///     semantics of an Element or set of Elements.
    /// </summary>
    public interface Constraint : PackageableElement
    {
        /// <summary>
        ///     A condition that must be true when evaluated in order for the Constraint to be
        ///     satisfied.
        /// </summary>
        ValueSpecification specification { get; set; }

        /// <summary>
        ///     The ordered set of Elements referenced by this Constraint.
        /// </summary>
        IEnumerable<Element> constrainedElement { get; set; }
    }
} //end namespace CommonStructure