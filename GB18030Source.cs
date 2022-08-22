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

	// RVA: 0x2250600 Offset: 0x224EC00 VA: 0x182250600
	private static void .cctor() { }

	// RVA: 0x22504E0 Offset: 0x224EAE0 VA: 0x1822504E0
	public static void Unlinear(byte[] bytes, int start, long gbx) { }

	// RVA: 0x2250430 Offset: 0x224EA30 VA: 0x182250430
	public static void Unlinear(byte* bytes, long gbx) { }

	// RVA: 0x224FC80 Offset: 0x224E280 VA: 0x18224FC80
	public static long FromGBX(byte[] bytes, int start) { }

	// RVA: 0x2250100 Offset: 0x224E700 VA: 0x182250100
	public static long FromUCSSurrogate(int cp) { }

	// RVA: 0x2250160 Offset: 0x224E760 VA: 0x182250160
	public static long FromUCS(int cp) { }

	// RVA: 0x224FC30 Offset: 0x224E230 VA: 0x18224FC30
	private static long FromGBXRaw(byte b1, byte b2, byte b3, byte b4, bool supp) { }

	// RVA: 0x22503C0 Offset: 0x224E9C0 VA: 0x1822503C0
	private static int ToUcsRaw(int idx) { }

	// RVA: 0x2250300 Offset: 0x224E900 VA: 0x182250300
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

	// RVA: 0x224FBD0 Offset: 0x224E1D0 VA: 0x18224FBD0
	public void .ctor(int ustart, int uend, long gstart, long gend, bool dummy) { }

}

