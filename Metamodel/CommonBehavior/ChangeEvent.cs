///////////////////////////////////////////////////////////
//  ChangeEvent.cs
//  Implementation of the Class ChangeEvent
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:54
//  Original author: ??????
///////////////////////////////////////////////////////////

using UML.Values;

namespace UML.CommonBehavior
{
    /// <summary>
    ///     A ChangeEvent models a change in the system configuration that makes a
    ///     condition true.
    /// </summary>
    public interface ChangeEvent : Event
    {
        /// <summary>
        ///     A Boolean-valued ValueSpecification that will result in a ChangeEvent whenever
        ///     its value changes from false to true.
        /// </summary>
        ValueSpecification changeExpression { get; set; }
    }
} //end namespace CommonBehavior