using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyLosesHealthIfAttacked()
    {
        // Arrange
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(10, 10);

        // Act
        dummy.TakeAttack(axe.AttackPoints);

        // Assert
        Assert.That(dummy.Health, Is.EqualTo(0), "Dummy is dead.");
    }

    [Test]
    public void DeadDummyCanGiveXP()
    {
        // Arrange
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(0, 10);

        // Act
        var experience = dummy.GiveExperience();

        // Assert
        Assert.That(experience, Is.EqualTo(10), "Target is not dead.");
    }
}
