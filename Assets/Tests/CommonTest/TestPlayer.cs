using System.Collections;
using FluentAssertions;
using Folder__Two;
using Folder_One;
using NSubstitute;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestPlayer
{
    // // A Test behaves as an ordinary method
    // [Test]
    // public void TestPlayerSimplePasses()
    // {
    //     // Use the Assert class to test conditions
    // }

    // [Test]
    // public void WhenPressA_AndPlayerAt0_0_ThenMoveUp()
    // {
    //     // Arrange.
    //     var inventory = new InventoryScript();
    //
    //
    //     // Act.
    //
    //
    //     // Assert.
    //
    //     inventory.ItemsCount.Should().Be(1);

    // }
    [Test]
    public void WhenAddItem_AndInventoryIsEmpty_ThenItemCountShouldBe1()
    {
        // Arrange.
        var inventory = new InventoryScript();
        Item itemToStore = new Item(Substitute.For<ICounter>());
        
        // Act.
        inventory.PlaceItem(itemToStore);

        // Assert.
        inventory.ItemsCount.Should().Be(1);
    }
    //
    // [UnityTest]
    // public IEnumerator PlayerMovementTestWithEnumeratorPasses()
    // {
    //     // Use the Assert class to test conditions.
    //     var player = new GameObject().AddComponent<PlayerMovement>();
    //     var playerPosition = player.transform.position;
    //     var playerNewPosition = playerPosition.y + 1;
    //     
    //     // Act
    //     player.MoveUp();
    //     // Assert
    //
    //     Assert.Equals(player.transform.position, playerNewPosition);
    //     // Use yield to skip a frame.
    //     yield return null;
    // }
}
