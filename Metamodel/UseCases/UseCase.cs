///////////////////////////////////////////////////////////
//  UseCase.cs
//  Implementation of the Class UseCase
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:17
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.Classification;
using UML.SimpleClassifiers;

namespace UML.UseCases
{
    /// <summary>
    ///     A UseCase specifies a set of actions performed by its subjects, which yields an
    ///     observable result that is of value for one or more Actors or other stakeholders
    ///     of each subject.
    /// </summary>
    public interface UseCase : BehavioredClassifier
    {
        /// <summary>
        ///     The Extend relationships owned by this UseCase.
        /// </summary>
        IEnumerable<Extend> extend { get; set; }

        /// <summary>
        ///     The subjects to which this UseCase applies. Each subject or its parts realize
        ///     all the UseCases that apply to it.
        /// </summary>
        IEnumerable<Classifier> subject { get; set; }

        /// <summary>
        ///     The Include relationships owned by this UseCase.
        /// </summary>
        IEnumerable<Include> include { get; set; }

        /// <summary>
        ///     The ExtensionPoints owned by this UseCase.
        /// </summary>
        IEnumerable<ExtensionPoint> extensionPoint { get; set; }

        /// <summary>
        /// The query allIncludedUseCases() returns the transitive closure of all UseCases
        /// (directly or indirectly) included by this UseCase.
        /// </summary>
        /// <param name="result"></param>
        //UseCase allIncludedUseCases(UseCase result){

        //	return null;
        //}
    }
} //end namespace UseCases