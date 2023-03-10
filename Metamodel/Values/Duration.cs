///////////////////////////////////////////////////////////
//  Duration.cs
//  Implementation of the Class Duration
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:59
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace UML.Values
{
    /// <summary>
    ///     A Duration is a ValueSpecification that specifies the temporal distance between
    ///     two time instants.
    /// </summary>
    public interface Duration : ValueSpecification
    {
        /// <summary>
        ///     Refers to the Observations that are involved in the computation of the Duration
        ///     value
        /// </summary>
        IEnumerable<Observation> observation { get; set; }

        /// <summary>
        ///     A ValueSpecification that evaluates to the value of the Duration.
        /// </summary>
        ValueSpecification expr { get; set; }
    }
} //end namespace Values