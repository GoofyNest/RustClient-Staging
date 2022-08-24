public class Material : Object // TypeDefIndex: 3406
{	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; }
	public int renderQueue { get; set; }
	[NativePropertyAttribute] // RVA: 0x94F10 Offset: 0x94310 VA: 0x180094F10
	public bool enableInstancing { get; set; }
	public int passCount { get; }
	public string[] shaderKeywords { get; set; }


	[FreeFunctionAttribute] // RVA: 0x93AC0 Offset: 0x92EC0 VA: 0x180093AC0
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunctionAttribute] // RVA: 0x93C20 Offset: 0x93020 VA: 0x180093C20
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunctionAttribute] // RVA: 0x93E20 Offset: 0x93220 VA: 0x180093E20
	private static void CreateWithString(Material self) { }

	public void .ctor(Shader shader) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(Material source) { }

	[EditorBrowsableAttribute] // RVA: 0x93FA0 Offset: 0x933A0 VA: 0x180093FA0
	[ObsoleteAttribute] // RVA: 0x93FA0 Offset: 0x933A0 VA: 0x180093FA0
	public void .ctor(string contents) { }

	public Shader get_shader() { }

	public void set_shader(Shader value) { }

	public Color get_color() { }

	public void set_color(Color value) { }

	public Texture get_mainTexture() { }

	[NativeNameAttribute] // RVA: 0x94030 Offset: 0x93430 VA: 0x180094030
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeNameAttribute] // RVA: 0x94140 Offset: 0x93540 VA: 0x180094140
	public bool HasProperty(int nameID) { }

	public bool HasProperty(string name) { }

	[NativeNameAttribute] // RVA: 0x941B0 Offset: 0x935B0 VA: 0x1800941B0
	public int get_renderQueue() { }

	[NativeNameAttribute] // RVA: 0x94250 Offset: 0x93650 VA: 0x180094250
	public void set_renderQueue(int value) { }

	public void EnableKeyword(string keyword) { }

	public void DisableKeyword(string keyword) { }

	public bool IsKeywordEnabled(string keyword) { }

	public bool get_enableInstancing() { }

	public void set_enableInstancing(bool value) { }

	public int get_passCount() { }

	[FreeFunctionAttribute] // RVA: 0x942C0 Offset: 0x936C0 VA: 0x1800942C0
	public bool GetShaderPassEnabled(string passName) { }

	public string GetPassName(int pass) { }

	public int FindPass(string passName) { }

	public void SetOverrideTag(string tag, string val) { }

	[NativeNameAttribute] // RVA: 0x943F0 Offset: 0x937F0 VA: 0x1800943F0
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunctionAttribute] // RVA: 0x94540 Offset: 0x93940 VA: 0x180094540
	public bool SetPass(int pass) { }

	[FreeFunctionAttribute] // RVA: 0x945E0 Offset: 0x939E0 VA: 0x1800945E0
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunctionAttribute] // RVA: 0x94660 Offset: 0x93A60 VA: 0x180094660
	private string[] GetShaderKeywords() { }

	[FreeFunctionAttribute] // RVA: 0x946E0 Offset: 0x93AE0 VA: 0x1800946E0
	private void SetShaderKeywords(string[] names) { }

	public string[] get_shaderKeywords() { }

	public void set_shaderKeywords(string[] value) { }

	[NativeNameAttribute] // RVA: 0x8E8D0 Offset: 0x8DCD0 VA: 0x18008E8D0
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E990 Offset: 0x8DD90 VA: 0x18008E990
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E9F0 Offset: 0x8DDF0 VA: 0x18008E9F0
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8EA90 Offset: 0x8DE90 VA: 0x18008EA90
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8EC40 Offset: 0x8E040 VA: 0x18008EC40
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeNameAttribute] // RVA: 0x94AA0 Offset: 0x93EA0 VA: 0x180094AA0
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x94BA0 Offset: 0x93FA0 VA: 0x180094BA0
	private Color GetColorImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E820 Offset: 0x8DC20 VA: 0x18008E820
	private Texture GetTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x94C50 Offset: 0x94050 VA: 0x180094C50
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeNameAttribute] // RVA: 0x94D80 Offset: 0x94180 VA: 0x180094D80
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeNameAttribute] // RVA: 0x94E40 Offset: 0x94240 VA: 0x180094E40
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

