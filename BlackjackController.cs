public class BlackjackController : CardGameController // TypeDefIndex: 13770
{
	public List<PlayingCard> dealerCards; 
	public const float BLACKJACK_PAYOUT_RATIO = 1,5;
	public const float INSURANCE_PAYOUT_RATIO = 2;
	[CompilerGeneratedAttribute] 
	private BlackjackController.BlackjackInputOption <LastAction>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ulong <LastActionTarget>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <LastActionValue>k__BackingField; 
	public BlackjackController.DealerOpinion dealerRoundOpinion; 

	public override int MinPlayers { get; }
	public override int MinBuyIn { get; }
	public override int MaxBuyIn { get; }
	public override int MinToPlay { get; }
	public override int TimeBetweenRounds { get; }
	public BlackjackController.BlackjackInputOption LastAction { get; set; }
	public ulong LastActionTarget { get; set; }
	public int LastActionValue { get; set; }
	public bool AllBetsPlaced { get; }


	public void .ctor(BaseCardGameEntity owner) { }

	public override int get_MinPlayers() { }

	public override int get_MinBuyIn() { }

	public override int get_MaxBuyIn() { }

	public override int get_MinToPlay() { }

	public override int get_TimeBetweenRounds() { }

	[CompilerGeneratedAttribute] 
	public BlackjackController.BlackjackInputOption get_LastAction() { }

	[CompilerGeneratedAttribute] 
	private void set_LastAction(BlackjackController.BlackjackInputOption value) { }

	[CompilerGeneratedAttribute] 
	public ulong get_LastActionTarget() { }

	[CompilerGeneratedAttribute] 
	private void set_LastActionTarget(ulong value) { }

	[CompilerGeneratedAttribute] 
	public int get_LastActionValue() { }

	[CompilerGeneratedAttribute] 
	private void set_LastActionValue(int value) { }

	public bool get_AllBetsPlaced() { }

	protected override int GetFirstPlayerRelIndex(bool startOfRound) { }

	public override List<PlayingCard> GetTableCards() { }

	public void InputsToList(int availableInputs, List<BlackjackController.BlackjackInputOption> result) { }

	public bool WaitingForOtherPlayer(CardPlayerData pData) { }

	public int GetCardsValue(List<PlayingCard> cards, BlackjackController.CardsValueMode mode) { }

	public int GetOptimalCardsValue(List<PlayingCard> cards) { }

	public int GetCardValue(PlayingCard card, BlackjackController.CardsValueMode mode) { }

	public bool Has21(List<PlayingCard> cards) { }

	public bool HasBlackjack(List<PlayingCard> cards) { }

	public bool HasBusted(List<PlayingCard> cards) { }

	private bool CanSplit(CardPlayerData pData) { }

	private bool HasAnyAces(List<PlayingCard> cards) { }

	private bool CanDoubleDown(CardPlayerData pData) { }

	private bool CanTakeInsurance(CardPlayerData pData) { }

	private bool HasSplit(CardPlayerData pData) { }

	public override void Load(CardGame syncData) { }

	protected override void SubGetAvailableInputs(ref List<CardGameUI.KeycodeWithAction> curAvailableInputs) { }

	public BlackjackController.BlackjackRoundResult GetRoundResultFor(ulong playerId) { }

	public int GetScrapWonFor(ulong playerId) { }

	private BlackjackController.DealerOpinion GetDealerResultOpinion(List<CardGame.RoundResults.Result> results, List<PlayingCard> dCrds) { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__49_6() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__49_0() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__49_1() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__49_2() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__49_3() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__49_4() { }

	[CompilerGeneratedAttribute] 
	private void <SubGetAvailableInputs>b__49_5() { }

}

public enum BlackjackController.BlackjackInputOption // TypeDefIndex: 13771
{
	public int value__; 
	public const BlackjackController.BlackjackInputOption None = 0;
	public const BlackjackController.BlackjackInputOption SubmitBet = 1;
	public const BlackjackController.BlackjackInputOption Hit = 2;
	public const BlackjackController.BlackjackInputOption Stand = 4;
	public const BlackjackController.BlackjackInputOption Split = 8;
	public const BlackjackController.BlackjackInputOption DoubleDown = 16;
	public const BlackjackController.BlackjackInputOption Insurance = 32;
	public const BlackjackController.BlackjackInputOption AllIn = 64;
	public const BlackjackController.BlackjackInputOption Abandon = 128;

}

public enum BlackjackController.BlackjackRoundResult // TypeDefIndex: 13772
{
	public int value__; 
	public const BlackjackController.BlackjackRoundResult NotInRound = 0;
	public const BlackjackController.BlackjackRoundResult Bust = 1;
	public const BlackjackController.BlackjackRoundResult Loss = 2;
	public const BlackjackController.BlackjackRoundResult Standoff = 3;
	public const BlackjackController.BlackjackRoundResult Win = 4;
	public const BlackjackController.BlackjackRoundResult BlackjackWin = 5;

}

public enum BlackjackController.CardsValueMode // TypeDefIndex: 13773
{
	public int value__; 
	public const BlackjackController.CardsValueMode Low = 0;
	public const BlackjackController.CardsValueMode High = 1;

}

public enum BlackjackController.DealerOpinion // TypeDefIndex: 13774
{
	public int value__; 
	public const BlackjackController.DealerOpinion Neutral = 0;
	public const BlackjackController.DealerOpinion Shocked = 1;
	public const BlackjackController.DealerOpinion Sad = 2;
	public const BlackjackController.DealerOpinion Cool = 3;
	public const BlackjackController.DealerOpinion Happy = 4;
	public const BlackjackController.DealerOpinion Love = 5;

}

