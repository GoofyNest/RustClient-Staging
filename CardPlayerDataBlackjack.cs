public class CardPlayerDataBlackjack : CardPlayerData // TypeDefIndex: 13828
{
	public List<PlayingCard> SplitCards;
	public int splitBetThisRound;
	public int insuranceBetThisRound;
	public bool playingSplitCards;


	public void .ctor(int mountIndex, bool isServer) { }

	public override void Dispose() { }

	public override int GetTotalBetThisRound() { }

	public override List<PlayingCard> GetSecondaryCards() { }

	public override void Load(CardGame msg) { }

}

