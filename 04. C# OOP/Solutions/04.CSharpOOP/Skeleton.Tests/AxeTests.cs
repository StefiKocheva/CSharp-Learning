using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    [Test]
    public void TestIfWeaponLosesDurabilityAfterEachAttack()
    {
        // Arrange
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(10, 10);

        // Act
        axe.Attack(dummy);

        // Assert
        Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe is broken.");
    }
}