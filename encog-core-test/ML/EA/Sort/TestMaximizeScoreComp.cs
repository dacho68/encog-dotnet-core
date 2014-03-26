//
// Encog(tm) Core v3.2 - .Net Version
// http://www.heatonresearch.com/encog/
//
// Copyright 2008-2014 Heaton Research, Inc.
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
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Encog.ML.EA.Genome;
using Encog.ML.Genetic.Genome;

namespace Encog.ML.EA.Sort
{
    [TestClass]
    public class TestMaximizeScoreComp
    {
        [TestMethod]
        public void TestCompare()
        {

            BasicGenome genome1 = new IntegerArrayGenome(1);
            genome1.AdjustedScore = 10;
            genome1.Score = 4;

            BasicGenome genome2 = new IntegerArrayGenome(1);
            genome2.AdjustedScore = 4;
            genome2.Score = 10;

            MaximizeScoreComp comp = new MaximizeScoreComp();

            Assert.IsTrue(comp.Compare(genome1, genome2) > 0);
        }

        [TestMethod]
        public void TestIsBetterThan()
        {
            MaximizeScoreComp comp = new MaximizeScoreComp();
            Assert.IsFalse(comp.IsBetterThan(10, 20));
        }

        [TestMethod]
        public void TestShouldMinimize()
        {
            MaximizeScoreComp comp = new MaximizeScoreComp();
            Assert.IsFalse(comp.ShouldMinimize);
        }

        [TestMethod]
        public void TestApplyBonus()
        {
            MaximizeScoreComp comp = new MaximizeScoreComp();
            Assert.AreEqual(11, comp.ApplyBonus(10, 0.1), EncogFramework.DefaultDoubleEqual);
        }

        [TestMethod]
        public void TestApplyPenalty()
        {
            MaximizeScoreComp comp = new MaximizeScoreComp();
            Assert.AreEqual(9, comp.ApplyPenalty(10, 0.1), EncogFramework.DefaultDoubleEqual);
        }
    }
}
