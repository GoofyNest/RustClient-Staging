public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier> // TypeDefIndex: 3824
{	// Fields
	private BuiltinRenderTextureType m_Type; // 0x0
	private int m_NameID; // 0x4
	private int m_InstanceID; // 0x8
	private IntPtr m_BufferPointer; // 0x10
	private int m_MipLevel; // 0x18
	private CubemapFace m_CubeFace; // 0x1C
	private int m_DepthSlice; // 0x20

	// Methods

	// RVA: 0x2223C0 Offset: 0x2217C0 VA: 0x1802223C0
	public void .ctor(BuiltinRenderTextureType type) { }

	// RVA: 0x2222E0 Offset: 0x2216E0 VA: 0x1802222E0
	public void .ctor(int nameID) { }

	// RVA: 0x222380 Offset: 0x221780 VA: 0x180222380
	public void .ctor(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x222370 Offset: 0x221770 VA: 0x180222370
	public void .ctor(Texture tex) { }

	// RVA: 0x222340 Offset: 0x221740 VA: 0x180222340
	public void .ctor(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x19B06E0 Offset: 0x19AECE0 VA: 0x1819B06E0
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	// RVA: 0x19B0840 Offset: 0x19AEE40 VA: 0x1819B0840
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	// RVA: 0x19B07E0 Offset: 0x19AEDE0 VA: 0x1819B07E0
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0x19B0780 Offset: 0x19AED80 VA: 0x1819B0780
	public static RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	// RVA: 0x2222D0 Offset: 0x2216D0 VA: 0x1802222D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x222270 Offset: 0x221670 VA: 0x180222270 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x222180 Offset: 0x221580 VA: 0x180222180 Slot: 4
	public bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x2221C0 Offset: 0x2215C0 VA: 0x1802221C0 Slot: 0
	public override bool Equals(object obj) { }

}

