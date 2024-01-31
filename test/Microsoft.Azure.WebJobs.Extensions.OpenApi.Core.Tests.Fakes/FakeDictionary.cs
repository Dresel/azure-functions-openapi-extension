using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Tests.Fakes
{
    public class FakeDictionary : IEnumerable<KeyValuePair<string, FakeModel>>
    {
        public IEnumerator<KeyValuePair<string, FakeModel>> GetEnumerator() => Enumerable.Empty<KeyValuePair<string, FakeModel>>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
