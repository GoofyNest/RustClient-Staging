public sealed class MaterialPropertyBlock // TypeDefIndex: 3402
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public bool isEmpty { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0x8E6E0 Offset: 0x8DAE0 VA: 0x18008E6E0
	// RVA: 0x18EBB00 Offset: 0x18EA100 VA: 0x1818EBB00
	private Texture GetTextureImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E790 Offset: 0x8DB90 VA: 0x18008E790
	// RVA: 0x18EBDB0 Offset: 0x18EA3B0 VA: 0x1818EBDB0
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E7F0 Offset: 0x8DBF0 VA: 0x18008E7F0
	// RVA: 0x18EC070 Offset: 0x18EA670 VA: 0x1818EC070
	private void SetVectorImpl(int name, Vector4 value) { }

	[NativeNameAttribute] // RVA: 0x8E850 Offset: 0x8DC50 VA: 0x18008E850
	// RVA: 0x18EBCB0 Offset: 0x18EA2B0 VA: 0x1818EBCB0
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E8B0 Offset: 0x8DCB0 VA: 0x18008E8B0
	// RVA: 0x18EBEB0 Offset: 0x18EA4B0 VA: 0x1818EBEB0
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E950 Offset: 0x8DD50 VA: 0x18008E950
	// RVA: 0x18EBF70 Offset: 0x18EA570 VA: 0x1818EBF70
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8EB70 Offset: 0x8DF70 VA: 0x18008EB70
	// RVA: 0x18EBBB0 Offset: 0x18EA1B0 VA: 0x1818EBBB0
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x8ECC0 Offset: 0x8E0C0 VA: 0x18008ECC0
	// RVA: 0x18EBB40 Offset: 0x18EA140 VA: 0x1818EBB40
	internal static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	[NativeMethodAttribute] // RVA: 0x8ED20 Offset: 0x8E120 VA: 0x18008ED20
	// RVA: 0x18EB8E0 Offset: 0x18E9EE0 VA: 0x1818EB8E0
	private static IntPtr CreateImpl() { }

	[NativeMethodAttribute] // RVA: 0x8EE30 Offset: 0x8E230 VA: 0x18008EE30
	// RVA: 0x18EB910 Offset: 0x18E9F10 VA: 0x1818EB910
	private static void DestroyImpl(IntPtr mpb) { }

	[NativeNameAttribute] // RVA: 0x8EF70 Offset: 0x8E370 VA: 0x18008EF70
	// RVA: 0x18EC1B0 Offset: 0x18EA7B0 VA: 0x1818EC1B0
	public bool get_isEmpty() { }

	// RVA: 0x18EB590 Offset: 0x18E9B90 VA: 0x1818EB590
	private void Clear(bool keepMemory) { }

	// RVA: 0x18EB550 Offset: 0x18E9B50 VA: 0x1818EB550
	public void Clear() { }

	// RVA: 0x18EC170 Offset: 0x18EA770 VA: 0x1818EC170
	public void .ctor() { }

	// RVA: 0x18EB9F0 Offset: 0x18E9FF0 VA: 0x1818EB9F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18EB950 Offset: 0x18E9F50 VA: 0x1818EB950
	private void Dispose() { }

	// RVA: 0x18EBE00 Offset: 0x18EA400 VA: 0x1818EBE00
	public void SetFloat(string name, float value) { }

	// RVA: 0x18EBDB0 Offset: 0x18EA3B0 VA: 0x1818EBDB0
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x18EC110 Offset: 0x18EA710 VA: 0x1818EC110
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x18EC0C0 Offset: 0x18EA6C0 VA: 0x1818EC0C0
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x18EBD00 Offset: 0x18EA300 VA: 0x1818EBD00
	public void SetColor(string name, Color value) { }

	// RVA: 0x18EBD60 Offset: 0x18EA360 VA: 0x1818EBD60
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x18EBF00 Offset: 0x18EA500 VA: 0x1818EBF00
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x18EBC00 Offset: 0x18EA200 VA: 0x1818EBC00
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x18EBBB0 Offset: 0x18EA1B0 VA: 0x1818EBBB0
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x18EBFC0 Offset: 0x18EA5C0 VA: 0x1818EBFC0
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x18EBF70 Offset: 0x18EA570 VA: 0x1818EBF70
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x18EBB00 Offset: 0x18EA100 VA: 0x1818EBB00
	public Texture GetTexture(int nameID) { }

	// RVA: 0x18EB7A0 Offset: 0x18E9DA0 VA: 0x1818EB7A0
	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes) { }

	// RVA: 0x18EB5E0 Offset: 0x18E9BE0 VA: 0x1818EB5E0
	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	// RVA: 0x18EC020 Offset: 0x18EA620 VA: 0x1818EC020
	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x18EBC60 Offset: 0x18EA260 VA: 0x1818EBC60
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x18EBE60 Offset: 0x18EA460 VA: 0x1818EBE60
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

