using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests {
    public class Health_UnitTest {
        // A Test behaves as an ordinary method
        [Test]
        public void Health_TakeDamge () {
            //Arrange
            var health = new Health ();
            //Act
            health.TakeDamage (.5f);
            //Assert
            Assert.AreEqual (health.CurrentHP, .5f);
        }

        [Test]
        public void Health_HealHP () {
            //Arrange
            var health = new Health ();
            health.CurrentHP = .9f;
            //Act
            health.HealHP (0.1f);
            //Assert
            Assert.AreEqual (health.CurrentHP, 1.0f);
        }

        [Test]
        public void Health_HealHP_PastMaxHP () {
            //Arrange
            var health = new Health ();
            //Act
            health.HealHP (0.5f);
            //Assert
            Assert.AreEqual (health.CurrentHP, 1.0f);
        }
    }
}