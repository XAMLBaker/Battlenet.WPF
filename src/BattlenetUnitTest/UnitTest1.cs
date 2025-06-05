using Battlenet.Service;

namespace BattlenetUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BattlenetGameLoad webCrollwer = new BattlenetGameLoad();

            webCrollwer.Load ();
        }
    }
}