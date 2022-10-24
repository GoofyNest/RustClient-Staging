public class BlackjackUI : MonoBehaviour, CardGameUI.ICardGameSubUI // TypeDefIndex: 12615
{
	[SerializeField] 
	private Image[] playerCardImages; 
	[SerializeField] 
	private Image[] dealerCardImages; 
	[SerializeField] 
	private Image[] splitCardImages; 
	[SerializeField] 
	private Image[] playerCardBackings; 
	[SerializeField] 
	private Image[] dealerCardBackings; 
	[SerializeField] 
	private Image[] splitCardBackings; 
	[SerializeField] 
	private CardGamePlayerWidget[] playerWidgets; 
	[SerializeField] 
	private GameObject dealerValueObj; 
	[SerializeField] 
	private RustText dealerValueText; 
	[SerializeField] 
	private Translate.Phrase phrasePlaceYourBet; 
	[SerializeField] 
	private Translate.Phrase phraseHit; 
	[SerializeField] 
	private Translate.Phrase phraseStand; 
	[SerializeField] 
	private Translate.Phrase phraseSplit; 
	[SerializeField] 
	private Translate.Phrase phraseDouble; 
	[SerializeField] 
	private Translate.Phrase phraseBust; 
	[SerializeField] 
	private Translate.Phrase phraseBlackjack; 
	[SerializeField] 
	private Translate.Phrase phraseStandoff; 
	[SerializeField] 
	private Translate.Phrase phraseYouWin; 
	[SerializeField] 
	private Translate.Phrase phraseYouLose; 
	[SerializeField] 
	private Translate.Phrase phraseWaitingForOtherPlayers; 
	[SerializeField] 
	private Sprite insuranceIcon; 
	[SerializeField] 
	private Sprite noIcon; 
	[SerializeField] 
	private Color bustTextColour; 
	[CompilerGeneratedAttribute] 
	private int <DynamicBetAmount>k__BackingField; 
	private ulong lastActionId; 
	private List<PlayingCard> localPlayerCards; 

	public int DynamicBetAmount { get; set; }


	[CompilerGeneratedAttribute] 
	public int get_DynamicBetAmount() { }

	[CompilerGeneratedAttribute] 
	private void set_DynamicBetAmount(int value) { }

	public void UpdateInGameUI(CardGameUI ui, CardGameController game) { }

	public string GetSecondaryInfo(CardGameUI ui, CardGameController game, out CardGameUI.InfoTextUI.Attitude attitude) { }

	public void UpdateInGameUI_NoPlayer(CardGameUI ui) { }

	public void .ctor() { }

}

private sealed class BlackjackUI.<>c // TypeDefIndex: 12616
{
	public static readonly BlackjackUI.<>c <>9; 
	public static Predicate<CardGameUI.KeycodeWithAction> <>9__29_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <UpdateInGameUI>b__29_0(CardGameUI.KeycodeWithAction p) { }

}
