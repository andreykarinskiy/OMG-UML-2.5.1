///////////////////////////////////////////////////////////
//  MessageSort.cs
//  Implementation of the Enumeration MessageSort
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:06
//  Original author: ??????
///////////////////////////////////////////////////////////

namespace UML.Interactions
{
    /// <summary>
    ///     This is an enumerated type that identifies the type of communication action
    ///     that was used to generate the Message.
    /// </summary>
    public enum MessageSort
    {
        /// <summary>
        ///     The message was generated by a synchronous call to an operation.
        /// </summary>
        synchCall,

        /// <summary>
        ///     The message was generated by an asynchronous call to an operation; i.e., a
        ///     CallAction with isSynchronous = false.
        /// </summary>
        asynchCall,

        /// <summary>
        ///     The message was generated by an asynchronous send action.
        /// </summary>
        asynchSignal,

        /// <summary>
        ///     The message designating the creation of another lifeline object.
        /// </summary>
        createMessage,

        /// <summary>
        ///     The message designating the termination of another lifeline.
        /// </summary>
        deleteMessage,

        /// <summary>
        ///     The message is a reply message to an operation call.
        /// </summary>
        reply
    } //end MessageSort
} //end namespace Interactions