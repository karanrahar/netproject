using Xunit;
using System;
using FirstLib;

namespace FirstcoreProject{

    public class test
    {
        [Fact]
            public void TestName()
            {
                var ob = new Addition();
                Assert.Equal(ob.display(),"ok");
            }
    }

}