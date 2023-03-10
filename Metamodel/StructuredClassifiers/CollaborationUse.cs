///////////////////////////////////////////////////////////
//  CollaborationUse.cs
//  Implementation of the Class CollaborationUse
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:55
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.CommonStructure;

namespace UML.StructuredClassifiers
{
    /// <summary>
    ///     A CollaborationUse is used to specify the application of a pattern specified by
    ///     a Collaboration to a specific situation.
    /// </summary>
    public interface CollaborationUse : NamedElement
    {
        /// <summary>
        ///     A mapping between features of the Collaboration and features of the owning
        ///     Classifier. This mapping indicates which ConnectableElement of the Classifier
        ///     plays which role(s) in the Collaboration. A ConnectableElement may be bound to
        ///     multiple roles in the same CollaborationUse (that is, it may play multiple
        ///     roles).
        /// </summary>
        IEnumerable<Dependency> roleBinding { get; set; }

        /// <summary>
        ///     The Collaboration which is used in this CollaborationUse. The Collaboration
        ///     defines the cooperation between its roles which are mapped to
        ///     ConnectableElements relating to the Classifier owning the CollaborationUse.
        /// </summary>
        Collaboration type { get; set; }
    }
} //end namespace StructuredClassifiers