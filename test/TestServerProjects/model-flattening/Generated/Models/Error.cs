// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace model_flattening.Models
{
    /// <summary> The Error. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        internal Error()
        {
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="status"> . </param>
        /// <param name="message"> . </param>
        /// <param name="parentError"> . </param>
        internal Error(int? status, string message, Error parentError)
        {
            Status = status;
            Message = message;
            ParentError = parentError;
        }

        public int? Status { get; }
        public string Message { get; }
        public Error ParentError { get; }
    }
}
