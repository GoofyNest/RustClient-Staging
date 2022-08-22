public class Material : Object // TypeDefIndex: 3406
{	// Properties
	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; }
	public int renderQueue { get; set; }
	[NativePropertyAttribute] // RVA: 0x94E40 Offset: 0x94240 VA: 0x180094E40
	public bool enableInstancing { get; set; }
	public int passCount { get; }
	public string[] shaderKeywords { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x93980 Offset: 0x92D80 VA: 0x180093980
	// RVA: 0x18EBC70 Offset: 0x18EA270 VA: 0x1818EBC70
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunctionAttribute] // RVA: 0x93AE0 Offset: 0x92EE0 VA: 0x180093AE0
	// RVA: 0x18EBC20 Offset: 0x18EA220 VA: 0x1818EBC20
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunctionAttribute] // RVA: 0x93CE0 Offset: 0x930E0 VA: 0x180093CE0
	// RVA: 0x18EBCC0 Offset: 0x18EA2C0 VA: 0x1818EBCC0
	private static void CreateWithString(Material self) { }

	// RVA: 0x18ED220 Offset: 0x18EB820 VA: 0x1818ED220
	public void .ctor(Shader shader) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18ED110 Offset: 0x18EB710 VA: 0x1818ED110
	public void .ctor(Material source) { }

	[EditorBrowsableAttribute] // RVA: 0x93EE0 Offset: 0x932E0 VA: 0x180093EE0
	[ObsoleteAttribute] // RVA: 0x93EE0 Offset: 0x932E0 VA: 0x180093EE0
	// RVA: 0x18ED1A0 Offset: 0x18EB7A0 VA: 0x1818ED1A0
	public void .ctor(string contents) { }

	// RVA: 0x18ED4E0 Offset: 0x18EBAE0 VA: 0x1818ED4E0
	public Shader get_shader() { }

	// RVA: 0x18ED670 Offset: 0x18EBC70 VA: 0x1818ED670
	public void set_shader(Shader value) { }

	// RVA: 0x18ED2B0 Offset: 0x18EB8B0 VA: 0x1818ED2B0
	public Color get_color() { }

	// RVA: 0x18ED520 Offset: 0x18EBB20 VA: 0x1818ED520
	public void set_color(Color value) { }

	// RVA: 0x18ED3C0 Offset: 0x18EB9C0 VA: 0x1818ED3C0
	public Texture get_mainTexture() { }

	[NativeNameAttribute] // RVA: 0x93F70 Offset: 0x93370 VA: 0x180093F70
	// RVA: 0x18EBF90 Offset: 0x18EA590 VA: 0x1818EBF90
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeNameAttribute] // RVA: 0x94080 Offset: 0x93480 VA: 0x180094080
	// RVA: 0x18EC4A0 Offset: 0x18EAAA0 VA: 0x1818EC4A0
	public bool HasProperty(int nameID) { }

	// RVA: 0x18EC450 Offset: 0x18EAA50 VA: 0x1818EC450
	public bool HasProperty(string name) { }

	[NativeNameAttribute] // RVA: 0x940F0 Offset: 0x934F0 VA: 0x1800940F0
	// RVA: 0x18ED4A0 Offset: 0x18EBAA0 VA: 0x1818ED4A0
	public int get_renderQueue() { }

	[NativeNameAttribute] // RVA: 0x94190 Offset: 0x93590 VA: 0x180094190
	// RVA: 0x18ED630 Offset: 0x18EBC30 VA: 0x1818ED630
	public void set_renderQueue(int value) { }

	// RVA: 0x18EBD50 Offset: 0x18EA350 VA: 0x1818EBD50
	public void EnableKeyword(string keyword) { }

	// RVA: 0x18EBD00 Offset: 0x18EA300 VA: 0x1818EBD00
	public void DisableKeyword(string keyword) { }

	// RVA: 0x18EC4E0 Offset: 0x18EAAE0 VA: 0x1818EC4E0
	public bool IsKeywordEnabled(string keyword) { }

	// RVA: 0x18ED380 Offset: 0x18EB980 VA: 0x1818ED380
	public bool get_enableInstancing() { }

	// RVA: 0x18ED5E0 Offset: 0x18EBBE0 VA: 0x1818ED5E0
	public void set_enableInstancing(bool value) { }

	// RVA: 0x18ED460 Offset: 0x18EBA60 VA: 0x1818ED460
	public int get_passCount() { }

	[FreeFunctionAttribute] // RVA: 0x94200 Offset: 0x93600 VA: 0x180094200
	// RVA: 0x18EC0E0 Offset: 0x18EA6E0 VA: 0x1818EC0E0
	public bool GetShaderPassEnabled(string passName) { }

	// RVA: 0x18EC060 Offset: 0x18EA660 VA: 0x1818EC060
	public string GetPassName(int pass) { }

	// RVA: 0x18EBDA0 Offset: 0x18EA3A0 VA: 0x1818EBDA0
	public int FindPass(string passName) { }

	// RVA: 0x18ECC70 Offset: 0x18EB270 VA: 0x1818ECC70
	public void SetOverrideTag(string tag, string val) { }

	[NativeNameAttribute] // RVA: 0x94350 Offset: 0x93750 VA: 0x180094350
	// RVA: 0x18EC130 Offset: 0x18EA730 VA: 0x1818EC130
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x18EC230 Offset: 0x18EA830 VA: 0x1818EC230
	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	// RVA: 0x18EC1A0 Offset: 0x18EA7A0 VA: 0x1818EC1A0
	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunctionAttribute] // RVA: 0x94460 Offset: 0x93860 VA: 0x180094460
	// RVA: 0x18ECCD0 Offset: 0x18EB2D0 VA: 0x1818ECCD0
	public bool SetPass(int pass) { }

	[FreeFunctionAttribute] // RVA: 0x944E0 Offset: 0x938E0 VA: 0x1800944E0
	// RVA: 0x18EBBD0 Offset: 0x18EA1D0 VA: 0x1818EBBD0
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunctionAttribute] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	// RVA: 0x18EC0A0 Offset: 0x18EA6A0 VA: 0x1818EC0A0
	private string[] GetShaderKeywords() { }

	[FreeFunctionAttribute] // RVA: 0x945F0 Offset: 0x939F0 VA: 0x1800945F0
	// RVA: 0x18ECD10 Offset: 0x18EB310 VA: 0x1818ECD10
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x18EC0A0 Offset: 0x18EA6A0 VA: 0x1818EC0A0
	public string[] get_shaderKeywords() { }

	// RVA: 0x18ECD10 Offset: 0x18EB310 VA: 0x1818ECD10
	public void set_shaderKeywords(string[] value) { }

	[NativeNameAttribute] // RVA: 0x8E790 Offset: 0x8DB90 VA: 0x18008E790
	// RVA: 0x18EC9C0 Offset: 0x18EAFC0 VA: 0x1818EC9C0
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E850 Offset: 0x8DC50 VA: 0x18008E850
	// RVA: 0x18EC630 Offset: 0x18EAC30 VA: 0x1818EC630
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E8B0 Offset: 0x8DCB0 VA: 0x18008E8B0
	// RVA: 0x18ECB30 Offset: 0x18EB130 VA: 0x1818ECB30
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E950 Offset: 0x8DD50 VA: 0x18008E950
	// RVA: 0x18ECD60 Offset: 0x18EB360 VA: 0x1818ECD60
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8EB70 Offset: 0x8DF70 VA: 0x18008EB70
	// RVA: 0x18EC530 Offset: 0x18EAB30 VA: 0x1818EC530
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeNameAttribute] // RVA: 0x949E0 Offset: 0x93DE0 VA: 0x1800949E0
	// RVA: 0x18EBFD0 Offset: 0x18EA5D0 VA: 0x1818EBFD0
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x94AE0 Offset: 0x93EE0 VA: 0x180094AE0
	// RVA: 0x18EBE40 Offset: 0x18EA440 VA: 0x1818EBE40
	private Color GetColorImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E6E0 Offset: 0x8DAE0 VA: 0x18008E6E0
	// RVA: 0x18EC2A0 Offset: 0x18EA8A0 VA: 0x1818EC2A0
	private Texture GetTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x94B90 Offset: 0x93F90 VA: 0x180094B90
	// RVA: 0x18EC730 Offset: 0x18EAD30 VA: 0x1818EC730
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeNameAttribute] // RVA: 0x94CC0 Offset: 0x940C0 VA: 0x180094CC0
	// RVA: 0x18ECE00 Offset: 0x18EB400 VA: 0x1818ECE00
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeNameAttribute] // RVA: 0x94DB0 Offset: 0x941B0 VA: 0x180094DB0
	// RVA: 0x18ECF00 Offset: 0x18EB500 VA: 0x1818ECF00
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	// RVA: 0x18EC890 Offset: 0x18EAE90 VA: 0x1818EC890
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x18ECA10 Offset: 0x18EB010 VA: 0x1818ECA10
	public void SetFloat(string name, float value) { }

	// RVA: 0x18EC9C0 Offset: 0x18EAFC0 VA: 0x1818EC9C0
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x18ECA70 Offset: 0x18EB070 VA: 0x1818ECA70
	public void SetInt(string name, int value) { }

	// RVA: 0x18EC6D0 Offset: 0x18EACD0 VA: 0x1818EC6D0
	public void SetColor(string name, Color value) { }

	// RVA: 0x18EC680 Offset: 0x18EAC80 VA: 0x1818EC680
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x18ED010 Offset: 0x18EB610 VA: 0x1818ED010
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x18ED0A0 Offset: 0x18EB6A0 VA: 0x1818ED0A0
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x18ECBF0 Offset: 0x18EB1F0 VA: 0x1818ECBF0
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x18ECB80 Offset: 0x18EB180 VA: 0x1818ECB80
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x18ECFB0 Offset: 0x18EB5B0 VA: 0x1818ECFB0
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x18ECD60 Offset: 0x18EB360 VA: 0x1818ECD60
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x18EC580 Offset: 0x18EAB80 VA: 0x1818EC580
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x18EC790 Offset: 0x18EAD90 VA: 0x1818EC790
	public void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x18EC010 Offset: 0x18EA610 VA: 0x1818EC010
	public float GetFloat(string name) { }

	// RVA: 0x18EBFD0 Offset: 0x18EA5D0 VA: 0x1818EBFD0
	public float GetFloat(int nameID) { }

	// RVA: 0x18EBF10 Offset: 0x18EA510 VA: 0x1818EBF10
	public Color GetColor(string name) { }

	// RVA: 0x18EBEA0 Offset: 0x18EA4A0 VA: 0x1818EBEA0
	public Color GetColor(int nameID) { }

	// RVA: 0x18EC330 Offset: 0x18EA930 VA: 0x1818EC330
	public Vector4 GetVector(string name) { }

	// RVA: 0x18EC3C0 Offset: 0x18EA9C0 VA: 0x1818EC3C0
	public Vector4 GetVector(int nameID) { }

	// RVA: 0x18EC2E0 Offset: 0x18EA8E0 VA: 0x1818EC2E0
	public Texture GetTexture(string name) { }

	// RVA: 0x18EC2A0 Offset: 0x18EA8A0 VA: 0x1818EC2A0
	public Texture GetTexture(int nameID) { }

	// RVA: 0x18ECE50 Offset: 0x18EB450 VA: 0x1818ECE50
	public void SetTextureOffset(string name, Vector2 value) { }

	// RVA: 0x18ECF50 Offset: 0x18EB550 VA: 0x1818ECF50
	public void SetTextureScale(string name, Vector2 value) { }

	// RVA: 0x18EC5E0 Offset: 0x18EABE0 VA: 0x1818EC5E0
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x18ECAE0 Offset: 0x18EB0E0 VA: 0x1818ECAE0
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x18EBDF0 Offset: 0x18EA3F0 VA: 0x1818EBDF0
	private void GetColorImpl_Injected(int name, out Color ret) { }

	// RVA: 0x18ECDB0 Offset: 0x18EB3B0 VA: 0x1818ECDB0
	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	// RVA: 0x18ECEB0 Offset: 0x18EB4B0 VA: 0x1818ECEB0
	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }

}

