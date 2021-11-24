using Microsoft.VisualStudio.TestTools.UnitTesting;
using Transport.Entities.Engines;

namespace Transport.Tests
{
    [TestClass]
    public class InternalCombustionEngineTest
    {
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void EngineVolumeLessThan0()
        {
            float volume = (float)-1.5;
            Internal—ombustionEngine engine = new(volume);
        }
    }
}
