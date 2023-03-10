///////////////////////////////////////////////////////////
//  EnumerationLiteral.cs
//  Implementation of the Class EnumerationLiteral
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:00
//  Original author: ??????
///////////////////////////////////////////////////////////

using UML.Classification;

namespace UML.SimpleClassifiers
{
    /// <summary>
    ///     An EnumerationLiteral is a user-defined data value for an Enumeration.
    /// </summary>
    public interface EnumerationLiteral : InstanceSpecification
    {
        /// <summary>
        ///     The classifier of this EnumerationLiteral derived to be equal to its
        ///     Enumeration.
        /// </summary>
        Enumeration classifier { get; set; }

        /// <summary>
        /// Derivation of Enumeration::/classifier
        /// </summary>
        /// <param name="result"></param>
        //Enumeration classifier(Enumeration result){

        //	return null;
        //}
    }
} //end namespace SimpleClassifiers