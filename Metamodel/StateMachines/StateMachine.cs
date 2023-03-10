///////////////////////////////////////////////////////////
//  StateMachine.cs
//  Implementation of the Class StateMachine
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:14
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.CommonBehavior;

namespace UML.StateMachines
{
    /// <summary>
    ///     StateMachines can be used to express event-driven behaviors of parts of a
    ///     system. Behavior is modeled as a traversal of a graph of Vertices
    ///     interconnected by one or more joined Transition arcs that are triggered by the
    ///     dispatching of successive Event occurrences. During this traversal, the
    ///     StateMachine may execute a sequence of Behaviors associated with various
    ///     elements of the StateMachine.
    /// </summary>
    public interface StateMachine : Behavior
    {
        /// <summary>
        ///     The StateMachines of which this is an extension.
        /// </summary>
        IEnumerable<StateMachine> extendedStateMachine { get; set; }

        /// <summary>
        ///     The Regions owned directly by the StateMachine.
        /// </summary>
        Region region { get; set; }

        /// <summary>
        ///     The connection points defined for this StateMachine. They represent the
        ///     public interface of the StateMachine when used as part of submachine State
        /// </summary>
        IEnumerable<Pseudostate> connectionPoint { get; set; }

        /// <summary>
        ///     References the submachine(s) in case of a submachine State. Multiple machines
        ///     are referenced in case of a concurrent State.
        /// </summary>
        IEnumerable<State> submachineState { get; set; }

        /// <summary>
        /// The query ancestor(s1, s2) checks whether Vertex s2 is an ancestor of Vertex s1.
        /// 
        /// </summary>
        /// <param name="result"></param>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        //void ancestor(result, Vertex s1, Vertex s2){

        //}

        /// <summary>
        /// The query isConsistentWith specifies that a StateMachine can be redefined by
        /// any other StateMachine for which the redefinition context is valid (see the
        /// isRedefinitionContextValid operation). Note that consistency requirements for
        /// the redefinition of Regions and connectionPoint Pseudostates owned by a
        /// StateMachine are specified by the isConsistentWith and
        /// isRedefinitionContextValid operations for Region and Vertex (and its subclass
        /// Pseudostate).
        /// </summary>
        /// <param name="result"></param>
        /// <param name="redefiningElement"></param>
        //void isConsistentWith(result, RedefinableElement redefiningElement){

        //}

        /// <summary>
        /// The query isRedefinitionContextValid specifies whether the redefinition context
        /// of a StateMachine is properly related to the redefinition contexts of a
        /// StateMachine it redefines. The requirement is that the context
        /// BehavioredClassifier of a redefining StateMachine must specialize the context
        /// Classifier of the redefined StateMachine. If the redefining StateMachine does
        /// not have a context BehavioredClassifier, then then the redefining StateMachine
        /// also must not have a context BehavioredClassifier but must, instead, specialize
        /// the redefining StateMachine.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="redefinedElement"></param>
        //void isRedefinitionContextValid(result, RedefinableElement redefinedElement){

        //}

        /// <summary>
        /// The operation LCA(s1,s2) returns the Region that is the least common ancestor
        /// of Vertices s1 and s2, based on the StateMachine containment hierarchy.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        //Region LCA(Region result, Vertex s1, Vertex s2){

        //	return null;
        //}

        /// <summary>
        /// This utility funciton is like the LCA, except that it returns the nearest
        /// composite State that contains both input Vertices.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        //State LCAState(State result, Vertex v1, Vertex v2){

        //	return null;
        //}
    }
} //end namespace StateMachines