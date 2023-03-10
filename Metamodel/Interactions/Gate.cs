///////////////////////////////////////////////////////////
//  Gate.cs
//  Implementation of the Class Gate
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:02
//  Original author: ??????
///////////////////////////////////////////////////////////

namespace UML.Interactions
{
    /// <summary>
    ///     A Gate is a MessageEnd which serves as a connection point for relating a
    ///     Message which has a MessageEnd (sendEvent / receiveEvent) outside an
    ///     InteractionFragment with another Message which has a MessageEnd (receiveEvent /
    ///     sendEvent)  inside that InteractionFragment.
    /// </summary>
    public interface Gate : MessageEnd
    {
        /// <summary>
        /// This query returns the name of the gate, either the explicit name (.name) or
        /// the constructed name ('out_" or 'in_' concatenated in front of .message.name)
        /// if the explicit name is not present.
        /// </summary>
        /// <param name="result"></param>
        //void getName(result){

        //}

        /// <summary>
        /// If the Gate is an inside Combined Fragment Gate, this operation returns the
        /// InteractionOperand that the opposite end of this Gate is included within.
        /// </summary>
        /// <param name="result"></param>
        //InteractionOperand getOperand(InteractionOperand result){

        //	return null;
        //}

        /// <summary>
        /// This query returns true value if this Gate is an actualGate of an
        /// InteractionUse.
        /// </summary>
        /// <param name="result"></param>
        //void isActual(result){

        //}

        /// <summary>
        /// The query isDistinguishableFrom() specifies that two Gates may coexist in the
        /// same Namespace, without an explicit name property. The association end
        /// formalGate subsets ownedElement, and since the Gate name attribute
        /// is optional, it is allowed to have two formal gates without an explicit name,
        /// but having derived names which are distinct.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="n"></param>
        /// <param name="ns"></param>
        //void isDistinguishableFrom(result, NamedElement n, Namespace ns){

        //}

        /// <summary>
        /// This query returns true if this Gate is a formalGate of an Interaction.
        /// </summary>
        /// <param name="result"></param>
        //void isFormal(result){

        //}

        /// <summary>
        /// This query returns true if this Gate is attached to the boundary of a
        /// CombinedFragment, and its other end (if present) is inside of an
        /// InteractionOperator of the same CombinedFragment.
        /// </summary>
        /// <param name="result"></param>
        //void isInsideCF(result){

        //}

        /// <summary>
        /// This query returns true if this Gate is attached to the boundary of a
        /// CombinedFragment, and its other end (if present)  is outside of the same
        /// CombinedFragment.
        /// </summary>
        /// <param name="result"></param>
        //void isOutsideCF(result){

        //}

        /// <summary>
        /// This query returns true if the name of this Gate matches the name of the in
        /// parameter Gate, and the messages for the two Gates correspond. The Message for
        /// one Gate (say A) corresponds to the Message for another Gate (say B) if (A and
        /// B have the same name value) and (if A is a sendEvent then B is a receiveEvent)
        /// and (if A is a receiveEvent then B is a sendEvent) and (A and B have the same
        /// messageSort value) and (A and B have the same signature value).
        /// </summary>
        /// <param name="result"></param>
        /// <param name="gateToMatch"></param>
        //void matches(result, Gate gateToMatch){

        //}
    }
} //end namespace Interactions