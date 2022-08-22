public class PlayingCard // TypeDefIndex: 12016
{	// Fields
	public readonly Suit Suit; // 0x10
	public readonly Rank Rank; // 0x14
	public static PlayingCard[] cards; // 0x0

	// Methods

	// RVA: 0x45E8C0 Offset: 0x45CEC0 VA: 0x18045E8C0
	private void .ctor(Suit suit, Rank rank) { }

	// RVA: 0x8D70E0 Offset: 0x8D56E0 VA: 0x1808D70E0
	public static PlayingCard GetCard(Suit suit, Rank rank) { }

	// RVA: 0x8D6FB0 Offset: 0x8D55B0 VA: 0x1808D6FB0
	public static PlayingCard GetCard(int suit, int rank) { }

	// RVA: 0x8D7050 Offset: 0x8D5650 VA: 0x1808D7050
	public static PlayingCard GetCard(int index) { }

	// RVA: 0x8D7290 Offset: 0x8D5890 VA: 0x1808D7290
	public int GetIndex() { }

	// RVA: 0x8D72F0 Offset: 0x8D58F0 VA: 0x1808D72F0
	public static int GetIndex(Suit suit, Rank rank) { }

	// RVA: 0x8D71C0 Offset: 0x8D57C0 VA: 0x1808D71C0
	public int GetEvaluationValue() { }

	// RVA: 0x8D7300 Offset: 0x8D5900 VA: 0x1808D7300
	private int GetSuitCode() { }

	// RVA: 0x8D6EC0 Offset: 0x8D54C0 VA: 0x1808D6EC0
	private static PlayingCard[] GenerateAllCards() { }

	// RVA: 0x8D7330 Offset: 0x8D5930 VA: 0x1808D7330
	private static void .cctor() { }

}

