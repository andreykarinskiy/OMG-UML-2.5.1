///////////////////////////////////////////////////////////
//  InteractionFragment.cs
//  Implementation of the Class InteractionFragment
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:03
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.CommonStructure;

namespace UML.Interactions
{
    /// <summary>
    ///     InteractionFragment is an notion of the most general interaction unit.
    ///     An InteractionFragment is a piece of an Interaction. Each InteractionFragment
    ///     is conceptually like an Interaction by itself.
    /// </summary>
    public interface InteractionFragment : NamedElement
    {
        /// <summary>
        ///     References the Lifelines that the InteractionFragment involves.
        /// </summary>
        IEnumerable<Lifeline> covered { get; set; }

        /// <summary>
        ///     The general ordering relationships contained in this fragment.
        /// </summary>
        IEnumerable<GeneralOrdering> generalOrdering { get; set; }
    }
} //end namespace Interactions