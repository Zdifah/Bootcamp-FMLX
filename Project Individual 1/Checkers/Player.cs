namespace Checkers;

public class Player: IPlayer
{
	bool isTurn;
	public string Nickname {get; private set;}
	public string Id {get; private set;}
	public int RemainPiece { get; private set; }	
	public Player(string nickname, string id)
	{
		this.Nickname = nickname;
		this.Id = id;
	}
}
