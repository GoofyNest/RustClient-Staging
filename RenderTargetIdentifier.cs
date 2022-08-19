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

	// RVA: 0x222440 Offset: 0x221840 VA: 0x180222440
	public void .ctor(BuiltinRenderTextureType type) { }

	// RVA: 0x222360 Offset: 0x221760 VA: 0x180222360
	public void .ctor(int nameID) { }

	// RVA: 0x222400 Offset: 0x221800 VA: 0x180222400
	public void .ctor(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x2223F0 Offset: 0x2217F0 VA: 0x1802223F0
	public void .ctor(Texture tex) { }

	// RVA: 0x2223C0 Offset: 0x2217C0 VA: 0x1802223C0
	public void .ctor(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x19B0720 Offset: 0x19AED20 VA: 0x1819B0720
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	// RVA: 0x19B0880 Offset: 0x19AEE80 VA: 0x1819B0880
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	// RVA: 0x19B0820 Offset: 0x19AEE20 VA: 0x1819B0820
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0x19B07C0 Offset: 0x19AEDC0 VA: 0x1819B07C0
	public static RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	// RVA: 0x222350 Offset: 0x221750 VA: 0x180222350 Slot: 3
	public override string ToString() { }

	// RVA: 0x2222F0 Offset: 0x2216F0 VA: 0x1802222F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x222200 Offset: 0x221600 VA: 0x180222200 Slot: 4
	public bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x222240 Offset: 0x221640 VA: 0x180222240 Slot: 0
	public override bool Equals(object obj) { }

}

