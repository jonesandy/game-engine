﻿using Xunit;

namespace GameEngine.Tests
{
    [Trait("Category", "NonPlayer")]
    public class NonPlayerCharacterShould
    {
        [Trait("Theory", "InlineData")]
        [Theory]
        [InlineData(0, 100)]
        [InlineData(1, 99)]
        [InlineData(50, 50)]
        [InlineData(101, 1)]
        public void TakeDamage(int damage, int expectedHealth)
        {
            NonPlayerCharacter sut = new NonPlayerCharacter();

            sut.TakeDamage(damage);

            Assert.Equal(expectedHealth, sut.Health);
        }
    }
}