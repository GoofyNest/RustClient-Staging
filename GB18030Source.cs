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

	// RVA: 0x22510E0 Offset: 0x224F6E0 VA: 0x1822510E0
	private static void .cctor() { }

	// RVA: 0x2250FC0 Offset: 0x224F5C0 VA: 0x182250FC0
	public static void Unlinear(byte[] bytes, int start, long gbx) { }

	// RVA: 0x2250F10 Offset: 0x224F510 VA: 0x182250F10
	public static void Unlinear(byte* bytes, long gbx) { }

	// RVA: 0x2250760 Offset: 0x224ED60 VA: 0x182250760
	public static long FromGBX(byte[] bytes, int start) { }

	// RVA: 0x2250BE0 Offset: 0x224F1E0 VA: 0x182250BE0
	public static long FromUCSSurrogate(int cp) { }

	// RVA: 0x2250C40 Offset: 0x224F240 VA: 0x182250C40
	public static long FromUCS(int cp) { }

	// RVA: 0x2250710 Offset: 0x224ED10 VA: 0x182250710
	private static long FromGBXRaw(byte b1, byte b2, byte b3, byte b4, bool supp) { }

	// RVA: 0x2250EA0 Offset: 0x224F4A0 VA: 0x182250EA0
	private static int ToUcsRaw(int idx) { }

	// RVA: 0x2250DE0 Offset: 0x224F3E0 VA: 0x182250DE0
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

	// RVA: 0x22506B0 Offset: 0x224ECB0 VA: 0x1822506B0
	public void .ctor(int ustart, int uend, long gstart, long gend, bool dummy) { }

}

