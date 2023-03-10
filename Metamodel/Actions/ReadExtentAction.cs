///////////////////////////////////////////////////////////
//  ReadExtentAction.cs
//  Implementation of the Class ReadExtentAction
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:11
//  Original author: ??????
///////////////////////////////////////////////////////////

using UML.Classification;

namespace UML.Actions
{
    /// <summary>
    ///     A ReadExtentAction is an Action that retrieves the current instances of a
    ///     Classifier.
    /// </summary>
    public interface ReadExtentAction : Action
    {
        /// <summary>
        ///     The Classifier whose instances are to be retrieved.
        /// </summary>
        Classifier classifier { get; set; }

        /// <summary>
        ///     The OutputPin on which the Classifier instances are placed.
        /// </summary>
        OutputPin result { get; set; }
    }
} //end namespace Actions