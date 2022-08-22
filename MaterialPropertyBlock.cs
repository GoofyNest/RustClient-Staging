public sealed class MaterialPropertyBlock // TypeDefIndex: 3402
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public bool isEmpty { get; }

	// Methods

	[NativeNameAttribute] // RVA: 0x8E6E0 Offset: 0x8DAE0 VA: 0x18008E6E0
	// RVA: 0x18EB4E0 Offset: 0x18E9AE0 VA: 0x1818EB4E0
	private Texture GetTextureImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E790 Offset: 0x8DB90 VA: 0x18008E790
	// RVA: 0x18EB790 Offset: 0x18E9D90 VA: 0x1818EB790
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E7F0 Offset: 0x8DBF0 VA: 0x18008E7F0
	// RVA: 0x18EBA50 Offset: 0x18EA050 VA: 0x1818EBA50
	private void SetVectorImpl(int name, Vector4 value) { }

	[NativeNameAttribute] // RVA: 0x8E850 Offset: 0x8DC50 VA: 0x18008E850
	// RVA: 0x18EB690 Offset: 0x18E9C90 VA: 0x1818EB690
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E8B0 Offset: 0x8DCB0 VA: 0x18008E8B0
	// RVA: 0x18EB890 Offset: 0x18E9E90 VA: 0x1818EB890
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E950 Offset: 0x8DD50 VA: 0x18008E950
	// RVA: 0x18EB950 Offset: 0x18E9F50 VA: 0x1818EB950
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8EB70 Offset: 0x8DF70 VA: 0x18008EB70
	// RVA: 0x18EB590 Offset: 0x18E9B90 VA: 0x1818EB590
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x8ECC0 Offset: 0x8E0C0 VA: 0x18008ECC0
	// RVA: 0x18EB520 Offset: 0x18E9B20 VA: 0x1818EB520
	internal static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	[NativeMethodAttribute] // RVA: 0x8ED20 Offset: 0x8E120 VA: 0x18008ED20
	// RVA: 0x18EB2C0 Offset: 0x18E98C0 VA: 0x1818EB2C0
	private static IntPtr CreateImpl() { }

	[NativeMethodAttribute] // RVA: 0x8EE30 Offset: 0x8E230 VA: 0x18008EE30
	// RVA: 0x18EB2F0 Offset: 0x18E98F0 VA: 0x1818EB2F0
	private static void DestroyImpl(IntPtr mpb) { }

	[NativeNameAttribute] // RVA: 0x8EF70 Offset: 0x8E370 VA: 0x18008EF70
	// RVA: 0x18EBB90 Offset: 0x18EA190 VA: 0x1818EBB90
	public bool get_isEmpty() { }

	// RVA: 0x18EAF70 Offset: 0x18E9570 VA: 0x1818EAF70
	private void Clear(bool keepMemory) { }

	// RVA: 0x18EAF30 Offset: 0x18E9530 VA: 0x1818EAF30
	public void Clear() { }

	// RVA: 0x18EBB50 Offset: 0x18EA150 VA: 0x1818EBB50
	public void .ctor() { }

	// RVA: 0x18EB3D0 Offset: 0x18E99D0 VA: 0x1818EB3D0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x18EB330 Offset: 0x18E9930 VA: 0x1818EB330
	private void Dispose() { }

	// RVA: 0x18EB7E0 Offset: 0x18E9DE0 VA: 0x1818EB7E0
	public void SetFloat(string name, float value) { }

	// RVA: 0x18EB790 Offset: 0x18E9D90 VA: 0x1818EB790
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x18EBAF0 Offset: 0x18EA0F0 VA: 0x1818EBAF0
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x18EBAA0 Offset: 0x18EA0A0 VA: 0x1818EBAA0
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x18EB6E0 Offset: 0x18E9CE0 VA: 0x1818EB6E0
	public void SetColor(string name, Color value) { }

	// RVA: 0x18EB740 Offset: 0x18E9D40 VA: 0x1818EB740
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x18EB8E0 Offset: 0x18E9EE0 VA: 0x1818EB8E0
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x18EB5E0 Offset: 0x18E9BE0 VA: 0x1818EB5E0
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x18EB590 Offset: 0x18E9B90 VA: 0x1818EB590
	public void SetBuffer(int nameID, ComputeBuffer value) { }

	// RVA: 0x18EB9A0 Offset: 0x18E9FA0 VA: 0x1818EB9A0
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x18EB950 Offset: 0x18E9F50 VA: 0x1818EB950
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x18EB4E0 Offset: 0x18E9AE0 VA: 0x1818EB4E0
	public Texture GetTexture(int nameID) { }

	// RVA: 0x18EB180 Offset: 0x18E9780 VA: 0x1818EB180
	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes) { }

	// RVA: 0x18EAFC0 Offset: 0x18E95C0 VA: 0x1818EAFC0
	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	// RVA: 0x18EBA00 Offset: 0x18EA000 VA: 0x1818EBA00
	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

	// RVA: 0x18EB640 Offset: 0x18E9C40 VA: 0x1818EB640
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x18EB840 Offset: 0x18E9E40 VA: 0x1818EB840
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

