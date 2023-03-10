///////////////////////////////////////////////////////////
//  BehaviorExecutionSpecification.cs
//  Implementation of the Class BehaviorExecutionSpecification
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:54
//  Original author: ??????
///////////////////////////////////////////////////////////

using UML.CommonBehavior;

namespace UML.Interactions
{
    /// <summary>
    ///     A BehaviorExecutionSpecification is a kind of ExecutionSpecification
    ///     representing the execution of a Behavior.
    /// </summary>
    public interface BehaviorExecutionSpecification : ExecutionSpecification
    {
        /// <summary>
        ///     Behavior whose execution is occurring.
        /// </summary>
        Behavior behavior { get; set; }
    }
} //end namespace Interactions