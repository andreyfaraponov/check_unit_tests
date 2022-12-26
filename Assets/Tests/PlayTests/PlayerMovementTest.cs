using System.Collections;
using Folder_One;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using FluentAssertions;

namespace Tests.PlayTests
{
	using System.Linq;
	using UnityEngine.UI;

	public class PlayerMovementTest
	{
		[UnityTest]
		public IEnumerator PlayerMovementTestWithEnumeratorPasses()
		{
			// Use the Assert class to test conditions.
			var player = new GameObject().AddComponent<PlayerMovement>();
			var playerNewPosition = player.transform.position;
			playerNewPosition.y += 1;

			// Act
			player.MoveUp();
			yield return new WaitForSeconds(PlayerMovement.MoveAnimationTimeSeconds);


			// Assert


			player.transform.position.Should().Be(playerNewPosition);

			// Use yield to skip a frame.
		}

		[UnityTest]
		public IEnumerator WhenPlayerMoveDown_AndStaysInCenter_ThenPositionShouldBeY_Minus_One()
		{
			// Arrange.
			var player = new GameObject().AddComponent<PlayerMovement>();
			var playerNewPosition = player.transform.position;
			playerNewPosition.y -= 1;

			// Act.
			player.MoveDown();
			yield return new WaitForSeconds(PlayerMovement.MoveAnimationTimeSeconds);

			// Assert.
			player.transform.position.Should().Be(playerNewPosition);
		}
		
		[UnityTest]
		public IEnumerator WhenPlayerMoveLeft_AndStaysInCenter_ThenPositionShouldBeX_Minus_One()
		{
			// Arrange.
			var player = new GameObject().AddComponent<PlayerMovement>();
			var playerNewPosition = player.transform.position;
			playerNewPosition.x -= 1;

			// Act.
			player.MoveLeft();
			yield return new WaitForSeconds(PlayerMovement.MoveAnimationTimeSeconds);

			// Assert.
			player.transform.position.Should().Be(playerNewPosition);
		}
		
		[UnityTest]
		public IEnumerator WhenPlayerMoveRight_AndStaysInCenter_ThenPositionShouldBeX_Plus_One()
		{
			// Arrange.
			var player = new GameObject().AddComponent<PlayerMovement>();
			var playerNewPosition = player.transform.position;
			playerNewPosition.x += 1;

			// Act.
			player.MoveRight();
			yield return new WaitForSeconds(PlayerMovement.MoveAnimationTimeSeconds);

			// Assert.
			player.transform.position.Should().Be(playerNewPosition);
		}
	}
}