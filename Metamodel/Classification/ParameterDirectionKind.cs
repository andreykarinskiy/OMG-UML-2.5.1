///////////////////////////////////////////////////////////
//  ParameterDirectionKind.cs
//  Implementation of the Enumeration ParameterDirectionKind
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:09
//  Original author: ??????
///////////////////////////////////////////////////////////

namespace UML.Classification
{
    /// <summary>
    ///     ParameterDirectionKind is an Enumeration that defines literals used to specify
    ///     direction of parameters.
    /// </summary>
    public enum ParameterDirectionKind
    {
        /// <summary>
        ///     Indicates that Parameter values are passed in by the caller.
        /// </summary>
        In,

        /// <summary>
        ///     Indicates that Parameter values are passed in by the caller and (possibly
        ///     different) values passed out to the caller.
        /// </summary>
        inout,

        /// <summary>
        ///     Indicates that Parameter values are passed out to the caller.
        /// </summary>
        Out,

        /// <summary>
        ///     Indicates that Parameter values are passed as return values back to the caller.
        /// </summary>
        Return
    } //end ParameterDirectionKind
} //end namespace Classification