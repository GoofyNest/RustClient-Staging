public class CardGamePlayerWidget : MonoBehaviour // TypeDefIndex: 12626
{
	[SerializeField] 
	private GameObjectRef cardImageSmallPrefab; 
	[SerializeField] 
	private GameObjectRef cardImageSmallerPrefab; 
	[SerializeField] 
	private RawImage avatar; 
	[SerializeField] 
	private RustText playerName; 
	[SerializeField] 
	private RustText scrapTotal; 
	[SerializeField] 
	private RustText betTotal; 
	[SerializeField] 
	private Image background; 
	[SerializeField] 
	private Color inactiveBackground; 
	[SerializeField] 
	private Color activeBackground; 
	[SerializeField] 
	private Color foldedBackground; 
	[SerializeField] 
	private Color winnerBackground; 
	[SerializeField] 
	private Animation actionShowAnimation; 
	[SerializeField] 
	private RustText actionText; 
	[SerializeField] 
	private Sprite noIcon; 
	[SerializeField] 
	private Sprite canSeeIcon; 
	[SerializeField] 
	private Sprite cannotSeeIcon; 
	[SerializeField] 
	private Image cornerIcon; 
	[SerializeField] 
	private Transform cardDisplayParent; 
	[SerializeField] 
	private CardGamePlayerWidget.BetDisplayType betDisplayType; 
	[SerializeField] 
	private GameObject circle; 
	[SerializeField] 
	private RustText circleText; 
	private Color normalCardColour; 
	private Color fadedCardColour; 
	private List<Image> mainCards; 
	private List<Image> pocketCards; 
	private StringBuilder betString; 
	private List<PlayingCard> emptyCardList; 
	private TimeSince lastHandResultShow; 


	protected void Awake() { }

	protected void OnDisable() { }

	public void PopulateWidget(CardPlayerData pData, CardGamePlayerWidget.PlayerUIState uiState, bool isLocalPlayer, bool roundInProgress, string circleString = "") { }

	public void PopulateWidget(CardPlayerData pData, CardGamePlayerWidget.PlayerUIState uiState, bool isLocalPlayer, bool roundInProgress, Sprite iconSprite, string circleString = "") { }

	public void DisplayInputAction(Translate.Phrase phrase, int value) { }

	public void DisplayResultAnimation(Translate.Phrase phrase) { }

	private void SetCardCount(int newCount, bool main) { }

	private void SetCardImages(List<Image> images, List<PlayingCard> cards, bool mainCards, bool leftRoundEarly) { }

	public void .ctor() { }

}

private enum CardGamePlayerWidget.BetDisplayType // TypeDefIndex: 12627
{
	public int value__; 
	public const CardGamePlayerWidget.BetDisplayType BetThisTurn = 0;
	public const CardGamePlayerWidget.BetDisplayType BetThisRound = 1;

}

public enum CardGamePlayerWidget.PlayerUIState // TypeDefIndex: 12628
{
	public int value__; 
	public const CardGamePlayerWidget.PlayerUIState Default = 0;
	public const CardGamePlayerWidget.PlayerUIState TheirTurn = 1;
	public const CardGamePlayerWidget.PlayerUIState Winner = 2;
	public const CardGamePlayerWidget.PlayerUIState Neutral = 3;
	public const CardGamePlayerWidget.PlayerUIState Loser = 4;
	public const CardGamePlayerWidget.PlayerUIState OutOfRound = 5;

}

