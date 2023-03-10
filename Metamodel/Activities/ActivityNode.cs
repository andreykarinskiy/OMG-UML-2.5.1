///////////////////////////////////////////////////////////
//  ActivityNode.cs
//  Implementation of the Class ActivityNode
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:52
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.Classification;

namespace UML.Activities
{
    /// <summary>
    ///     ActivityNode is an class for points in the flow of an Activity
    ///     connected by ActivityEdges.
    /// </summary>
    public interface ActivityNode : RedefinableElement
    {
        /// <summary>
        ///     ActivityGroups containing the ActivityNode.
        /// </summary>
        IEnumerable<ActivityGroup> inGroup { get; set; }

        /// <summary>
        ///     ActivityNodes from a generalization of the Activity containining this
        ///     ActivityNode that are redefined by this ActivityNode.
        /// </summary>
        IEnumerable<ActivityNode> redefinedNode { get; set; }

        /// <summary>
        ///     ActivityEdges that have the ActivityNode as their source.
        /// </summary>
        IEnumerable<ActivityEdge> outgoing { get; set; }

        /// <summary>
        ///     ActivityEdges that have the ActivityNode as their target.
        /// </summary>
        IEnumerable<ActivityEdge> incoming { get; set; }

        /// <summary>
        ///     ActivityPartitions containing the ActivityNode.
        /// </summary>
        IEnumerable<ActivityPartition> inPartition { get; set; }

        /// <summary>
        ///     InterruptibleActivityRegions containing the ActivityNode.
        /// </summary>
        IEnumerable<InterruptibleActivityRegion> inInterruptibleRegion { get; set; }

        /// <summary>
        ///     The Activity that directly or indirectly contains this ActivityNode.
        /// </summary>
        /// <param name="result"></param>
        Activity containingActivity(Activity result);

        /// <param name="result"></param>
        /// <param name="redefiningElement"></param>
        void isConsistentWith(object result, RedefinableElement redefiningElement);
    }
} //end namespace Activities