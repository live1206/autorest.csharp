// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace CognitiveSearch.Models
{
    /// <summary> Divides text using language-specific rules and reduces words to their base forms. </summary>
    public partial class MicrosoftLanguageStemmingTokenizer : Tokenizer
    {
        /// <summary> Initializes a new instance of MicrosoftLanguageStemmingTokenizer. </summary>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public MicrosoftLanguageStemmingTokenizer(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            OdataType = "#Microsoft.Azure.Search.MicrosoftLanguageStemmingTokenizer";
        }

        /// <summary> Initializes a new instance of MicrosoftLanguageStemmingTokenizer. </summary>
        /// <param name="odataType"> Identifies the concrete type of the tokenizer. </param>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="maxTokenLength"> The maximum token length. Tokens longer than the maximum length are split. Maximum token length that can be used is 300 characters. Tokens longer than 300 characters are first split into tokens of length 300 and then each of those tokens is split based on the max token length set. Default is 255. </param>
        /// <param name="isSearchTokenizer"> A value indicating how the tokenizer is used. Set to true if used as the search tokenizer, set to false if used as the indexing tokenizer. Default is false. </param>
        /// <param name="language"> The language to use. The default is English. </param>
        internal MicrosoftLanguageStemmingTokenizer(string odataType, string name, int? maxTokenLength, bool? isSearchTokenizer, MicrosoftStemmingTokenizerLanguage? language) : base(odataType, name)
        {
            MaxTokenLength = maxTokenLength;
            IsSearchTokenizer = isSearchTokenizer;
            Language = language;
            OdataType = odataType ?? "#Microsoft.Azure.Search.MicrosoftLanguageStemmingTokenizer";
        }

        /// <summary> The maximum token length. Tokens longer than the maximum length are split. Maximum token length that can be used is 300 characters. Tokens longer than 300 characters are first split into tokens of length 300 and then each of those tokens is split based on the max token length set. Default is 255. </summary>
        public int? MaxTokenLength { get; set; }
        /// <summary> A value indicating how the tokenizer is used. Set to true if used as the search tokenizer, set to false if used as the indexing tokenizer. Default is false. </summary>
        public bool? IsSearchTokenizer { get; set; }
        /// <summary> The language to use. The default is English. </summary>
        public MicrosoftStemmingTokenizerLanguage? Language { get; set; }
    }
}