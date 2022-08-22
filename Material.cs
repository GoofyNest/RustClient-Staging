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
	// RVA: 0x18EC550 Offset: 0x18EAB50 VA: 0x1818EC550
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunctionAttribute] // RVA: 0x93AE0 Offset: 0x92EE0 VA: 0x180093AE0
	// RVA: 0x18EC500 Offset: 0x18EAB00 VA: 0x1818EC500
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunctionAttribute] // RVA: 0x93CE0 Offset: 0x930E0 VA: 0x180093CE0
	// RVA: 0x18EC5A0 Offset: 0x18EABA0 VA: 0x1818EC5A0
	private static void CreateWithString(Material self) { }

	// RVA: 0x18EDB00 Offset: 0x18EC100 VA: 0x1818EDB00
	public void .ctor(Shader shader) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18ED9F0 Offset: 0x18EBFF0 VA: 0x1818ED9F0
	public void .ctor(Material source) { }

	[EditorBrowsableAttribute] // RVA: 0x93EE0 Offset: 0x932E0 VA: 0x180093EE0
	[ObsoleteAttribute] // RVA: 0x93EE0 Offset: 0x932E0 VA: 0x180093EE0
	// RVA: 0x18EDA80 Offset: 0x18EC080 VA: 0x1818EDA80
	public void .ctor(string contents) { }

	// RVA: 0x18EDDC0 Offset: 0x18EC3C0 VA: 0x1818EDDC0
	public Shader get_shader() { }

	// RVA: 0x18EDF50 Offset: 0x18EC550 VA: 0x1818EDF50
	public void set_shader(Shader value) { }

	// RVA: 0x18EDB90 Offset: 0x18EC190 VA: 0x1818EDB90
	public Color get_color() { }

	// RVA: 0x18EDE00 Offset: 0x18EC400 VA: 0x1818EDE00
	public void set_color(Color value) { }

	// RVA: 0x18EDCA0 Offset: 0x18EC2A0 VA: 0x1818EDCA0
	public Texture get_mainTexture() { }

	[NativeNameAttribute] // RVA: 0x93F70 Offset: 0x93370 VA: 0x180093F70
	// RVA: 0x18EC870 Offset: 0x18EAE70 VA: 0x1818EC870
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeNameAttribute] // RVA: 0x94080 Offset: 0x93480 VA: 0x180094080
	// RVA: 0x18ECD80 Offset: 0x18EB380 VA: 0x1818ECD80
	public bool HasProperty(int nameID) { }

	// RVA: 0x18ECD30 Offset: 0x18EB330 VA: 0x1818ECD30
	public bool HasProperty(string name) { }

	[NativeNameAttribute] // RVA: 0x940F0 Offset: 0x934F0 VA: 0x1800940F0
	// RVA: 0x18EDD80 Offset: 0x18EC380 VA: 0x1818EDD80
	public int get_renderQueue() { }

	[NativeNameAttribute] // RVA: 0x94190 Offset: 0x93590 VA: 0x180094190
	// RVA: 0x18EDF10 Offset: 0x18EC510 VA: 0x1818EDF10
	public void set_renderQueue(int value) { }

	// RVA: 0x18EC630 Offset: 0x18EAC30 VA: 0x1818EC630
	public void EnableKeyword(string keyword) { }

	// RVA: 0x18EC5E0 Offset: 0x18EABE0 VA: 0x1818EC5E0
	public void DisableKeyword(string keyword) { }

	// RVA: 0x18ECDC0 Offset: 0x18EB3C0 VA: 0x1818ECDC0
	public bool IsKeywordEnabled(string keyword) { }

	// RVA: 0x18EDC60 Offset: 0x18EC260 VA: 0x1818EDC60
	public bool get_enableInstancing() { }

	// RVA: 0x18EDEC0 Offset: 0x18EC4C0 VA: 0x1818EDEC0
	public void set_enableInstancing(bool value) { }

	// RVA: 0x18EDD40 Offset: 0x18EC340 VA: 0x1818EDD40
	public int get_passCount() { }

	[FreeFunctionAttribute] // RVA: 0x94200 Offset: 0x93600 VA: 0x180094200
	// RVA: 0x18EC9C0 Offset: 0x18EAFC0 VA: 0x1818EC9C0
	public bool GetShaderPassEnabled(string passName) { }

	// RVA: 0x18EC940 Offset: 0x18EAF40 VA: 0x1818EC940
	public string GetPassName(int pass) { }

	// RVA: 0x18EC680 Offset: 0x18EAC80 VA: 0x1818EC680
	public int FindPass(string passName) { }

	// RVA: 0x18ED550 Offset: 0x18EBB50 VA: 0x1818ED550
	public void SetOverrideTag(string tag, string val) { }

	[NativeNameAttribute] // RVA: 0x94350 Offset: 0x93750 VA: 0x180094350
	// RVA: 0x18ECA10 Offset: 0x18EB010 VA: 0x1818ECA10
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x18ECB10 Offset: 0x18EB110 VA: 0x1818ECB10
	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	// RVA: 0x18ECA80 Offset: 0x18EB080 VA: 0x1818ECA80
	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunctionAttribute] // RVA: 0x94460 Offset: 0x93860 VA: 0x180094460
	// RVA: 0x18ED5B0 Offset: 0x18EBBB0 VA: 0x1818ED5B0
	public bool SetPass(int pass) { }

	[FreeFunctionAttribute] // RVA: 0x944E0 Offset: 0x938E0 VA: 0x1800944E0
	// RVA: 0x18EC4B0 Offset: 0x18EAAB0 VA: 0x1818EC4B0
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunctionAttribute] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	// RVA: 0x18EC980 Offset: 0x18EAF80 VA: 0x1818EC980
	private string[] GetShaderKeywords() { }

	[FreeFunctionAttribute] // RVA: 0x945F0 Offset: 0x939F0 VA: 0x1800945F0
	// RVA: 0x18ED5F0 Offset: 0x18EBBF0 VA: 0x1818ED5F0
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x18EC980 Offset: 0x18EAF80 VA: 0x1818EC980
	public string[] get_shaderKeywords() { }

	// RVA: 0x18ED5F0 Offset: 0x18EBBF0 VA: 0x1818ED5F0
	public void set_shaderKeywords(string[] value) { }

	[NativeNameAttribute] // RVA: 0x8E790 Offset: 0x8DB90 VA: 0x18008E790
	// RVA: 0x18ED2A0 Offset: 0x18EB8A0 VA: 0x1818ED2A0
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E850 Offset: 0x8DC50 VA: 0x18008E850
	// RVA: 0x18ECF10 Offset: 0x18EB510 VA: 0x1818ECF10
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E8B0 Offset: 0x8DCB0 VA: 0x18008E8B0
	// RVA: 0x18ED410 Offset: 0x18EBA10 VA: 0x1818ED410
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E950 Offset: 0x8DD50 VA: 0x18008E950
	// RVA: 0x18ED640 Offset: 0x18EBC40 VA: 0x1818ED640
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8EB70 Offset: 0x8DF70 VA: 0x18008EB70
	// RVA: 0x18ECE10 Offset: 0x18EB410 VA: 0x1818ECE10
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeNameAttribute] // RVA: 0x949E0 Offset: 0x93DE0 VA: 0x1800949E0
	// RVA: 0x18EC8B0 Offset: 0x18EAEB0 VA: 0x1818EC8B0
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x94AE0 Offset: 0x93EE0 VA: 0x180094AE0
	// RVA: 0x18EC720 Offset: 0x18EAD20 VA: 0x1818EC720
	private Color GetColorImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E6E0 Offset: 0x8DAE0 VA: 0x18008E6E0
	// RVA: 0x18ECB80 Offset: 0x18EB180 VA: 0x1818ECB80
	private Texture GetTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x94B90 Offset: 0x93F90 VA: 0x180094B90
	// RVA: 0x18ED010 Offset: 0x18EB610 VA: 0x1818ED010
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeNameAttribute] // RVA: 0x94CC0 Offset: 0x940C0 VA: 0x180094CC0
	// RVA: 0x18ED6E0 Offset: 0x18EBCE0 VA: 0x1818ED6E0
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeNameAttribute] // RVA: 0x94DB0 Offset: 0x941B0 VA: 0x180094DB0
	// RVA: 0x18ED7E0 Offset: 0x18EBDE0 VA: 0x1818ED7E0
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	// RVA: 0x18ED170 Offset: 0x18EB770 VA: 0x1818ED170
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x18ED2F0 Offset: 0x18EB8F0 VA: 0x1818ED2F0
	public void SetFloat(string name, float value) { }

	// RVA: 0x18ED2A0 Offset: 0x18EB8A0 VA: 0x1818ED2A0
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x18ED350 Offset: 0x18EB950 VA: 0x1818ED350
	public void SetInt(string name, int value) { }

	// RVA: 0x18ECFB0 Offset: 0x18EB5B0 VA: 0x1818ECFB0
	public void SetColor(string name, Color value) { }

	// RVA: 0x18ECF60 Offset: 0x18EB560 VA: 0x1818ECF60
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x18ED8F0 Offset: 0x18EBEF0 VA: 0x1818ED8F0
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x18ED980 Offset: 0x18EBF80 VA: 0x1818ED980
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x18ED4D0 Offset: 0x18EBAD0 VA: 0x1818ED4D0
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x18ED460 Offset: 0x18EBA60 VA: 0x1818ED460
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x18ED890 Offset: 0x18EBE90 VA: 0x1818ED890
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x18ED640 Offset: 0x18EBC40 VA: 0x1818ED640
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x18ECE60 Offset: 0x18EB460 VA: 0x1818ECE60
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x18ED070 Offset: 0x18EB670 VA: 0x1818ED070
	public void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x18EC8F0 Offset: 0x18EAEF0 VA: 0x1818EC8F0
	public float GetFloat(string name) { }

	// RVA: 0x18EC8B0 Offset: 0x18EAEB0 VA: 0x1818EC8B0
	public float GetFloat(int nameID) { }

	// RVA: 0x18EC7F0 Offset: 0x18EADF0 VA: 0x1818EC7F0
	public Color GetColor(string name) { }

	// RVA: 0x18EC780 Offset: 0x18EAD80 VA: 0x1818EC780
	public Color GetColor(int nameID) { }

	// RVA: 0x18ECC10 Offset: 0x18EB210 VA: 0x1818ECC10
	public Vector4 GetVector(string name) { }

	// RVA: 0x18ECCA0 Offset: 0x18EB2A0 VA: 0x1818ECCA0
	public Vector4 GetVector(int nameID) { }

	// RVA: 0x18ECBC0 Offset: 0x18EB1C0 VA: 0x1818ECBC0
	public Texture GetTexture(string name) { }

	// RVA: 0x18ECB80 Offset: 0x18EB180 VA: 0x1818ECB80
	public Texture GetTexture(int nameID) { }

	// RVA: 0x18ED730 Offset: 0x18EBD30 VA: 0x1818ED730
	public void SetTextureOffset(string name, Vector2 value) { }

	// RVA: 0x18ED830 Offset: 0x18EBE30 VA: 0x1818ED830
	public void SetTextureScale(string name, Vector2 value) { }

	// RVA: 0x18ECEC0 Offset: 0x18EB4C0 VA: 0x1818ECEC0
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x18ED3C0 Offset: 0x18EB9C0 VA: 0x1818ED3C0
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x18EC6D0 Offset: 0x18EACD0 VA: 0x1818EC6D0
	private void GetColorImpl_Injected(int name, out Color ret) { }

	// RVA: 0x18ED690 Offset: 0x18EBC90 VA: 0x1818ED690
	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	// RVA: 0x18ED790 Offset: 0x18EBD90 VA: 0x1818ED790
	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }

}

