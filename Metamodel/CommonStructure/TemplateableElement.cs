///////////////////////////////////////////////////////////
//  TemplateableElement.cs
//  Implementation of the Class TemplateableElement
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:15
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace UML.CommonStructure
{
    /// <summary>
    ///     A TemplateableElement is an Element that can optionally be defined as a
    ///     template and bound to other templates.
    /// </summary>
    public interface TemplateableElement : Element
    {
        /// <summary>
        ///     The optional TemplateSignature specifying the formal TemplateParameters for
        ///     this TemplateableElement. If a TemplateableElement has a TemplateSignature,
        ///     then it is a template.
        /// </summary>
        TemplateSignature ownedTemplateSignature { get; set; }

        /// <summary>
        ///     The optional TemplateBindings from this TemplateableElement to one or more
        ///     templates.
        /// </summary>
        IEnumerable<TemplateBinding> templateBinding { get; set; }

        /// <summary>
        /// The query isTemplate() returns whether this TemplateableElement is actually a
        /// template.
        /// </summary>
        /// <param name="result"></param>
        //void isTemplate(result){

        //}

        /// <summary>
        /// The query parameterableElements() returns the set of ParameterableElements that
        /// may be used as the parameteredElements for a TemplateParameter of this
        /// TemplateableElement. By default, this set includes all the ownedElements.
        /// Subclasses may override this operation if they choose to restrict the set of
        /// ParameterableElements.
        /// </summary>
        /// <param name="result"></param>
        //ParameterableElement parameterableElements(ParameterableElement result){

        //	return null;
        //}
    }
} //end namespace CommonStructure