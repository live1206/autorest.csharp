// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace CadlFirstTest.Models
{
    /// <summary> this is a roundtrip model. </summary>
    public partial class RoundTripModel
    {
        /// <summary> Initializes a new instance of RoundTripModel. </summary>
        /// <param name="requiredString"> Required string, illustrating a reference type property. </param>
        /// <param name="requiredInt"> Required int, illustrating a value type property. </param>
        /// <param name="requiredCollection"> Required collection of enums. </param>
        /// <param name="requiredDictionary"> Required dictionary of enums. </param>
        /// <param name="requiredModel"> Required model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredString"/>, <paramref name="requiredCollection"/>, <paramref name="requiredDictionary"/> or <paramref name="requiredModel"/> is null. </exception>
        public RoundTripModel(string requiredString, int requiredInt, IEnumerable<StringFixedEnum> requiredCollection, IDictionary<string, StringExtensibleEnum> requiredDictionary, Thing requiredModel)
        {
            Argument.AssertNotNull(requiredString, nameof(requiredString));
            Argument.AssertNotNull(requiredCollection, nameof(requiredCollection));
            Argument.AssertNotNull(requiredDictionary, nameof(requiredDictionary));
            Argument.AssertNotNull(requiredModel, nameof(requiredModel));

            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredCollection = requiredCollection.ToList();
            RequiredDictionary = requiredDictionary;
            RequiredModel = requiredModel;
            IntExtensibleEnumCollection = new ChangeTrackingList<IntExtensibleEnum>();
            FloatExtensibleEnumCollection = new ChangeTrackingList<FloatExtensibleEnum>();
            FloatFixedEnumCollection = new ChangeTrackingList<FloatFixedEnum>();
            IntFixedEnumCollection = new ChangeTrackingList<IntFixedEnum>();
        }

        /// <summary> Required string, illustrating a reference type property. </summary>
        public string RequiredString { get; }
        /// <summary> Required int, illustrating a value type property. </summary>
        public int RequiredInt { get; }
        /// <summary> Required collection of enums. </summary>
        public IList<StringFixedEnum> RequiredCollection { get; }
        /// <summary> Required dictionary of enums. </summary>
        public IDictionary<string, StringExtensibleEnum> RequiredDictionary { get; }
        /// <summary> Required model. </summary>
        public Thing RequiredModel { get; }
        /// <summary> this is an int based extensible enum. </summary>
        public IntExtensibleEnum? IntExtensibleEnum { get; set; }
        /// <summary> this is a collection of int based extensible enum. </summary>
        public IList<IntExtensibleEnum> IntExtensibleEnumCollection { get; }
        /// <summary> this is a float based extensible enum. </summary>
        public FloatExtensibleEnum? FloatExtensibleEnum { get; set; }
        /// <summary> this is a collection of float based extensible enum. </summary>
        public IList<FloatExtensibleEnum> FloatExtensibleEnumCollection { get; }
        /// <summary> this is a float based fixed enum. </summary>
        public FloatFixedEnum? FloatFixedEnum { get; set; }
        /// <summary> this is a collection of float based fixed enum. </summary>
        public IList<FloatFixedEnum> FloatFixedEnumCollection { get; }
        /// <summary> this is a int based fixed enum. </summary>
        public IntFixedEnum? IntFixedEnum { get; set; }
        /// <summary> this is a collection of int based fixed enum. </summary>
        public IList<IntFixedEnum> IntFixedEnumCollection { get; }
        /// <summary> this is a string based fixed enum. </summary>
        public StringFixedEnum? StringFixedEnum { get; set; }
    }
}