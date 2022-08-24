public class Material : Object // TypeDefIndex: 3406
{	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; }
	public int renderQueue { get; set; }
	[NativePropertyAttribute] // RVA: 0x94F80 Offset: 0x94380 VA: 0x180094F80
	public bool enableInstancing { get; set; }
	public int passCount { get; }
	public string[] shaderKeywords { get; set; }


	[FreeFunctionAttribute] // RVA: 0x93940 Offset: 0x92D40 VA: 0x180093940
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunctionAttribute] // RVA: 0x93B20 Offset: 0x92F20 VA: 0x180093B20
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunctionAttribute] // RVA: 0x93DA0 Offset: 0x931A0 VA: 0x180093DA0
	private static void CreateWithString(Material self) { }

	public void .ctor(Shader shader) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void .ctor(Material source) { }

	[EditorBrowsableAttribute] // RVA: 0x93FE0 Offset: 0x933E0 VA: 0x180093FE0
	[ObsoleteAttribute] // RVA: 0x93FE0 Offset: 0x933E0 VA: 0x180093FE0
	public void .ctor(string contents) { }

	public Shader get_shader() { }

	public void set_shader(Shader value) { }

	public Color get_color() { }

	public void set_color(Color value) { }

	public Texture get_mainTexture() { }

	[NativeNameAttribute] // RVA: 0x94090 Offset: 0x93490 VA: 0x180094090
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeNameAttribute] // RVA: 0x941A0 Offset: 0x935A0 VA: 0x1800941A0
	public bool HasProperty(int nameID) { }

	public bool HasProperty(string name) { }

	[NativeNameAttribute] // RVA: 0x941D0 Offset: 0x935D0 VA: 0x1800941D0
	public int get_renderQueue() { }

	[NativeNameAttribute] // RVA: 0x94280 Offset: 0x93680 VA: 0x180094280
	public void set_renderQueue(int value) { }

	public void EnableKeyword(string keyword) { }

	public void DisableKeyword(string keyword) { }

	public bool IsKeywordEnabled(string keyword) { }

	public bool get_enableInstancing() { }

	public void set_enableInstancing(bool value) { }

	public int get_passCount() { }

	[FreeFunctionAttribute] // RVA: 0x942B0 Offset: 0x936B0 VA: 0x1800942B0
	public bool GetShaderPassEnabled(string passName) { }

	public string GetPassName(int pass) { }

	public int FindPass(string passName) { }

	public void SetOverrideTag(string tag, string val) { }

	[NativeNameAttribute] // RVA: 0x943E0 Offset: 0x937E0 VA: 0x1800943E0
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunctionAttribute] // RVA: 0x94530 Offset: 0x93930 VA: 0x180094530
	public bool SetPass(int pass) { }

	[FreeFunctionAttribute] // RVA: 0x94600 Offset: 0x93A00 VA: 0x180094600
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunctionAttribute] // RVA: 0x94680 Offset: 0x93A80 VA: 0x180094680
	private string[] GetShaderKeywords() { }

	[FreeFunctionAttribute] // RVA: 0x94740 Offset: 0x93B40 VA: 0x180094740
	private void SetShaderKeywords(string[] names) { }

	public string[] get_shaderKeywords() { }

	public void set_shaderKeywords(string[] value) { }

	[NativeNameAttribute] // RVA: 0x8E7C0 Offset: 0x8DBC0 VA: 0x18008E7C0
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E940 Offset: 0x8DD40 VA: 0x18008E940
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E9A0 Offset: 0x8DDA0 VA: 0x18008E9A0
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8EA40 Offset: 0x8DE40 VA: 0x18008EA40
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8EBF0 Offset: 0x8DFF0 VA: 0x18008EBF0
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeNameAttribute] // RVA: 0x94B40 Offset: 0x93F40 VA: 0x180094B40
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x94C50 Offset: 0x94050 VA: 0x180094C50
	private Color GetColorImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E6C0 Offset: 0x8DAC0 VA: 0x18008E6C0
	private Texture GetTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x94C80 Offset: 0x94080 VA: 0x180094C80
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeNameAttribute] // RVA: 0x94DC0 Offset: 0x941C0 VA: 0x180094DC0
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeNameAttribute] // RVA: 0x94E90 Offset: 0x94290 VA: 0x180094E90
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

