using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Umut.Atmaca.LeetCode.UnitTest {
    public abstract class DataGenerator : IEnumerable<object[]> {

        private readonly List<object[]> data;
        protected DataGenerator() {
            data = GetData();
        }

        public IEnumerator<object[]> GetEnumerator() {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }
        protected abstract List<object[]> GetData();
        
    }
}
