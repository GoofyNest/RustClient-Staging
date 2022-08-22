public class PlayingCard // TypeDefIndex: 12016
{	// Fields
	public readonly Suit Suit; // 0x10
	public readonly Rank Rank; // 0x14
	public static PlayingCard[] cards; // 0x0

	// Methods

	// RVA: 0x45E8C0 Offset: 0x45CEC0 VA: 0x18045E8C0
	private void .ctor(Suit suit, Rank rank) { }

	// RVA: 0x8D6BD0 Offset: 0x8D51D0 VA: 0x1808D6BD0
	public static PlayingCard GetCard(Suit suit, Rank rank) { }

	// RVA: 0x8D6AA0 Offset: 0x8D50A0 VA: 0x1808D6AA0
	public static PlayingCard GetCard(int suit, int rank) { }

	// RVA: 0x8D6B40 Offset: 0x8D5140 VA: 0x1808D6B40
	public static PlayingCard GetCard(int index) { }

	// RVA: 0x8D6D80 Offset: 0x8D5380 VA: 0x1808D6D80
	public int GetIndex() { }

	// RVA: 0x8D6DE0 Offset: 0x8D53E0 VA: 0x1808D6DE0
	public static int GetIndex(Suit suit, Rank rank) { }

	// RVA: 0x8D6CB0 Offset: 0x8D52B0 VA: 0x1808D6CB0
	public int GetEvaluationValue() { }

	// RVA: 0x8D6DF0 Offset: 0x8D53F0 VA: 0x1808D6DF0
	private int GetSuitCode() { }

	// RVA: 0x8D69B0 Offset: 0x8D4FB0 VA: 0x1808D69B0
	private static PlayingCard[] GenerateAllCards() { }

	// RVA: 0x8D6E20 Offset: 0x8D5420 VA: 0x1808D6E20
	private static void .cctor() { }

}

