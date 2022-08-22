public static class PokerLib // TypeDefIndex: 8226
{	// Fields
	public const int CLUB = 32768;
	public const int DIAMOND = 16384;
	public const int HEART = 8192;
	public const int SPADE = 4096;

	// Methods

	// RVA: 0x1074450 Offset: 0x1072A50 VA: 0x181074450
	public static int FindIt(int key) { }

	// RVA: 0x10746F0 Offset: 0x1072CF0 VA: 0x1810746F0
	public static void InitDeck(int[] deck) { }

	// RVA: 0x10743F0 Offset: 0x10729F0 VA: 0x1810743F0
	public static int FindCard(int rank, int suit, int[] deck) { }

	// RVA: 0x1073E60 Offset: 0x1072460 VA: 0x181073E60
	public static ushort Eval5Cards(int c1, int c2, int c3, int c4, int c5) { }

	// RVA: 0x1074170 Offset: 0x1072770 VA: 0x181074170
	public static ushort Eval5Hand(int[] hand) { }

	// RVA: 0x1074220 Offset: 0x1072820 VA: 0x181074220
	public static ushort Eval7Hand(int[] hand) { }

	// RVA: 0x1074360 Offset: 0x1072960 VA: 0x181074360
	public static PokerLib.PokerResult EvalToResultName(ushort eval) { }

	// RVA: 0x10745C0 Offset: 0x1072BC0 VA: 0x1810745C0
	public static string HandToString(int[] hand) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1074800 Offset: 0x1072E00 VA: 0x181074800
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

