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

	// RVA: 0x191EBB0 Offset: 0x191D1B0 VA: 0x18191EBB0
	private static uint PropValue(int cp) { }

	// RVA: 0x191D380 Offset: 0x191B980 VA: 0x18191D380
	private static int CharMapIdx(int cp) { }

	// RVA: 0x191E760 Offset: 0x191CD60 VA: 0x18191E760
	private static byte GetCombiningClass(int c) { }

	// RVA: 0x191E820 Offset: 0x191CE20 VA: 0x18191E820
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	// RVA: 0x191E8E0 Offset: 0x191CEE0 VA: 0x18191E8E0
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	// RVA: 0x191D980 Offset: 0x191BF80 VA: 0x18191D980
	private static string Compose(string source, int checkType) { }

	// RVA: 0x191D850 Offset: 0x191BE50 VA: 0x18191D850
	private static StringBuilder Combine(string source, int start, int checkType) { }

	// RVA: 0x191D5F0 Offset: 0x191BBF0 VA: 0x18191D5F0
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	// RVA: 0x191D420 Offset: 0x191BA20 VA: 0x18191D420
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	// RVA: 0x191E1E0 Offset: 0x191C7E0 VA: 0x18191E1E0
	private static int Fetch(StringBuilder sb, string s, int i) { }

	// RVA: 0x191F060 Offset: 0x191D660 VA: 0x18191F060
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	// RVA: 0x191F410 Offset: 0x191DA10 VA: 0x18191F410
	private static int TryCompose(int i, int starter, int candidate) { }

	// RVA: 0x191DDE0 Offset: 0x191C3E0 VA: 0x18191DDE0
	private static string Decompose(string source, int checkType) { }

	// RVA: 0x191DE80 Offset: 0x191C480 VA: 0x18191DE80
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	// RVA: 0x191EDB0 Offset: 0x191D3B0 VA: 0x18191EDB0
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	// RVA: 0x191DB80 Offset: 0x191C180 VA: 0x18191DB80
	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	// RVA: 0x191EC50 Offset: 0x191D250 VA: 0x18191EC50
	public static NormalizationCheck QuickCheck(char c, int type) { }

	// RVA: 0x191E230 Offset: 0x191C830 VA: 0x18191E230
	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	// RVA: 0x191E380 Offset: 0x191C980 VA: 0x18191E380
	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	// RVA: 0x191EAC0 Offset: 0x191D0C0 VA: 0x18191EAC0
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x191E9A0 Offset: 0x191CFA0 VA: 0x18191E9A0
	public static string Normalize(string source, int type) { }

	// RVA: 0x191F7C0 Offset: 0x191DDC0 VA: 0x18191F7C0
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	// RVA: 0x191F5A0 Offset: 0x191DBA0 VA: 0x18191F5A0
	private static void .cctor() { }

}

