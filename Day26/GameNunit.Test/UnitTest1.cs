
namespace GameNunit.Test;
using MyGame;
using Moq;
using System.Collections.Generic;
using System.Linq;

[TestFixture]
public class GameControllerTest
{
	private GameController game;
	private Mock<IBoard> _board;
	private Mock<ICard> _card;
	private Mock<IPlayer> _player;
	
	[SetUp]
	public void Setup()
	{
		_board = new Mock<IBoard>();
		_card = new Mock<ICard>();
		_player = new Mock<IPlayer>();
		
		game = new GameController(_player.Object, _board.Object, _card.Object);
	}

	[Test]
	public void AddCard_CardAddedSuccessfullyReturnTrue_PlayerExit()
	{
		// arrange
		_card.Setup(x => x.SetStatus(It.IsAny<CardStatus>()));
		
		// act
		bool actual = game.AddCards(_player.Object, _card.Object);
		
		// assert
		Assert.IsTrue(actual);
		_card.Verify(x => x.SetStatus(It.IsAny<CardStatus>()), Times.Once);
	}
	
	[Test]
	public void AddCards_ReturnsFalse_PlayerNotExists()
	{
		IPlayer falsePlayer = new Mock<IPlayer>().Object;
		
		bool actual = game.AddCards(falsePlayer, _card.Object);
		
		Assert.IsFalse(actual);
	}
	
	// [TestCaseSource(typeof(TCS), nameof(TCS.Data))]
	// public void RemoveCard_ShouldReturnTrue(IPlayer player, ICard card)
	// {
	// 	bool actual = game.RemoveCard(player, card);
		
	// 	Assert.IsTrue(actual);
	// }
}

// public class TCS
// {
// 	public Mock<IBoard> mockBoard = new Mock<IBoard>();
// 	public Mock<ICard> mockCard = new Mock<ICard>();
// 	public Mock<IPlayer> mockPlayer = new Mock<IPlayer>();
	
// 	// [SetUp]
// 	// public void Setup()
// 	// {
// 	// 	GameController gameTested = new(mockPlayer.Object, mockBoard.Object);
// 	// }
	
// 	public  object[] Data = new object[]
// 	{
// 		new object[] {mockPlayer.Object, mockCard.Object}
// 		// new object[] {new Mock<IPlayer>().Object, _card.Setup(x => x.SetStatus(It.IsAny<CardStatus>())).Object}
// 		// new object[] {_player.Object, new Mock<ICard>().Object},
// 		// new object[] {}
// 	};
// }