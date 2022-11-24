// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace ModelsInCadl.Models
{
    /// <summary> Model used only as input. </summary>
    public partial class InputModel
    {
        /// <summary> Initializes a new instance of InputModel. </summary>
        /// <param name="requiredString"></param>
        /// <param name="requiredInt"></param>
        /// <param name="requiredModel"></param>
        /// <param name="requiredIntCollection"></param>
        /// <param name="requiredStringCollection"></param>
        /// <param name="requiredModelCollection"></param>
        /// <param name="requiredModelRecord"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredString"/>, <paramref name="requiredModel"/>, <paramref name="requiredIntCollection"/>, <paramref name="requiredStringCollection"/>, <paramref name="requiredModelCollection"/> or <paramref name="requiredModelRecord"/> is null. </exception>
        public InputModel(string requiredString, int requiredInt, BaseModel requiredModel, IEnumerable<int> requiredIntCollection, IEnumerable<string> requiredStringCollection, IEnumerable<CollectionItem> requiredModelCollection, IDictionary<string, RecordItem> requiredModelRecord)
        {
            Argument.AssertNotNull(requiredString, nameof(requiredString));
            Argument.AssertNotNull(requiredModel, nameof(requiredModel));
            Argument.AssertNotNull(requiredIntCollection, nameof(requiredIntCollection));
            Argument.AssertNotNull(requiredStringCollection, nameof(requiredStringCollection));
            Argument.AssertNotNull(requiredModelCollection, nameof(requiredModelCollection));
            Argument.AssertNotNull(requiredModelRecord, nameof(requiredModelRecord));

            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredModel = requiredModel;
            RequiredIntCollection = requiredIntCollection.ToList();
            RequiredStringCollection = requiredStringCollection.ToList();
            RequiredModelCollection = requiredModelCollection.ToList();
            RequiredModelRecord = requiredModelRecord;
        }

        /// <summary> Gets the required string. </summary>
        public string RequiredString { get; }
        /// <summary> Gets the required int. </summary>
        public int RequiredInt { get; }
        /// <summary> Gets the required model. </summary>
        public BaseModel RequiredModel { get; }
        /// <summary> Gets the required int collection. </summary>
        public IList<int> RequiredIntCollection { get; }
        /// <summary> Gets the required string collection. </summary>
        public IList<string> RequiredStringCollection { get; }
        /// <summary> Gets the required model collection. </summary>
        public IList<CollectionItem> RequiredModelCollection { get; }
        /// <summary> Gets the required model record. </summary>
        public IDictionary<string, RecordItem> RequiredModelRecord { get; }
    }
}
