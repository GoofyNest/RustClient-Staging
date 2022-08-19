public class PlayingCard // TypeDefIndex: 12016
{	// Fields
	public readonly Suit Suit; // 0x10
	public readonly Rank Rank; // 0x14
	public static PlayingCard[] cards; // 0x0

	// Methods

	// RVA: 0x45E8C0 Offset: 0x45CEC0 VA: 0x18045E8C0
	private void .ctor(Suit suit, Rank rank) { }

	// RVA: 0x8D6AC0 Offset: 0x8D50C0 VA: 0x1808D6AC0
	public static PlayingCard GetCard(Suit suit, Rank rank) { }

	// RVA: 0x8D6990 Offset: 0x8D4F90 VA: 0x1808D6990
	public static PlayingCard GetCard(int suit, int rank) { }

	// RVA: 0x8D6A30 Offset: 0x8D5030 VA: 0x1808D6A30
	public static PlayingCard GetCard(int index) { }

	// RVA: 0x8D6C70 Offset: 0x8D5270 VA: 0x1808D6C70
	public int GetIndex() { }

	// RVA: 0x8D6CD0 Offset: 0x8D52D0 VA: 0x1808D6CD0
	public static int GetIndex(Suit suit, Rank rank) { }

	// RVA: 0x8D6BA0 Offset: 0x8D51A0 VA: 0x1808D6BA0
	public int GetEvaluationValue() { }

	// RVA: 0x8D6CE0 Offset: 0x8D52E0 VA: 0x1808D6CE0
	private int GetSuitCode() { }

	// RVA: 0x8D68A0 Offset: 0x8D4EA0 VA: 0x1808D68A0
	private static PlayingCard[] GenerateAllCards() { }

	// RVA: 0x8D6D10 Offset: 0x8D5310 VA: 0x1808D6D10
	private static void .cctor() { }

}

