public class BlackjackSmallScreenUI : FacepunchBehaviour // TypeDefIndex: 12644
{
	[SerializeField]
	private Canvas notInGameDisplay;
	[SerializeField]
	private Canvas inGameDisplay;
	[SerializeField]
	private RustText cardCountText;
	[SerializeField]
	private RustText betText;
	[SerializeField]
	private RustText splitBetText;
	[SerializeField]
	private RustText insuranceText;
	[SerializeField]
	private RustText bankText;
	[SerializeField]
	private RustText splitText;
	[SerializeField]
	private Canvas infoTextCanvas;
	[SerializeField]
	private RustText inGameText;
	[SerializeField]
	private RustText notInGameText;
	[SerializeField]
	private HorizontalLayoutGroup cardsLayout;
	[SerializeField]
	private BlackjackScreenCardUI[] cards;
	[SerializeField]
	private BlackjackScreenInputUI[] inputs;
	[SerializeField]
	private Translate.Phrase phraseBust;
	[SerializeField]
	private Translate.Phrase phraseBet;
	[SerializeField]
	private Translate.Phrase phrasePlaceYourBet;
	[SerializeField]
	private Translate.Phrase phraseStandoff;
	[SerializeField]
	private Translate.Phrase phraseYouWin;
	[SerializeField]
	private Translate.Phrase phraseYouLose;
	[SerializeField]
	private Translate.Phrase phraseWaitingForOtherPlayers;
	[SerializeField]
	private Translate.Phrase phraseAddFunds;
	[SerializeField]
	private Translate.Phrase phraseWaitingForPlayer;
	[SerializeField]
	private Translate.Phrase phraseSplitStored;
	[SerializeField]
	private Translate.Phrase phraseSplitActive;
	[SerializeField]
	private Translate.Phrase phraseHand;
	public BlackjackMachine blackjack;


	protected void OnEnable() { }

	public void RefreshVisuals(BlackjackController controller, CardPlayerDataBlackjack pdBlackjack) { }

	private void RefreshInGameDisplay(BlackjackController controller, CardPlayerDataBlackjack pdBlackjack, bool betweenRounds) { }

	private string GetResultText(BlackjackController.BlackjackRoundResult result) { }

	private void RefreshNoGameDisplay(BlackjackController controller, CardPlayerData pData) { }

	private void ShowInGameDisplay() { }

	private void ShowNotInGameDisplay() { }

	private void ShowGameDisplay(bool inGame) { }

	public void .ctor() { }

}

