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

	// RVA: 0x21D940 Offset: 0x21CD40 VA: 0x18021D940
	public void .ctor(BuiltinRenderTextureType type) { }

	// RVA: 0x21D860 Offset: 0x21CC60 VA: 0x18021D860
	public void .ctor(int nameID) { }

	// RVA: 0x21D900 Offset: 0x21CD00 VA: 0x18021D900
	public void .ctor(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x21D8F0 Offset: 0x21CCF0 VA: 0x18021D8F0
	public void .ctor(Texture tex) { }

	// RVA: 0x21D8C0 Offset: 0x21CCC0 VA: 0x18021D8C0
	public void .ctor(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	// RVA: 0x199DDA0 Offset: 0x199C3A0 VA: 0x18199DDA0
	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	// RVA: 0x199DF00 Offset: 0x199C500 VA: 0x18199DF00
	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	// RVA: 0x199DEA0 Offset: 0x199C4A0 VA: 0x18199DEA0
	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	// RVA: 0x199DE40 Offset: 0x199C440 VA: 0x18199DE40
	public static RenderTargetIdentifier op_Implicit(RenderBuffer buf) { }

	// RVA: 0x21D850 Offset: 0x21CC50 VA: 0x18021D850 Slot: 3
	public override string ToString() { }

	// RVA: 0x21D7F0 Offset: 0x21CBF0 VA: 0x18021D7F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21D700 Offset: 0x21CB00 VA: 0x18021D700 Slot: 4
	public bool Equals(RenderTargetIdentifier rhs) { }

	// RVA: 0x21D740 Offset: 0x21CB40 VA: 0x18021D740 Slot: 0
	public override bool Equals(object obj) { }

}

