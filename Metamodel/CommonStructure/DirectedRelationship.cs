///////////////////////////////////////////////////////////
//  DirectedRelationship.cs
//  Implementation of the Class DirectedRelationship
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:59
//  Original author: ??????
///////////////////////////////////////////////////////////

namespace UML.CommonStructure
{
    /// <summary>
    ///     A DirectedRelationship represents a relationship between a collection of source
    ///     model Elements and a collection of target model Elements.
    /// </summary>
    public interface DirectedRelationship : Relationship
    {
        /// <summary>
        ///     Specifies the target Element(s) of the DirectedRelationship.
        /// </summary>
        Element target { get; set; }

        /// <summary>
        ///     Specifies the source Element(s) of the DirectedRelationship.
        /// </summary>
        Element source { get; set; }
    }
} //end namespace CommonStructure