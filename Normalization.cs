internal class Normalization // TypeDefIndex: 478
{	// Fields
	private static byte* props; // 0x0
	private static int* mappedChars; // 0x8
	private static short* charMapIndex; // 0x10
	private static short* helperIndex; // 0x18
	private static ushort* mapIdxToComposite; // 0x20
	private static byte* combiningClass; // 0x28
	private static object forLock; // 0x30
	public static readonly bool isReady; // 0x38

	// Methods

	// RVA: 0x191EBF0 Offset: 0x191D1F0 VA: 0x18191EBF0
	private static uint PropValue(int cp) { }

	// RVA: 0x191D3C0 Offset: 0x191B9C0 VA: 0x18191D3C0
	private static int CharMapIdx(int cp) { }

	// RVA: 0x191E7A0 Offset: 0x191CDA0 VA: 0x18191E7A0
	private static byte GetCombiningClass(int c) { }

	// RVA: 0x191E860 Offset: 0x191CE60 VA: 0x18191E860
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	// RVA: 0x191E920 Offset: 0x191CF20 VA: 0x18191E920
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	// RVA: 0x191D9C0 Offset: 0x191BFC0 VA: 0x18191D9C0
	private static string Compose(string source, int checkType) { }

	// RVA: 0x191D890 Offset: 0x191BE90 VA: 0x18191D890
	private static StringBuilder Combine(string source, int start, int checkType) { }

	// RVA: 0x191D630 Offset: 0x191BC30 VA: 0x18191D630
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	// RVA: 0x191D460 Offset: 0x191BA60 VA: 0x18191D460
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	// RVA: 0x191E220 Offset: 0x191C820 VA: 0x18191E220
	private static int Fetch(StringBuilder sb, string s, int i) { }

	// RVA: 0x191F0A0 Offset: 0x191D6A0 VA: 0x18191F0A0
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	// RVA: 0x191F450 Offset: 0x191DA50 VA: 0x18191F450
	private static int TryCompose(int i, int starter, int candidate) { }

	// RVA: 0x191DE20 Offset: 0x191C420 VA: 0x18191DE20
	private static string Decompose(string source, int checkType) { }

	// RVA: 0x191DEC0 Offset: 0x191C4C0 VA: 0x18191DEC0
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	// RVA: 0x191EDF0 Offset: 0x191D3F0 VA: 0x18191EDF0
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	// RVA: 0x191DBC0 Offset: 0x191C1C0 VA: 0x18191DBC0
	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	// RVA: 0x191EC90 Offset: 0x191D290 VA: 0x18191EC90
	public static NormalizationCheck QuickCheck(char c, int type) { }

	// RVA: 0x191E270 Offset: 0x191C870 VA: 0x18191E270
	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	// RVA: 0x191E3C0 Offset: 0x191C9C0 VA: 0x18191E3C0
	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	// RVA: 0x191EB00 Offset: 0x191D100 VA: 0x18191EB00
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x191E9E0 Offset: 0x191CFE0 VA: 0x18191E9E0
	public static string Normalize(string source, int type) { }

	// RVA: 0x191F800 Offset: 0x191DE00 VA: 0x18191F800
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	// RVA: 0x191F5E0 Offset: 0x191DBE0 VA: 0x18191F5E0
	private static void .cctor() { }

}

