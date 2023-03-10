///////////////////////////////////////////////////////////
//  ConnectableElement.cs
//  Implementation of the Class ConnectableElement
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:56
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.CommonStructure;

namespace UML.StructuredClassifiers
{
    /// <summary>
    ///     ConnectableElement is an metaclass representing a set of instances
    ///     that play roles of a StructuredClassifier. ConnectableElements may be joined by
    ///     attached Connectors and specify configurations of linked instances to be
    ///     created within an instance of the containing StructuredClassifier.
    /// </summary>
    public interface ConnectableElement : ParameterableElement, TypedElement
    {
        /// <summary>
        ///     A set of ConnectorEnds that attach to this ConnectableElement.
        /// </summary>
        IEnumerable<ConnectorEnd> end { get; set; }

        /// <summary>
        ///     The ConnectableElementTemplateParameter for this ConnectableElement parameter.
        /// </summary>
        ConnectableElementTemplateParameter templateParameter { get; set; }

        /// <summary>
        /// Derivation for ConnectableElement::/end : ConnectorEnd
        /// </summary>
        /// <param name="result"></param>
        //ConnectorEnd end(ConnectorEnd result){

        //	return null;
        //}
    }
} //end namespace StructuredClassifiers