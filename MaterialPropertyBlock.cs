public sealed class MaterialPropertyBlock // TypeDefIndex: 3402
{	internal IntPtr m_Ptr; // 0x10

	public bool isEmpty { get; }


	[NativeNameAttribute] // RVA: 0x8E6C0 Offset: 0x8DAC0 VA: 0x18008E6C0
	private Texture GetTextureImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E7C0 Offset: 0x8DBC0 VA: 0x18008E7C0
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E860 Offset: 0x8DC60 VA: 0x18008E860
	private void SetVectorImpl(int name, Vector4 value) { }

	[NativeNameAttribute] // RVA: 0x8E940 Offset: 0x8DD40 VA: 0x18008E940
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E9A0 Offset: 0x8DDA0 VA: 0x18008E9A0
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8EA40 Offset: 0x8DE40 VA: 0x18008EA40
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8EBF0 Offset: 0x8DFF0 VA: 0x18008EBF0
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x8ECB0 Offset: 0x8E0B0 VA: 0x18008ECB0
	internal static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	[NativeMethodAttribute] // RVA: 0x8ED20 Offset: 0x8E120 VA: 0x18008ED20
	private static IntPtr CreateImpl() { }

	[NativeMethodAttribute] // RVA: 0x8EE70 Offset: 0x8E270 VA: 0x18008EE70
	private static void DestroyImpl(IntPtr mpb) { }

	[NativeNameAttribute] // RVA: 0x8EFF0 Offset: 0x8E3F0 VA: 0x18008EFF0
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

