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
	// RVA: 0x18EC290 Offset: 0x18EA890 VA: 0x1818EC290
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunctionAttribute] // RVA: 0x93AE0 Offset: 0x92EE0 VA: 0x180093AE0
	// RVA: 0x18EC240 Offset: 0x18EA840 VA: 0x1818EC240
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunctionAttribute] // RVA: 0x93CE0 Offset: 0x930E0 VA: 0x180093CE0
	// RVA: 0x18EC2E0 Offset: 0x18EA8E0 VA: 0x1818EC2E0
	private static void CreateWithString(Material self) { }

	// RVA: 0x18ED840 Offset: 0x18EBE40 VA: 0x1818ED840
	public void .ctor(Shader shader) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18ED730 Offset: 0x18EBD30 VA: 0x1818ED730
	public void .ctor(Material source) { }

	[EditorBrowsableAttribute] // RVA: 0x93EE0 Offset: 0x932E0 VA: 0x180093EE0
	[ObsoleteAttribute] // RVA: 0x93EE0 Offset: 0x932E0 VA: 0x180093EE0
	// RVA: 0x18ED7C0 Offset: 0x18EBDC0 VA: 0x1818ED7C0
	public void .ctor(string contents) { }

	// RVA: 0x18EDB00 Offset: 0x18EC100 VA: 0x1818EDB00
	public Shader get_shader() { }

	// RVA: 0x18EDC90 Offset: 0x18EC290 VA: 0x1818EDC90
	public void set_shader(Shader value) { }

	// RVA: 0x18ED8D0 Offset: 0x18EBED0 VA: 0x1818ED8D0
	public Color get_color() { }

	// RVA: 0x18EDB40 Offset: 0x18EC140 VA: 0x1818EDB40
	public void set_color(Color value) { }

	// RVA: 0x18ED9E0 Offset: 0x18EBFE0 VA: 0x1818ED9E0
	public Texture get_mainTexture() { }

	[NativeNameAttribute] // RVA: 0x93F70 Offset: 0x93370 VA: 0x180093F70
	// RVA: 0x18EC5B0 Offset: 0x18EABB0 VA: 0x1818EC5B0
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeNameAttribute] // RVA: 0x94080 Offset: 0x93480 VA: 0x180094080
	// RVA: 0x18ECAC0 Offset: 0x18EB0C0 VA: 0x1818ECAC0
	public bool HasProperty(int nameID) { }

	// RVA: 0x18ECA70 Offset: 0x18EB070 VA: 0x1818ECA70
	public bool HasProperty(string name) { }

	[NativeNameAttribute] // RVA: 0x940F0 Offset: 0x934F0 VA: 0x1800940F0
	// RVA: 0x18EDAC0 Offset: 0x18EC0C0 VA: 0x1818EDAC0
	public int get_renderQueue() { }

	[NativeNameAttribute] // RVA: 0x94190 Offset: 0x93590 VA: 0x180094190
	// RVA: 0x18EDC50 Offset: 0x18EC250 VA: 0x1818EDC50
	public void set_renderQueue(int value) { }

	// RVA: 0x18EC370 Offset: 0x18EA970 VA: 0x1818EC370
	public void EnableKeyword(string keyword) { }

	// RVA: 0x18EC320 Offset: 0x18EA920 VA: 0x1818EC320
	public void DisableKeyword(string keyword) { }

	// RVA: 0x18ECB00 Offset: 0x18EB100 VA: 0x1818ECB00
	public bool IsKeywordEnabled(string keyword) { }

	// RVA: 0x18ED9A0 Offset: 0x18EBFA0 VA: 0x1818ED9A0
	public bool get_enableInstancing() { }

	// RVA: 0x18EDC00 Offset: 0x18EC200 VA: 0x1818EDC00
	public void set_enableInstancing(bool value) { }

	// RVA: 0x18EDA80 Offset: 0x18EC080 VA: 0x1818EDA80
	public int get_passCount() { }

	[FreeFunctionAttribute] // RVA: 0x94200 Offset: 0x93600 VA: 0x180094200
	// RVA: 0x18EC700 Offset: 0x18EAD00 VA: 0x1818EC700
	public bool GetShaderPassEnabled(string passName) { }

	// RVA: 0x18EC680 Offset: 0x18EAC80 VA: 0x1818EC680
	public string GetPassName(int pass) { }

	// RVA: 0x18EC3C0 Offset: 0x18EA9C0 VA: 0x1818EC3C0
	public int FindPass(string passName) { }

	// RVA: 0x18ED290 Offset: 0x18EB890 VA: 0x1818ED290
	public void SetOverrideTag(string tag, string val) { }

	[NativeNameAttribute] // RVA: 0x94350 Offset: 0x93750 VA: 0x180094350
	// RVA: 0x18EC750 Offset: 0x18EAD50 VA: 0x1818EC750
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x18EC850 Offset: 0x18EAE50 VA: 0x1818EC850
	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	// RVA: 0x18EC7C0 Offset: 0x18EADC0 VA: 0x1818EC7C0
	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunctionAttribute] // RVA: 0x94460 Offset: 0x93860 VA: 0x180094460
	// RVA: 0x18ED2F0 Offset: 0x18EB8F0 VA: 0x1818ED2F0
	public bool SetPass(int pass) { }

	[FreeFunctionAttribute] // RVA: 0x944E0 Offset: 0x938E0 VA: 0x1800944E0
	// RVA: 0x18EC1F0 Offset: 0x18EA7F0 VA: 0x1818EC1F0
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunctionAttribute] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	// RVA: 0x18EC6C0 Offset: 0x18EACC0 VA: 0x1818EC6C0
	private string[] GetShaderKeywords() { }

	[FreeFunctionAttribute] // RVA: 0x945F0 Offset: 0x939F0 VA: 0x1800945F0
	// RVA: 0x18ED330 Offset: 0x18EB930 VA: 0x1818ED330
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x18EC6C0 Offset: 0x18EACC0 VA: 0x1818EC6C0
	public string[] get_shaderKeywords() { }

	// RVA: 0x18ED330 Offset: 0x18EB930 VA: 0x1818ED330
	public void set_shaderKeywords(string[] value) { }

	[NativeNameAttribute] // RVA: 0x8E790 Offset: 0x8DB90 VA: 0x18008E790
	// RVA: 0x18ECFE0 Offset: 0x18EB5E0 VA: 0x1818ECFE0
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E850 Offset: 0x8DC50 VA: 0x18008E850
	// RVA: 0x18ECC50 Offset: 0x18EB250 VA: 0x1818ECC50
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E8B0 Offset: 0x8DCB0 VA: 0x18008E8B0
	// RVA: 0x18ED150 Offset: 0x18EB750 VA: 0x1818ED150
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E950 Offset: 0x8DD50 VA: 0x18008E950
	// RVA: 0x18ED380 Offset: 0x18EB980 VA: 0x1818ED380
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8EB70 Offset: 0x8DF70 VA: 0x18008EB70
	// RVA: 0x18ECB50 Offset: 0x18EB150 VA: 0x1818ECB50
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeNameAttribute] // RVA: 0x949E0 Offset: 0x93DE0 VA: 0x1800949E0
	// RVA: 0x18EC5F0 Offset: 0x18EABF0 VA: 0x1818EC5F0
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x94AE0 Offset: 0x93EE0 VA: 0x180094AE0
	// RVA: 0x18EC460 Offset: 0x18EAA60 VA: 0x1818EC460
	private Color GetColorImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E6E0 Offset: 0x8DAE0 VA: 0x18008E6E0
	// RVA: 0x18EC8C0 Offset: 0x18EAEC0 VA: 0x1818EC8C0
	private Texture GetTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x94B90 Offset: 0x93F90 VA: 0x180094B90
	// RVA: 0x18ECD50 Offset: 0x18EB350 VA: 0x1818ECD50
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeNameAttribute] // RVA: 0x94CC0 Offset: 0x940C0 VA: 0x180094CC0
	// RVA: 0x18ED420 Offset: 0x18EBA20 VA: 0x1818ED420
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeNameAttribute] // RVA: 0x94DB0 Offset: 0x941B0 VA: 0x180094DB0
	// RVA: 0x18ED520 Offset: 0x18EBB20 VA: 0x1818ED520
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	// RVA: 0x18ECEB0 Offset: 0x18EB4B0 VA: 0x1818ECEB0
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x18ED030 Offset: 0x18EB630 VA: 0x1818ED030
	public void SetFloat(string name, float value) { }

	// RVA: 0x18ECFE0 Offset: 0x18EB5E0 VA: 0x1818ECFE0
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x18ED090 Offset: 0x18EB690 VA: 0x1818ED090
	public void SetInt(string name, int value) { }

	// RVA: 0x18ECCF0 Offset: 0x18EB2F0 VA: 0x1818ECCF0
	public void SetColor(string name, Color value) { }

	// RVA: 0x18ECCA0 Offset: 0x18EB2A0 VA: 0x1818ECCA0
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x18ED630 Offset: 0x18EBC30 VA: 0x1818ED630
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x18ED6C0 Offset: 0x18EBCC0 VA: 0x1818ED6C0
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x18ED210 Offset: 0x18EB810 VA: 0x1818ED210
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x18ED1A0 Offset: 0x18EB7A0 VA: 0x1818ED1A0
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x18ED5D0 Offset: 0x18EBBD0 VA: 0x1818ED5D0
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x18ED380 Offset: 0x18EB980 VA: 0x1818ED380
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x18ECBA0 Offset: 0x18EB1A0 VA: 0x1818ECBA0
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x18ECDB0 Offset: 0x18EB3B0 VA: 0x1818ECDB0
	public void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x18EC630 Offset: 0x18EAC30 VA: 0x1818EC630
	public float GetFloat(string name) { }

	// RVA: 0x18EC5F0 Offset: 0x18EABF0 VA: 0x1818EC5F0
	public float GetFloat(int nameID) { }

	// RVA: 0x18EC530 Offset: 0x18EAB30 VA: 0x1818EC530
	public Color GetColor(string name) { }

	// RVA: 0x18EC4C0 Offset: 0x18EAAC0 VA: 0x1818EC4C0
	public Color GetColor(int nameID) { }

	// RVA: 0x18EC950 Offset: 0x18EAF50 VA: 0x1818EC950
	public Vector4 GetVector(string name) { }

	// RVA: 0x18EC9E0 Offset: 0x18EAFE0 VA: 0x1818EC9E0
	public Vector4 GetVector(int nameID) { }

	// RVA: 0x18EC900 Offset: 0x18EAF00 VA: 0x1818EC900
	public Texture GetTexture(string name) { }

	// RVA: 0x18EC8C0 Offset: 0x18EAEC0 VA: 0x1818EC8C0
	public Texture GetTexture(int nameID) { }

	// RVA: 0x18ED470 Offset: 0x18EBA70 VA: 0x1818ED470
	public void SetTextureOffset(string name, Vector2 value) { }

	// RVA: 0x18ED570 Offset: 0x18EBB70 VA: 0x1818ED570
	public void SetTextureScale(string name, Vector2 value) { }

	// RVA: 0x18ECC00 Offset: 0x18EB200 VA: 0x1818ECC00
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x18ED100 Offset: 0x18EB700 VA: 0x1818ED100
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x18EC410 Offset: 0x18EAA10 VA: 0x1818EC410
	private void GetColorImpl_Injected(int name, out Color ret) { }

	// RVA: 0x18ED3D0 Offset: 0x18EB9D0 VA: 0x1818ED3D0
	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	// RVA: 0x18ED4D0 Offset: 0x18EBAD0 VA: 0x1818ED4D0
	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }

}

