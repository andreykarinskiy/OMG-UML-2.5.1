///////////////////////////////////////////////////////////
//  AddVariableValueAction.cs
//  Implementation of the Class AddVariableValueAction
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:53
//  Original author: ??????
///////////////////////////////////////////////////////////

namespace UML.Actions
{
    /// <summary>
    ///     An AddVariableValueAction is a WriteVariableAction for adding values to a
    ///     Variable.
    /// </summary>
    public interface AddVariableValueAction : WriteVariableAction
    {
        /// <summary>
        ///     Specifies whether existing values of the Variable should be removed before
        ///     adding the new value.
        /// </summary>
        bool isReplaceAll { get; set; }

        /// <summary>
        ///     The InputPin that gives the position at which to insert a new value or move an
        ///     existing value in ordered Variables. The type of the insertAt InputPin is
        ///     UnlimitedNatural, but the value cannot be zero. It is omitted for unordered
        ///     Variables.
        /// </summary>
        InputPin insertAt { get; set; }
    }
} //end namespace Actions