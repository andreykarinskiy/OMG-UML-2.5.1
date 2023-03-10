///////////////////////////////////////////////////////////
//  Enumeration.cs
//  Implementation of the Class Enumeration
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:59
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace UML.SimpleClassifiers
{
    /// <summary>
    ///     An Enumeration is a DataType whose values are enumerated in the model as
    ///     EnumerationLiterals.
    /// </summary>
    public interface Enumeration : DataType
    {
        /// <summary>
        ///     The ordered set of literals owned by this Enumeration.
        /// </summary>
        IEnumerable<EnumerationLiteral> ownedLiteral { get; set; }
    }
} //end namespace SimpleClassifiers