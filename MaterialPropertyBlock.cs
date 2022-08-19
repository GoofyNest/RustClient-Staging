public sealed class MaterialPropertyBlock // TypeDefIndex: 3402
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public bool isEmpty { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0x8E660 Offset: 0x8DA60 VA: 0x18008E660
	// RVA: 0x18EBB40 Offset: 0x18EA140 VA: 0x1818EBB40
	private Texture GetTextureImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E710 Offset: 0x8DB10 VA: 0x18008E710
	// RVA: 0x18EBDF0 Offset: 0x18EA3F0 VA: 0x1818EBDF0
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E770 Offset: 0x8DB70 VA: 0x18008E770
	// RVA: 0x18EC0B0 Offset: 0x18EA6B0 VA: 0x1818EC0B0
	private void SetVectorImpl(int name, Vector4 value) { }

	[NativeNameAttribute] // RVA: 0x8E7D0 Offset: 0x8DBD0 VA: 0x18008E7D0
	// RVA: 0x18EBCF0 Offset: 0x18EA2F0 VA: 0x1818EBCF0
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E830 Offset: 0x8DC30 VA: 0x18008E830
	// RVA: 0x18EBEF0 Offset: 0x18EA4F0 VA: 0x1818EBEF0
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E8F0 Offset: 0x8DCF0 VA: 0x18008E8F0
	// RVA: 0x18EBFB0 Offset: 0x18EA5B0 VA: 0x1818EBFB0
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8E9B0 Offset: 0x8DDB0 VA: 0x18008E9B0
	// RVA: 0x18EBBF0 Offset: 0x18EA1F0 VA: 0x1818EBBF0
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x8EC40 Offset: 0x8E040 VA: 0x18008EC40
	// RVA: 0x18EBB80 Offset: 0x18EA180 VA: 0x1818EBB80
	internal static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	[NativeMethodAttribute] // RVA: 0x8ECA0 Offset: 0x8E0A0 VA: 0x18008ECA0
	// RVA: 0x18EB920 Offset: 0x18E9F20 VA: 0x1818EB920
	private static IntPtr CreateImpl() { }

	[NativeMethodAttribute] // RVA: 0x8ED50 Offset: 0x8E150 VA: 0x18008ED50
	// RVA: 0x18EB950 Offset: 0x18E9F50 VA: 0x1818EB950
	private static void DestroyImpl(IntPtr mpb) { }

	[NativeNameAttribute] // RVA: 0x8EEC0 Offset: 0x8E2C0 VA: 0x18008EEC0
	// RVA: 0x18EC1F0 Offset: 0x18EA7F0 VA: 0x1818EC1F0
	public bool get_isEmpty() { }

	// RVA: 0x18EB5D0 Offset: 0x18E9BD0 VA: 0x1818EB5D0
	private void Clear(bool keepMemory) { }

	// RVA: 0x18EB590 Offset: 0x18E9B90 VA: 0x1818EB590
	public void Clear() { }

	// RVA: 0x18EC1B0 Offset: 0x18EA7B0 VA: 0x1818EC1B0
	public void .ctor() { }

	// RVA: 0x18EBA30 Offset: 0x18EA030 VA: 0x1818EBA30 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18EB990 Offset: 0x18E9F90 VA: 0x1818EB990
	private void Dispose() { }

	// RVA: 0x18EBE40 Offset: 0x18EA440 VA: 0x1818EBE40
	public void SetFloat(string name, float value) { }

	// RVA: 0x18EBDF0 Offset: 0x18EA3F0 VA: 0x1818EBDF0
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x18EC150 Offset: 0x18EA750 VA: 0x1818EC150
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x18EC100 Offset: 0x18EA700 VA: 0x1818EC100
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x18EBD40 Offset: 0x18EA340 VA: 0x1818EBD40
	public void SetColor(string name, Color value) { }

	// RVA: 0x18EBDA0 Offset: 0x18EA3A0 VA: 0x1818EBDA0
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x18EBF40 Offset: 0x18EA540 VA: 0x1818EBF40
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x18EBC40 Offset: 0x18EA240 VA: 0x1818EBC40
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x18EBBF0 Offset: 0x18EA1F0 VA: 0x1818EBBF0
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x18EC000 Offset: 0x18EA600 VA: 0x1818EC000
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x18EBFB0 Offset: 0x18EA5B0 VA: 0x1818EBFB0
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x18EBB40 Offset: 0x18EA140 VA: 0x1818EBB40
	public Texture GetTexture(int nameID) { }

	// RVA: 0x18EB7E0 Offset: 0x18E9DE0 VA: 0x1818EB7E0
	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes) { }

	// RVA: 0x18EB620 Offset: 0x18E9C20 VA: 0x1818EB620
	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	// RVA: 0x18EC060 Offset: 0x18EA660 VA: 0x1818EC060
	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x18EBCA0 Offset: 0x18EA2A0 VA: 0x1818EBCA0
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x18EBEA0 Offset: 0x18EA4A0 VA: 0x1818EBEA0
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

