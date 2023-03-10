///////////////////////////////////////////////////////////
//  DestroyLinkAction.cs
//  Implementation of the Class DestroyLinkAction
//  Generated by Enterprise Architect
//  Created on:      31-???-2019 21:59:58
//  Original author: ??????
///////////////////////////////////////////////////////////

using System.Collections.Generic;

namespace UML.Actions
{
    /// <summary>
    ///     A DestroyLinkAction is a WriteLinkAction that destroys links (including link
    ///     objects).
    /// </summary>
    public interface DestroyLinkAction : WriteLinkAction
    {
        /// <summary>
        ///     The LinkEndData that the values of the Association ends for the links to be
        ///     destroyed.
        /// </summary>
        IEnumerable<LinkEndDestructionData> endData { get; set; }
    }
} //end namespace Actions