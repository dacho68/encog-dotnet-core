//
// Encog(tm) Core v3.2 - .Net Version
// http://www.heatonresearch.com/encog/
//
// Copyright 2008-2013 Heaton Research, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//   
// For more information on Heaton Research copyrights, licenses 
// and trademarks visit:
// http://www.heatonresearch.com/copyright
//
using System;
using System.Collections.Generic;

namespace Encog.ML.Factory.Parse
{
    /// <summary>
    /// Holds the parse results for one layer.
    /// </summary>
    ///
    public class ArchitectureLayer
    {
        /// <summary>
        /// Holds any paramaters that were specified for the layer.
        /// </summary>
        ///
        private readonly IDictionary<String, String> _paras;

        /// <summary>
        /// Construct the object.
        /// </summary>
        public ArchitectureLayer()
        {
            _paras = new Dictionary<String, String>();
        }


        /// <value>the count to set</value>
        public int Count { get; set; }


        /// <value>the name to set</value>
        public String Name { get; set; }


        /// <value>the params</value>
        public IDictionary<String, String> Params
        {
            get { return _paras; }
        }


        /// <value>the bias to set</value>
        public bool Bias { get; set; }


        /// <value>the usedDefault to set</value>
        public bool UsedDefault { get; set; }
    }
}
