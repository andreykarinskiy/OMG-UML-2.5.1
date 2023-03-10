///////////////////////////////////////////////////////////
//  OccurrenceSpecification.cs
//  Implementation of the Class OccurrenceSpecification
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:08
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace UML.Interactions
{
    /// <summary>
    ///     An OccurrenceSpecification is the basic semantic unit of Interactions. The
    ///     sequences of occurrences specified by them are the meanings of Interactions.
    /// </summary>
    public interface OccurrenceSpecification : InteractionFragment
    {
        /// <summary>
        ///     References the GeneralOrderings that specify EventOcurrences that must occur
        ///     after this OccurrenceSpecification.
        /// </summary>
        IEnumerable<GeneralOrdering> toAfter { get; set; }

        /// <summary>
        ///     References the GeneralOrderings that specify EventOcurrences that must occur
        ///     before this OccurrenceSpecification.
        /// </summary>
        IEnumerable<GeneralOrdering> toBefore { get; set; }

        /// <summary>
        ///     References the Lifeline on which the OccurrenceSpecification appears.
        /// </summary>
        Lifeline covered { get; set; }
    }
} //end namespace Interactions