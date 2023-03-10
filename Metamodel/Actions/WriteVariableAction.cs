///////////////////////////////////////////////////////////
//  WriteVariableAction.cs
//  Implementation of the Class WriteVariableAction
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:18
//  Original author: ??????
///////////////////////////////////////////////////////////

namespace UML.Actions
{
    /// <summary>
    ///     WriteVariableAction is an class for VariableActions that change
    ///     Variable values.
    /// </summary>
    public interface WriteVariableAction : VariableAction
    {
        /// <summary>
        ///     The InputPin that gives the value to be added or removed from the Variable.
        /// </summary>
        InputPin value { get; set; }
    }
} //end namespace Actions