///////////////////////////////////////////////////////////
//  Classifier.cs
//  Implementation of the Class Classifier
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:55
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;
using UML.CommonStructure;
using UML.SimpleClassifiers;
using UML.StructuredClassifiers;
using UML.UseCases;

namespace UML.Classification
{
    /// <summary>
    ///     A Classifier represents a classification of instances according to their
    ///     Features.
    /// </summary>
    public interface Classifier : RedefinableElement, TemplateableElement, Type, Namespace
    {
        /// <summary>
        ///     If true, the Classifier can only be instantiated by instantiating one of its
        ///     specializations. An Classifier is intended to be used by other
        ///     Classifiers e.g., as the target of Associations or Generalizations.
        /// </summary>
        bool Is { get; set; }

        /// <summary>
        ///     If true, the Classifier cannot be specialized.
        /// </summary>
        bool isFinalSpecialization { get; set; }

        /// <summary>
        ///     The UseCases owned by this classifier.
        /// </summary>
        IEnumerable<UseCase> ownedUseCase { get; set; }

        /// <summary>
        ///     All of the Properties that are direct (i.e., not inherited or imported)
        ///     attributes of the Classifier.
        /// </summary>
        IEnumerable<Property> attribute { get; set; }

        /// <summary>
        ///     The CollaborationUses owned by the Classifier.
        /// </summary>
        IEnumerable<CollaborationUse> collaborationUse { get; set; }

        /// <summary>
        ///     The Classifiers redefined by this Classifier.
        /// </summary>
        IEnumerable<Classifier> redefinedClassifier { get; set; }

        /// <summary>
        ///     All elements inherited by this Classifier from its general Classifiers.
        /// </summary>
        IEnumerable<NamedElement> inheritedMember { get; set; }

        /// <summary>
        ///     The optional RedefinableTemplateSignature specifying the formal template
        ///     parameters.
        /// </summary>
        RedefinableTemplateSignature ownedTemplateSignature { get; set; }

        /// <summary>
        ///     A CollaborationUse which indicates the Collaboration that represents this
        ///     Classifier.
        /// </summary>
        CollaborationUse representation { get; set; }

        /// <summary>
        ///     The Substitutions owned by this Classifier.
        /// </summary>
        IEnumerable<Substitution> substitution { get; set; }

        /// <summary>
        ///     Specifies each Feature directly defined in the classifier. Note that there may
        ///     be members of the Classifier that are of the type Feature but are not included,
        ///     e.g., inherited features.
        /// </summary>
        IEnumerable<Feature> feature { get; set; }

        /// <summary>
        ///     The generalizing Classifiers for this Classifier.
        /// </summary>
        IEnumerable<Classifier> general { get; set; }

        /// <summary>
        ///     The Generalization relationships for this Classifier. These Generalizations
        ///     navigate to more general Classifiers in the generalization hierarchy.
        /// </summary>
        IEnumerable<Generalization> generalization { get; set; }

        /// <summary>
        ///     The GeneralizationSet of which this Classifier is a power type.
        /// </summary>
        IEnumerable<GeneralizationSet> powertypeExtent { get; set; }

        /// <summary>
        ///     TheClassifierTemplateParameter that exposes this element as a formal parameter.
        /// </summary>
        ClassifierTemplateParameter templateParameter { get; set; }

        /// <summary>
        ///     The set of UseCases for which this Classifier is the subject.
        /// </summary>
        IEnumerable<UseCase> useCase { get; set; }

        /// <summary>
        ///     The query allAttributes gives an ordered set of all owned and inherited
        ///     attributes of the Classifier. All owned attributes appear before any inherited
        ///     attributes, and the attributes inherited from any more specific parent
        ///     Classifier appear before those of any more general parent Classifier. However,
        ///     if the Classifier has multiple immediate parents, then the relative ordering of
        ///     the sets of attributes from those parents is not defined.
        /// </summary>
        /// <param name="result"></param>
        Property allAttributes(Property result);

