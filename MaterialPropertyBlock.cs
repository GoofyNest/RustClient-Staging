public sealed class MaterialPropertyBlock // TypeDefIndex: 3402
{	internal IntPtr m_Ptr; // 0x10

	public bool isEmpty { get; }


	[NativeNameAttribute] // RVA: 0x8E6E0 Offset: 0x8DAE0 VA: 0x18008E6E0
	private Texture GetTextureImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E790 Offset: 0x8DB90 VA: 0x18008E790
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E7F0 Offset: 0x8DBF0 VA: 0x18008E7F0
	private void SetVectorImpl(int name, Vector4 value) { }

	[NativeNameAttribute] // RVA: 0x8E850 Offset: 0x8DC50 VA: 0x18008E850
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E8B0 Offset: 0x8DCB0 VA: 0x18008E8B0
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E950 Offset: 0x8DD50 VA: 0x18008E950
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8EB70 Offset: 0x8DF70 VA: 0x18008EB70
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x8ECC0 Offset: 0x8E0C0 VA: 0x18008ECC0
	internal static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	[NativeMethodAttribute] // RVA: 0x8ED20 Offset: 0x8E120 VA: 0x18008ED20
	private static IntPtr CreateImpl() { }

	[NativeMethodAttribute] // RVA: 0x8EE30 Offset: 0x8E230 VA: 0x18008EE30
	private static void DestroyImpl(IntPtr mpb) { }

	[NativeNameAttribute] // RVA: 0x8EF70 Offset: 0x8E370 VA: 0x18008EF70
	public bool get_isEmpty() { }

	private void Clear(bool keepMemory) { }

	public void Clear() { }

	public void .ctor() { }

	protected override void Finalize() { }

	private void Dispose() { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(int nameID, float value) { }

	public void SetVector(string name, Vector4 value) { }

	public void SetVector(int nameID, Vector4 value) { }

	public void SetColor(string name, Color value) { }

	public void SetColor(int nameID, Color value) { }

	public void SetMatrix(int nameID, Matrix4x4 value) { }

	public void SetBuffer(string name, ComputeBuffer value) { }

	public void SetBuffer(int nameID, ComputeBuffer value) { }

	public void SetTexture(string name, Texture value) { }

	public void SetTexture(int nameID, Texture value) { }

	public Texture GetTexture(int nameID) { }

	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes) { }

	public void CopySHCoefficientArraysFrom(SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	private void SetVectorImpl_Injected(int name, ref Vector4 value) { }

	private void SetColorImpl_Injected(int name, ref Color value) { }

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

}

