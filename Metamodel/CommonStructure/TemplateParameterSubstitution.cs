///////////////////////////////////////////////////////////
//  TemplateParameterSubstitution.cs
//  Implementation of the Class TemplateParameterSubstitution
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 22:00:15
//  Original author: ??????
///////////////////////////////////////////////////////////

namespace UML.CommonStructure
{
    /// <summary>
    ///     A TemplateParameterSubstitution relates the actual parameter to a formal
    ///     TemplateParameter as part of a template binding.
    /// </summary>
    public interface TemplateParameterSubstitution : Element
    {
        /// <summary>
        ///     The formal TemplateParameter that is associated with this
        ///     TemplateParameterSubstitution.
        /// </summary>
        TemplateParameter formal { get; set; }

        /// <summary>
        ///     The ParameterableElement that is owned by this TemplateParameterSubstitution as
        ///     its actual parameter.
        /// </summary>
        ParameterableElement ownedActual { get; set; }

        /// <summary>
        ///     The ParameterableElement that is the actual parameter for this
        ///     TemplateParameterSubstitution.
        /// </summary>
        ParameterableElement actual { get; set; }
    }
} //end namespace CommonStructure