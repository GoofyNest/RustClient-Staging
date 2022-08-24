public sealed class MaterialPropertyBlock // TypeDefIndex: 3402
{	internal IntPtr m_Ptr; // 0x10

	public bool isEmpty { get; }


	[NativeNameAttribute] // RVA: 0x8E820 Offset: 0x8DC20 VA: 0x18008E820
	private Texture GetTextureImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E8D0 Offset: 0x8DCD0 VA: 0x18008E8D0
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E930 Offset: 0x8DD30 VA: 0x18008E930
	private void SetVectorImpl(int name, Vector4 value) { }

	[NativeNameAttribute] // RVA: 0x8E990 Offset: 0x8DD90 VA: 0x18008E990
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E9F0 Offset: 0x8DDF0 VA: 0x18008E9F0
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8EA90 Offset: 0x8DE90 VA: 0x18008EA90
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8EC40 Offset: 0x8E040 VA: 0x18008EC40
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[FreeFunctionAttribute] // RVA: 0x8ED70 Offset: 0x8E170 VA: 0x18008ED70
	internal static void Internal_CopySHCoefficientArraysFrom(MaterialPropertyBlock properties, SphericalHarmonicsL2[] lightProbes, int sourceStart, int destStart, int count) { }

	[NativeMethodAttribute] // RVA: 0x8EDA0 Offset: 0x8E1A0 VA: 0x18008EDA0
	private static IntPtr CreateImpl() { }

	[NativeMethodAttribute] // RVA: 0x8EF40 Offset: 0x8E340 VA: 0x18008EF40
	private static void DestroyImpl(IntPtr mpb) { }

	[NativeNameAttribute] // RVA: 0x8F0B0 Offset: 0x8E4B0 VA: 0x18008F0B0
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

