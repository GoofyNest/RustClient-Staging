public class Material : Object // TypeDefIndex: 3406
{	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; }
	public int renderQueue { get; set; }
	[NativePropertyAttribute] // RVA: 0x94E40 Offset: 0x94240 VA: 0x180094E40
	public bool enableInstancing { get; set; }
	public int passCount { get; }
	public string[] shaderKeywords { get; set; }


	[FreeFunctionAttribute] // RVA: 0x93980 Offset: 0x92D80 VA: 0x180093980
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunctionAttribute] // RVA: 0x93AE0 Offset: 0x92EE0 VA: 0x180093AE0
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunctionAttribute] // RVA: 0x93CE0 Offset: 0x930E0 VA: 0x180093CE0
	private static void CreateWithString(Material self) { }

	public void .ctor(Shader shader) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(Material source) { }

	[EditorBrowsableAttribute] // RVA: 0x93EE0 Offset: 0x932E0 VA: 0x180093EE0
	[ObsoleteAttribute] // RVA: 0x93EE0 Offset: 0x932E0 VA: 0x180093EE0
	public void .ctor(string contents) { }

	public Shader get_shader() { }

	public void set_shader(Shader value) { }

	public Color get_color() { }

	public void set_color(Color value) { }

	public Texture get_mainTexture() { }

	[NativeNameAttribute] // RVA: 0x93F70 Offset: 0x93370 VA: 0x180093F70
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeNameAttribute] // RVA: 0x94080 Offset: 0x93480 VA: 0x180094080
	public bool HasProperty(int nameID) { }

	public bool HasProperty(string name) { }

	[NativeNameAttribute] // RVA: 0x940F0 Offset: 0x934F0 VA: 0x1800940F0
	public int get_renderQueue() { }

	[NativeNameAttribute] // RVA: 0x94190 Offset: 0x93590 VA: 0x180094190
	public void set_renderQueue(int value) { }

	public void EnableKeyword(string keyword) { }

	public void DisableKeyword(string keyword) { }

	public bool IsKeywordEnabled(string keyword) { }

	public bool get_enableInstancing() { }

	public void set_enableInstancing(bool value) { }

	public int get_passCount() { }

	[FreeFunctionAttribute] // RVA: 0x94200 Offset: 0x93600 VA: 0x180094200
	public bool GetShaderPassEnabled(string passName) { }

	public string GetPassName(int pass) { }

	public int FindPass(string passName) { }

	public void SetOverrideTag(string tag, string val) { }

	[NativeNameAttribute] // RVA: 0x94350 Offset: 0x93750 VA: 0x180094350
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunctionAttribute] // RVA: 0x94460 Offset: 0x93860 VA: 0x180094460
	public bool SetPass(int pass) { }

	[FreeFunctionAttribute] // RVA: 0x944E0 Offset: 0x938E0 VA: 0x1800944E0
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunctionAttribute] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	private string[] GetShaderKeywords() { }

	[FreeFunctionAttribute] // RVA: 0x945F0 Offset: 0x939F0 VA: 0x1800945F0
	private void SetShaderKeywords(string[] names) { }

	public string[] get_shaderKeywords() { }

	public void set_shaderKeywords(string[] value) { }

	[NativeNameAttribute] // RVA: 0x8E790 Offset: 0x8DB90 VA: 0x18008E790
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E850 Offset: 0x8DC50 VA: 0x18008E850
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E8B0 Offset: 0x8DCB0 VA: 0x18008E8B0
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E950 Offset: 0x8DD50 VA: 0x18008E950
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8EB70 Offset: 0x8DF70 VA: 0x18008EB70
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeNameAttribute] // RVA: 0x949E0 Offset: 0x93DE0 VA: 0x1800949E0
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x94AE0 Offset: 0x93EE0 VA: 0x180094AE0
	private Color GetColorImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E6E0 Offset: 0x8DAE0 VA: 0x18008E6E0
	private Texture GetTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x94B90 Offset: 0x93F90 VA: 0x180094B90
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeNameAttribute] // RVA: 0x94CC0 Offset: 0x940C0 VA: 0x180094CC0
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeNameAttribute] // RVA: 0x94DB0 Offset: 0x941B0 VA: 0x180094DB0
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	private void SetFloatArray(int name, float[] values, int count) { }

	public void SetFloat(string name, float value) { }

	public void SetFloat(int nameID, float value) { }

	public void SetInt(string name, int value) { }

	public void SetColor(string name, Color value) { }

	public void SetColor(int nameID, Color value) { }

	public void SetVector(string name, Vector4 value) { }

	public void SetVector(int nameID, Vector4 value) { }

	public void SetMatrix(string name, Matrix4x4 value) { }

	public void SetMatrix(int nameID, Matrix4x4 value) { }

	public void SetTexture(string name, Texture value) { }

	public void SetTexture(int nameID, Texture value) { }

	public void SetBuffer(string name, ComputeBuffer value) { }

	public void SetFloatArray(int nameID, float[] values) { }

	public float GetFloat(string name) { }

	public float GetFloat(int nameID) { }

	public Color GetColor(string name) { }

	public Color GetColor(int nameID) { }

	public Vector4 GetVector(string name) { }

	public Vector4 GetVector(int nameID) { }

	public Texture GetTexture(string name) { }

	public Texture GetTexture(int nameID) { }

	public void SetTextureOffset(string name, Vector2 value) { }

	public void SetTextureScale(string name, Vector2 value) { }

	private void SetColorImpl_Injected(int name, ref Color value) { }

	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	private void GetColorImpl_Injected(int name, out Color ret) { }

	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }

}

