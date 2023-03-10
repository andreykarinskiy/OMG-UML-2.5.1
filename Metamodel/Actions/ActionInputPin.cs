///////////////////////////////////////////////////////////
//  ActionInputPin.cs
//  Implementation of the Class ActionInputPin
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:52
//  Original author: ??????
///////////////////////////////////////////////////////////

namespace UML.Actions
{
    /// <summary>
    ///     An ActionInputPin is a kind of InputPin that executes an Action to determine
    ///     the values to input to another Action.
    /// </summary>
    public interface ActionInputPin : InputPin
    {
        /// <summary>
        ///     The Action used to provide the values of the ActionInputPin.
        /// </summary>
        Action fromAction { get; set; }
    }
} //end namespace Actions