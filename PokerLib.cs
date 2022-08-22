public static class PokerLib // TypeDefIndex: 8226
{	// Fields
	public const int CLUB = 32768;
	public const int DIAMOND = 16384;
	public const int HEART = 8192;
	public const int SPADE = 4096;

	// Methods

	// RVA: 0x1073720 Offset: 0x1071D20 VA: 0x181073720
	public static int FindIt(int key) { }

	// RVA: 0x10739C0 Offset: 0x1071FC0 VA: 0x1810739C0
	public static void InitDeck(int[] deck) { }

	// RVA: 0x10736C0 Offset: 0x1071CC0 VA: 0x1810736C0
	public static int FindCard(int rank, int suit, int[] deck) { }

	// RVA: 0x1073130 Offset: 0x1071730 VA: 0x181073130
	public static ushort Eval5Cards(int c1, int c2, int c3, int c4, int c5) { }

	// RVA: 0x1073440 Offset: 0x1071A40 VA: 0x181073440
	public static ushort Eval5Hand(int[] hand) { }

	// RVA: 0x10734F0 Offset: 0x1071AF0 VA: 0x1810734F0
	public static ushort Eval7Hand(int[] hand) { }

	// RVA: 0x1073630 Offset: 0x1071C30 VA: 0x181073630
	public static PokerLib.PokerResult EvalToResultName(ushort eval) { }

	// RVA: 0x1073890 Offset: 0x1071E90 VA: 0x181073890
	public static string HandToString(int[] hand) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1073AD0 Offset: 0x10720D0 VA: 0x181073AD0
	internal static int <FindCard>g__Rank|6_0(int card) { }

}

public enum PokerLib.PokerResult // TypeDefIndex: 8227
{	// Fields
	public int value__; // 0x0
	public const PokerLib.PokerResult RoyalFlush = 0;
	public const PokerLib.PokerResult StraightFlush = 1;
	public const PokerLib.PokerResult FourOfAKind = 2;
	public const PokerLib.PokerResult FullHouse = 3;
	public const PokerLib.PokerResult Flush = 4;
	public const PokerLib.PokerResult Straight = 5;
	public const PokerLib.PokerResult ThreeOfAKind = 6;
	public const PokerLib.PokerResult TwoPair = 7;
	public const PokerLib.PokerResult Pair = 8;
	public const PokerLib.PokerResult HighCard = 9;

}

