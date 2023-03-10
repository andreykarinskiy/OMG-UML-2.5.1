///////////////////////////////////////////////////////////
//  VariableAction.cs
//  Implementation of the Class VariableAction
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:18
//  Original author: ??????
///////////////////////////////////////////////////////////

using UML.Activities;

namespace UML.Actions
{
    /// <summary>
    ///     VariableAction is an class for Actions that operate on a specified
    ///     Variable.
    /// </summary>
    public interface VariableAction : Action
    {
        /// <summary>
        ///     The Variable to be read or written.
        /// </summary>
        Variable variable { get; set; }
    }
} //end namespace Actions