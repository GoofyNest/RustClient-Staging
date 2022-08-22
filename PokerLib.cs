public static class PokerLib // TypeDefIndex: 8226
{	// Fields
	public const int CLUB = 32768;
	public const int DIAMOND = 16384;
	public const int HEART = 8192;
	public const int SPADE = 4096;

	// Methods

	// RVA: 0x10739E0 Offset: 0x1071FE0 VA: 0x1810739E0
	public static int FindIt(int key) { }

	// RVA: 0x1073C80 Offset: 0x1072280 VA: 0x181073C80
	public static void InitDeck(int[] deck) { }

	// RVA: 0x1073980 Offset: 0x1071F80 VA: 0x181073980
	public static int FindCard(int rank, int suit, int[] deck) { }

	// RVA: 0x10733F0 Offset: 0x10719F0 VA: 0x1810733F0
	public static ushort Eval5Cards(int c1, int c2, int c3, int c4, int c5) { }

	// RVA: 0x1073700 Offset: 0x1071D00 VA: 0x181073700
	public static ushort Eval5Hand(int[] hand) { }

	// RVA: 0x10737B0 Offset: 0x1071DB0 VA: 0x1810737B0
	public static ushort Eval7Hand(int[] hand) { }

	// RVA: 0x10738F0 Offset: 0x1071EF0 VA: 0x1810738F0
	public static PokerLib.PokerResult EvalToResultName(ushort eval) { }

	// RVA: 0x1073B50 Offset: 0x1072150 VA: 0x181073B50
	public static string HandToString(int[] hand) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1073D90 Offset: 0x1072390 VA: 0x181073D90
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

