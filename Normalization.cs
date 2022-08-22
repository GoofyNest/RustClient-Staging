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

	// RVA: 0x191EE70 Offset: 0x191D470 VA: 0x18191EE70
	private static uint PropValue(int cp) { }

	// RVA: 0x191D640 Offset: 0x191BC40 VA: 0x18191D640
	private static int CharMapIdx(int cp) { }

	// RVA: 0x191EA20 Offset: 0x191D020 VA: 0x18191EA20
	private static byte GetCombiningClass(int c) { }

	// RVA: 0x191EAE0 Offset: 0x191D0E0 VA: 0x18191EAE0
	private static int GetPrimaryCompositeFromMapIndex(int src) { }

	// RVA: 0x191EBA0 Offset: 0x191D1A0 VA: 0x18191EBA0
	private static int GetPrimaryCompositeHelperIndex(int cp) { }

	// RVA: 0x191DC40 Offset: 0x191C240 VA: 0x18191DC40
	private static string Compose(string source, int checkType) { }

	// RVA: 0x191DB10 Offset: 0x191C110 VA: 0x18191DB10
	private static StringBuilder Combine(string source, int start, int checkType) { }

	// RVA: 0x191D8B0 Offset: 0x191BEB0 VA: 0x18191D8B0
	private static void Combine(StringBuilder sb, int i, int checkType) { }

	// RVA: 0x191D6E0 Offset: 0x191BCE0 VA: 0x18191D6E0
	private static int CombineHangul(StringBuilder sb, string s, int current) { }

	// RVA: 0x191E4A0 Offset: 0x191CAA0 VA: 0x18191E4A0
	private static int Fetch(StringBuilder sb, string s, int i) { }

	// RVA: 0x191F320 Offset: 0x191D920 VA: 0x18191F320
	private static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current) { }

	// RVA: 0x191F6D0 Offset: 0x191DCD0 VA: 0x18191F6D0
	private static int TryCompose(int i, int starter, int candidate) { }

	// RVA: 0x191E0A0 Offset: 0x191C6A0 VA: 0x18191E0A0
	private static string Decompose(string source, int checkType) { }

	// RVA: 0x191E140 Offset: 0x191C740 VA: 0x18191E140
	private static void Decompose(string source, ref StringBuilder sb, int checkType) { }

	// RVA: 0x191F070 Offset: 0x191D670 VA: 0x18191F070
	private static void ReorderCanonical(string src, ref StringBuilder sb, int start) { }

	// RVA: 0x191DE40 Offset: 0x191C440 VA: 0x18191DE40
	private static void DecomposeChar(ref StringBuilder sb, ref int[] buf, string s, int i, int checkType, ref int start) { }

	// RVA: 0x191EF10 Offset: 0x191D510 VA: 0x18191EF10
	public static NormalizationCheck QuickCheck(char c, int type) { }

	// RVA: 0x191E4F0 Offset: 0x191CAF0 VA: 0x18191E4F0
	private static int GetCanonicalHangul(int s, int[] buf, int bufIdx) { }

	// RVA: 0x191E640 Offset: 0x191CC40 VA: 0x18191E640
	private static int GetCanonical(int c, int[] buf, int bufIdx, int checkType) { }

	// RVA: 0x191ED80 Offset: 0x191D380 VA: 0x18191ED80
	public static string Normalize(string source, NormalizationForm normalizationForm) { }

	// RVA: 0x191EC60 Offset: 0x191D260 VA: 0x18191EC60
	public static string Normalize(string source, int type) { }

	// RVA: 0x191FA80 Offset: 0x191E080 VA: 0x18191FA80
	private static void load_normalization_resource(out IntPtr props, out IntPtr mappedChars, out IntPtr charMapIndex, out IntPtr helperIndex, out IntPtr mapIdxToComposite, out IntPtr combiningClass) { }

	// RVA: 0x191F860 Offset: 0x191DE60 VA: 0x18191F860
	private static void .cctor() { }

}

