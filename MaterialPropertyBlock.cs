public sealed class MaterialPropertyBlock // TypeDefIndex: 3402
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public bool isEmpty { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0x8E6E0 Offset: 0x8DAE0 VA: 0x18008E6E0
	// RVA: 0x18EBDC0 Offset: 0x18EA3C0 VA: 0x1818EBDC0
	private Texture GetTextureImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E790 Offset: 0x8DB90 VA: 0x18008E790
	// RVA: 0x18EC070 Offset: 0x18EA670 VA: 0x1818EC070
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E7F0 Offset: 0x8DBF0 VA: 0x18008E7F0
	// RVA: 0x18EC330 Offset: 0x18EA930 VA: 0x1818EC330
	private void SetVectorImpl(int name, Vector4 value) { }

	[NativeNameAttribute] // RVA: 0x8E850 Offset: 0x8DC50 VA: 0x18008E850
	// RVA: 0x18EBF70 Offset: 0x18EA570 VA: 0x1818EBF70
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E8B0 Offset: 0x8DCB0 VA: 0x18008E8B0
	// RVA: 0x18EC170 Offset: 0x18EA770 VA: 0x1818EC170
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E950 Offset: 0x8DD50 VA: 0x18008E950
	// RVA: 0x18EC230 Offset: 0x18EA830 VA: 0x1818EC230
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8EB70 Offset: 0x8DF70 VA: 0x18008EB70
	// RVA: 0x18EBE70 Offset: 0x18EA470 VA: 0x1818EBE70
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x8ECC0 Offset: 0x8E0C0 VA: 0x18008ECC0
	// RVA: 0x18EBE00 Offset: 0x18EA400 VA: 0x1818EBE00
	internal static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	[NativeMethodAttribute] // RVA: 0x8ED20 Offset: 0x8E120 VA: 0x18008ED20
	// RVA: 0x18EBBA0 Offset: 0x18EA1A0 VA: 0x1818EBBA0
	private static IntPtr CreateImpl() { }

	[NativeMethodAttribute] // RVA: 0x8EE30 Offset: 0x8E230 VA: 0x18008EE30
	// RVA: 0x18EBBD0 Offset: 0x18EA1D0 VA: 0x1818EBBD0
	private static void DestroyImpl(IntPtr mpb) { }

	[NativeNameAttribute] // RVA: 0x8EF70 Offset: 0x8E370 VA: 0x18008EF70
	// RVA: 0x18EC470 Offset: 0x18EAA70 VA: 0x1818EC470
	public bool get_isEmpty() { }

	// RVA: 0x18EB850 Offset: 0x18E9E50 VA: 0x1818EB850
	private void Clear(bool keepMemory) { }

	// RVA: 0x18EB810 Offset: 0x18E9E10 VA: 0x1818EB810
	public void Clear() { }

	// RVA: 0x18EC430 Offset: 0x18EAA30 VA: 0x1818EC430
	public void .ctor() { }

	// RVA: 0x18EBCB0 Offset: 0x18EA2B0 VA: 0x1818EBCB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18EBC10 Offset: 0x18EA210 VA: 0x1818EBC10
	private void Dispose() { }

	// RVA: 0x18EC0C0 Offset: 0x18EA6C0 VA: 0x1818EC0C0
	public void SetFloat(string name, float value) { }

	// RVA: 0x18EC070 Offset: 0x18EA670 VA: 0x1818EC070
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x18EC3D0 Offset: 0x18EA9D0 VA: 0x1818EC3D0
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x18EC380 Offset: 0x18EA980 VA: 0x1818EC380
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x18EBFC0 Offset: 0x18EA5C0 VA: 0x1818EBFC0
	public void SetColor(string name, Color value) { }

	// RVA: 0x18EC020 Offset: 0x18EA620 VA: 0x1818EC020
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x18EC1C0 Offset: 0x18EA7C0 VA: 0x1818EC1C0
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x18EBEC0 Offset: 0x18EA4C0 VA: 0x1818EBEC0
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x18EBE70 Offset: 0x18EA470 VA: 0x1818EBE70
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x18EC280 Offset: 0x18EA880 VA: 0x1818EC280
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x18EC230 Offset: 0x18EA830 VA: 0x1818EC230
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x18EBDC0 Offset: 0x18EA3C0 VA: 0x1818EBDC0
	public Texture GetTexture(int nameID) { }

	// RVA: 0x18EBA60 Offset: 0x18EA060 VA: 0x1818EBA60
	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes) { }

	// RVA: 0x18EB8A0 Offset: 0x18E9EA0 VA: 0x1818EB8A0
	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	// RVA: 0x18EC2E0 Offset: 0x18EA8E0 VA: 0x1818EC2E0
	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x18EBF20 Offset: 0x18EA520 VA: 0x1818EBF20
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x18EC120 Offset: 0x18EA720 VA: 0x1818EC120
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

