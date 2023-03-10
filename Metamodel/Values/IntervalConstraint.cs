///////////////////////////////////////////////////////////
//  IntervalConstraint.cs
//  Implementation of the Class IntervalConstraint
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:04
//  Original author: ??????
///////////////////////////////////////////////////////////

using UML.CommonStructure;

namespace UML.Values
{
    /// <summary>
    ///     An IntervalConstraint is a Constraint that is specified by an Interval.
    /// </summary>
    public interface IntervalConstraint : Constraint
    {
        /// <summary>
        ///     The Interval that specifies the condition of the IntervalConstraint.
        /// </summary>
        Interval specification { get; set; }
    }
} //end namespace Values