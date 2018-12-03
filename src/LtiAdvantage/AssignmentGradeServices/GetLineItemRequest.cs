﻿namespace LtiAdvantage.AssignmentGradeServices
{
    /// <summary>
    /// Represents a GetLineItem request.
    /// </summary>
    public class GetLineItemRequest
    {
        /// <summary>
        /// Initialize a new instance of the class.
        /// </summary>
        public GetLineItemRequest(string contextId, string id)
        {
            ContextId = contextId;
            Id = id;
        }

        /// <summary>
        /// Get or set the context id.
        /// </summary>
        public string ContextId { get; set; }

        /// <summary>
        /// Get or set the line item Id.
        /// </summary>
        public string Id { get; }
    }
}
