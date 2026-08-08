using NUnit.Framework;

public class HealthTest
{
    [Test]
    public void SimpleHealthPassTest()
    {
        int playerHealth = 100;
        // 断言：验证玩家初始血量是否等于 100
        Assert.AreEqual(100, playerHealth);
    }
}