        /// <summary>
        ///     The query allFeatures() gives all of the Features in the namespace of the
        ///     Classifier. In general, through mechanisms such as inheritance, this will be a
        ///     larger set than feature.
        /// </summary>
        /// <param name="result"></param>
        Feature allFeatures(Feature result);

        /// <summary>
        ///     The query allParents() gives all of the direct and indirect ancestors of a
        ///     generalized Classifier.
        /// </summary>
        /// <param name="result"></param>
        Classifier allParents(Classifier result);

        /// <summary>
        ///     The Interfaces realized by this Classifier and all of its generalizations
        /// </summary>
        /// <param name="result"></param>
        IEnumerable<Interface> allRealizedInterfaces(Interface result);

        /// <summary>
        ///     All StructuralFeatures related to the Classifier that may have Slots, including
        ///     direct attributes, inherited attributes, private attributes in generalizations,
        ///     and memberEnds of Associations, but excluding redefined StructuralFeatures.
        /// </summary>
        /// <param name="result"></param>
        IEnumerable<StructuralFeature> allSlottableFeatures(StructuralFeature result);

        /// <summary>
        ///     The Interfaces used by this Classifier and all of its generalizations
        /// </summary>
        /// <param name="result"></param>
        IEnumerable<Interface> allUsedInterfaces(Interface result);

        /// <summary>
        ///     The query conformsTo() gives true for a Classifier that defines a type that
        ///     conforms to another. This is used, for example, in the specification of
        ///     signature conformance for operations.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="other"></param>
        bool conformsTo(Type other);

        /// <summary>
        ///     The Interfaces directly realized by this Classifier
        /// </summary>
        /// <param name="result"></param>
        IEnumerable<Interface> directlyRealizedInterfaces(Interface result);
        /// <summary>
        /// The Interfaces directly used by this Classifier
        /// </summary>
        /// <param name="result"></param>
        //UML.SimpleClassifiers.public interface directlyUsedInterfaces(public interface result){

        //	return null;
        //}

        /// <summary>
        /// The general Classifiers are the ones referenced by the Generalization
        /// relationships.
        /// </summary>
        /// <param name="result"></param>
        //Classifier general(Classifier result);

        /// <summary>
        ///     The query hasVisibilityOf() determines whether a NamedElement is visible in the
        ///     classifier. Non-private members are visible. It is only called when the
        ///     argument is something owned by a parent.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="n"></param>
        bool hasVisibilityOf(NamedElement n);

        /// <summary>
        ///     The query inherit() defines how to inherit a set of elements passed as its
        ///     argument.  It excludes redefined elements from the result.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="inhs"></param>
        IEnumerable<NamedElement> inherit(NamedElement result, NamedElement inhs);

        /// <summary>
        ///     The query inheritableMembers() gives all of the members of a Classifier that
        ///     may be inherited in one of its descendants, subject to whatever visibility
        ///     restrictions apply.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="c"></param>
        IEnumerable<NamedElement> inheritableMembers(NamedElement result, Classifier c);

        /// <summary>
        /// The inheritedMember association is derived by inheriting the inheritable
        /// members of the parents.
        /// </summary>
        /// <param name="result"></param>
        //IEnumerable<NamedElement> inheritedMember(NamedElement result);

        /// <param name="contract"></param>
        /// <param name="result"></param>
        bool isSubstitutableFor(Classifier contract);

        /// <summary>
        ///     The query isTemplate() returns whether this Classifier is actually a template.
        /// </summary>
        /// <param name="result"></param>
        bool isTemplate();

        /// <summary>
        ///     The query maySpecializeType() determines whether this classifier may have a
        ///     generalization relationship to classifiers of the specified type. By default a
        ///     classifier may specialize classifiers of the same or a more general type. It is
        ///     intended to be redefined by classifiers that have different specialization
        ///     constraints.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="c"></param>
        bool maySpecializeType(Classifier c);

        /// <summary>
        ///     The query parents() gives all of the immediate ancestors of a generalized
        ///     Classifier.
        /// </summary>
        /// <param name="result"></param>
        Classifier parents(Classifier result);
    }
} //end namespace Classification