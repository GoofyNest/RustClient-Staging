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

	// RVA: 0x191E590 Offset: 0x191CB90 VA: 0x18191E590
	private static uint PropValue(int cp) { }

	// RVA: 0x191CD60 Offset: 0x191B360 VA: 0x18191CD60
	private static int CharMapIdx(int cp) { }

	// RVA: 0x191E140 Offset: 0x191C740 VA: 0x18191E140
	private static byte GetCombiningClass(int c) { }

	// RVA: 0x191E200 Offset: 0x191C800 VA: 0x18191E200
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	// RVA: 0x191E2C0 Offset: 0x191C8C0 VA: 0x18191E2C0
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	// RVA: 0x191D360 Offset: 0x191B960 VA: 0x18191D360
	private static string Compose(string source, int checkType) { }

	// RVA: 0x191D230 Offset: 0x191B830 VA: 0x18191D230
	private static StringBuilder Combine(string source, int start, int checkType) { }

	// RVA: 0x191CFD0 Offset: 0x191B5D0 VA: 0x18191CFD0
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	// RVA: 0x191CE00 Offset: 0x191B400 VA: 0x18191CE00
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	// RVA: 0x191DBC0 Offset: 0x191C1C0 VA: 0x18191DBC0
	private static int Fetch(StringBuilder sb, string s, int i) { }

	// RVA: 0x191EA40 Offset: 0x191D040 VA: 0x18191EA40
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	// RVA: 0x191EDF0 Offset: 0x191D3F0 VA: 0x18191EDF0
	private static int TryCompose(int i, int starter, int candidate) { }

	// RVA: 0x191D7C0 Offset: 0x191BDC0 VA: 0x18191D7C0
	private static string Decompose(string source, int checkType) { }

	// RVA: 0x191D860 Offset: 0x191BE60 VA: 0x18191D860
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	// RVA: 0x191E790 Offset: 0x191CD90 VA: 0x18191E790
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	// RVA: 0x191D560 Offset: 0x191BB60 VA: 0x18191D560
	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	// RVA: 0x191E630 Offset: 0x191CC30 VA: 0x18191E630
	public static NormalizationCheck QuickCheck(char c, int type) { }

	// RVA: 0x191DC10 Offset: 0x191C210 VA: 0x18191DC10
	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	// RVA: 0x191DD60 Offset: 0x191C360 VA: 0x18191DD60
	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	// RVA: 0x191E4A0 Offset: 0x191CAA0 VA: 0x18191E4A0
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x191E380 Offset: 0x191C980 VA: 0x18191E380
	public static string Normalize(string source, int type) { }

	// RVA: 0x191F1A0 Offset: 0x191D7A0 VA: 0x18191F1A0
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	// RVA: 0x191EF80 Offset: 0x191D580 VA: 0x18191EF80
	private static void .cctor() { }

}

