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

	// RVA: 0x22507C0 Offset: 0x224EDC0 VA: 0x1822507C0
	private static void .cctor() { }

	// RVA: 0x22506A0 Offset: 0x224ECA0 VA: 0x1822506A0
	public static void Unlinear(byte[] bytes, int start, long gbx) { }

	// RVA: 0x22505F0 Offset: 0x224EBF0 VA: 0x1822505F0
	public static void Unlinear(byte* bytes, long gbx) { }

	// RVA: 0x224FE40 Offset: 0x224E440 VA: 0x18224FE40
	public static long FromGBX(byte[] bytes, int start) { }

	// RVA: 0x22502C0 Offset: 0x224E8C0 VA: 0x1822502C0
	public static long FromUCSSurrogate(int cp) { }

	// RVA: 0x2250320 Offset: 0x224E920 VA: 0x182250320
	public static long FromUCS(int cp) { }

	// RVA: 0x224FDF0 Offset: 0x224E3F0 VA: 0x18224FDF0
	private static long FromGBXRaw(byte b1, byte b2, byte b3, byte b4, bool supp) { }

	// RVA: 0x2250580 Offset: 0x224EB80 VA: 0x182250580
	private static int ToUcsRaw(int idx) { }

	// RVA: 0x22504C0 Offset: 0x224EAC0 VA: 0x1822504C0
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

	// RVA: 0x224FD90 Offset: 0x224E390 VA: 0x18224FD90
	public void .ctor(int ustart, int uend, long gstart, long gend, bool dummy) { }

}

