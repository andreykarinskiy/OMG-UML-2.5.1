///////////////////////////////////////////////////////////
//  LoopNode.cs
//  Implementation of the Class LoopNode
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:06
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.Activities;

namespace UML.Actions
{
    /// <summary>
    ///     A LoopNode is a StructuredActivityNode that represents an iterative loop with
    ///     setup, test, and body sections.
    /// </summary>
    public interface LoopNode : StructuredActivityNode
    {
        /// <summary>
        ///     If true, the test is performed before the first execution of the bodyPart. If
        ///     false, the bodyPart is executed once before the test is performed.
        /// </summary>
        bool isTestedFirst { get; set; }

        /// <summary>
        ///     An OutputPin on an Action in the test section whose Boolean value determines
        ///     whether to continue executing the loop bodyPart.
        /// </summary>
        OutputPin decider { get; set; }

        /// <summary>
        ///     The set of ExecutableNodes executed in order to provide the test result for the
        ///     loop.
        /// </summary>
        ExecutableNode test { get; set; }

        /// <summary>
        ///     A list of InputPins whose values are moved into the loopVariable Pins before
        ///     the first iteration of the loop.
        /// </summary>
        IEnumerable<InputPin> loopVariableInput { get; set; }

        /// <summary>
        ///     The OutputPins on Actions within the bodyPart, the values of which are moved to
        ///     the loopVariable OutputPins after the completion of each execution of the
        ///     bodyPart, before the next iteration of the loop begins or before the loop exits.
        /// </summary>
        IEnumerable<OutputPin> bodyOutput { get; set; }

        /// <summary>
        ///     A list of OutputPins that receive the loopVariable values after the last
        ///     iteration of the loop and constitute the output of the LoopNode.
        /// </summary>
        IEnumerable<OutputPin> result { get; set; }

        /// <summary>
        ///     A list of OutputPins that hold the values of the loop variables during an
        ///     execution of the loop. When the test fails, the values are moved to the result
        ///     OutputPins of the loop.
        /// </summary>
        IEnumerable<OutputPin> loopVariable { get; set; }

        /// <summary>
        ///     The set of ExecutableNodes that perform the repetitive computations of the loop.
        ///     The bodyPart is executed as long as the test section produces a true value.
        /// </summary>
        IEnumerable<ExecutableNode> bodyPart { get; set; }

        /// <summary>
        ///     The set of ExecutableNodes executed before the first iteration of the loop, in
        ///     order to initialize values or perform other setup computations.
        /// </summary>
        IEnumerable<ExecutableNode> setupPart { get; set; }

        /// <summary>
        ///     Return only this LoopNode. This prevents Actions within the LoopNode from
        ///     having their OutputPins used as bodyOutputs or decider Pins in containing
        ///     LoopNodes or ConditionalNodes.
        /// </summary>
        /// <param name="result"></param>
        Action allActions(Action result);

        /// <summary>
        ///     Return the loopVariable OutputPins in addition to other source nodes for the
        ///     LoopNode as a StructuredActivityNode.
        /// </summary>
        /// <param name="result"></param>
        ActivityNode sourceNodes(ActivityNode result);
    }
} //end namespace Actions