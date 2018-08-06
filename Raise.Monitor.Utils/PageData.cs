using System.Collections.Generic;

namespace Raise.Monitor.Tools {
    public class PageData<T> where T : class {
        public List<T> Data {
            get; set;
        }

        public int? Total {
            get; set;
        }
    }
}
