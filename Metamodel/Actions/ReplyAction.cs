///////////////////////////////////////////////////////////
//  ReplyAction.cs
//  Implementation of the Class ReplyAction
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:13
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.CommonBehavior;

namespace UML.Actions
{
    /// <summary>
    ///     A ReplyAction is an Action that accepts a set of reply values and a value
    ///     containing return information produced by a previous AcceptCallAction. The
    ///     ReplyAction returns the values to the caller of the previous call, completing
    ///     execution of the call.
    /// </summary>
    public interface ReplyAction : Action
    {
        /// <summary>
        ///     A list of InputPins providing the values for the output (inout, out, and
        ///     return) Parameters of the Operation. These values are returned to the caller.
        /// </summary>
        IEnumerable<InputPin> replyValue { get; set; }

        /// <summary>
        ///     The Trigger specifying the Operation whose call is being replied to.
        /// </summary>
        Trigger replyToCall { get; set; }

        /// <summary>
        ///     An InputPin that holds the return information value produced by an earlier
        ///     AcceptCallAction.
        /// </summary>
        InputPin returnInformation { get; set; }
    }
} //end namespace Actions