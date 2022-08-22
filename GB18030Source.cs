internal class GB18030Source // TypeDefIndex: 7833
{	// Fields
	private static readonly byte* gbx2uni; // 0x0
	private static readonly byte* uni2gbx; // 0x8
	private static readonly int gbx2uniSize; // 0x10
	private static readonly int uni2gbxSize; // 0x14
	private static readonly long gbxBase; // 0x18
	private static readonly long gbxSuppBase; // 0x20
	private static readonly GB18030Source.GB18030Map[] ranges; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x22508C0 Offset: 0x224EEC0 VA: 0x1822508C0
	private static void .cctor() { }

	// RVA: 0x22507A0 Offset: 0x224EDA0 VA: 0x1822507A0
	public static void Unlinear(byte[] bytes, int start, long gbx) { }

	// RVA: 0x22506F0 Offset: 0x224ECF0 VA: 0x1822506F0
	public static void Unlinear(byte* bytes, long gbx) { }

	// RVA: 0x224FF40 Offset: 0x224E540 VA: 0x18224FF40
	public static long FromGBX(byte[] bytes, int start) { }

	// RVA: 0x22503C0 Offset: 0x224E9C0 VA: 0x1822503C0
	public static long FromUCSSurrogate(int cp) { }

	// RVA: 0x2250420 Offset: 0x224EA20 VA: 0x182250420
	public static long FromUCS(int cp) { }

	// RVA: 0x224FEF0 Offset: 0x224E4F0 VA: 0x18224FEF0
	private static long FromGBXRaw(byte b1, byte b2, byte b3, byte b4, bool supp) { }

	// RVA: 0x2250680 Offset: 0x224EC80 VA: 0x182250680
	private static int ToUcsRaw(int idx) { }

	// RVA: 0x22505C0 Offset: 0x224EBC0 VA: 0x1822505C0
	private static long ToGbxRaw(int idx) { }

}

private class GB18030Source.GB18030Map // TypeDefIndex: 7834
{	// Fields
	public readonly int UStart; // 0x10
	public readonly int UEnd; // 0x14
	public readonly long GStart; // 0x18
	public readonly long GEnd; // 0x20
	public readonly bool Dummy; // 0x28

	// Methods

	// RVA: 0x224FE90 Offset: 0x224E490 VA: 0x18224FE90
	public void .ctor(int ustart, int uend, long gstart, long gend, bool dummy) { }

}

