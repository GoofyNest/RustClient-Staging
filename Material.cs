public class Material : Object // TypeDefIndex: 3406
{	// Properties
	public Shader shader { get; set; }
	public Color color { get; set; }
	public Texture mainTexture { get; }
	public int renderQueue { get; set; }
	[NativePropertyAttribute] // RVA: 0x94DC0 Offset: 0x941C0 VA: 0x180094DC0
	public bool enableInstancing { get; set; }
	public int passCount { get; }
	public string[] shaderKeywords { get; set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0x93900 Offset: 0x92D00 VA: 0x180093900
	// RVA: 0x18EC2D0 Offset: 0x18EA8D0 VA: 0x1818EC2D0
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunctionAttribute] // RVA: 0x93A60 Offset: 0x92E60 VA: 0x180093A60
	// RVA: 0x18EC280 Offset: 0x18EA880 VA: 0x1818EC280
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunctionAttribute] // RVA: 0x93BD0 Offset: 0x92FD0 VA: 0x180093BD0
	// RVA: 0x18EC320 Offset: 0x18EA920 VA: 0x1818EC320
	private static void CreateWithString(Material self) { }

	// RVA: 0x18ED880 Offset: 0x18EBE80 VA: 0x1818ED880
	public void .ctor(Shader shader) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18ED770 Offset: 0x18EBD70 VA: 0x1818ED770
	public void .ctor(Material source) { }

	[EditorBrowsableAttribute] // RVA: 0x93E10 Offset: 0x93210 VA: 0x180093E10
	[ObsoleteAttribute] // RVA: 0x93E10 Offset: 0x93210 VA: 0x180093E10
	// RVA: 0x18ED800 Offset: 0x18EBE00 VA: 0x1818ED800
	public void .ctor(string contents) { }

	// RVA: 0x18EDB40 Offset: 0x18EC140 VA: 0x1818EDB40
	public Shader get_shader() { }

	// RVA: 0x18EDCD0 Offset: 0x18EC2D0 VA: 0x1818EDCD0
	public void set_shader(Shader value) { }

	// RVA: 0x18ED910 Offset: 0x18EBF10 VA: 0x1818ED910
	public Color get_color() { }

	// RVA: 0x18EDB80 Offset: 0x18EC180 VA: 0x1818EDB80
	public void set_color(Color value) { }

	// RVA: 0x18EDA20 Offset: 0x18EC020 VA: 0x1818EDA20
	public Texture get_mainTexture() { }

	[NativeNameAttribute] // RVA: 0x93EF0 Offset: 0x932F0 VA: 0x180093EF0
	// RVA: 0x18EC5F0 Offset: 0x18EABF0 VA: 0x1818EC5F0
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeNameAttribute] // RVA: 0x94000 Offset: 0x93400 VA: 0x180094000
	// RVA: 0x18ECB00 Offset: 0x18EB100 VA: 0x1818ECB00
	public bool HasProperty(int nameID) { }

	// RVA: 0x18ECAB0 Offset: 0x18EB0B0 VA: 0x1818ECAB0
	public bool HasProperty(string name) { }

	[NativeNameAttribute] // RVA: 0x94070 Offset: 0x93470 VA: 0x180094070
	// RVA: 0x18EDB00 Offset: 0x18EC100 VA: 0x1818EDB00
	public int get_renderQueue() { }

	[NativeNameAttribute] // RVA: 0x940E0 Offset: 0x934E0 VA: 0x1800940E0
	// RVA: 0x18EDC90 Offset: 0x18EC290 VA: 0x1818EDC90
	public void set_renderQueue(int value) { }

	// RVA: 0x18EC3B0 Offset: 0x18EA9B0 VA: 0x1818EC3B0
	public void EnableKeyword(string keyword) { }

	// RVA: 0x18EC360 Offset: 0x18EA960 VA: 0x1818EC360
	public void DisableKeyword(string keyword) { }

	// RVA: 0x18ECB40 Offset: 0x18EB140 VA: 0x1818ECB40
	public bool IsKeywordEnabled(string keyword) { }

	// RVA: 0x18ED9E0 Offset: 0x18EBFE0 VA: 0x1818ED9E0
	public bool get_enableInstancing() { }

	// RVA: 0x18EDC40 Offset: 0x18EC240 VA: 0x1818EDC40
	public void set_enableInstancing(bool value) { }

	// RVA: 0x18EDAC0 Offset: 0x18EC0C0 VA: 0x1818EDAC0
	public int get_passCount() { }

	[FreeFunctionAttribute] // RVA: 0x94180 Offset: 0x93580 VA: 0x180094180
	// RVA: 0x18EC740 Offset: 0x18EAD40 VA: 0x1818EC740
	public bool GetShaderPassEnabled(string passName) { }

	// RVA: 0x18EC6C0 Offset: 0x18EACC0 VA: 0x1818EC6C0
	public string GetPassName(int pass) { }

	// RVA: 0x18EC400 Offset: 0x18EAA00 VA: 0x1818EC400
	public int FindPass(string passName) { }

	// RVA: 0x18ED2D0 Offset: 0x18EB8D0 VA: 0x1818ED2D0
	public void SetOverrideTag(string tag, string val) { }

	[NativeNameAttribute] // RVA: 0x942D0 Offset: 0x936D0 VA: 0x1800942D0
	// RVA: 0x18EC790 Offset: 0x18EAD90 VA: 0x1818EC790
	private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue) { }

	// RVA: 0x18EC890 Offset: 0x18EAE90 VA: 0x1818EC890
	public string GetTag(string tag, bool searchFallbacks, string defaultValue) { }

	// RVA: 0x18EC800 Offset: 0x18EAE00 VA: 0x1818EC800
	public string GetTag(string tag, bool searchFallbacks) { }

	[FreeFunctionAttribute] // RVA: 0x94340 Offset: 0x93740 VA: 0x180094340
	// RVA: 0x18ED330 Offset: 0x18EB930 VA: 0x1818ED330
	public bool SetPass(int pass) { }

	[FreeFunctionAttribute] // RVA: 0x94460 Offset: 0x93860 VA: 0x180094460
	// RVA: 0x18EC230 Offset: 0x18EA830 VA: 0x1818EC230
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunctionAttribute] // RVA: 0x944F0 Offset: 0x938F0 VA: 0x1800944F0
	// RVA: 0x18EC700 Offset: 0x18EAD00 VA: 0x1818EC700
	private string[] GetShaderKeywords() { }

	[FreeFunctionAttribute] // RVA: 0x94570 Offset: 0x93970 VA: 0x180094570
	// RVA: 0x18ED370 Offset: 0x18EB970 VA: 0x1818ED370
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x18EC700 Offset: 0x18EAD00 VA: 0x1818EC700
	public string[] get_shaderKeywords() { }

	// RVA: 0x18ED370 Offset: 0x18EB970 VA: 0x1818ED370
	public void set_shaderKeywords(string[] value) { }

	[NativeNameAttribute] // RVA: 0x8E710 Offset: 0x8DB10 VA: 0x18008E710
	// RVA: 0x18ED020 Offset: 0x18EB620 VA: 0x1818ED020
	private void SetFloatImpl(int name, float value) { }

	[NativeNameAttribute] // RVA: 0x8E7D0 Offset: 0x8DBD0 VA: 0x18008E7D0
	// RVA: 0x18ECC90 Offset: 0x18EB290 VA: 0x1818ECC90
	private void SetColorImpl(int name, Color value) { }

	[NativeNameAttribute] // RVA: 0x8E830 Offset: 0x8DC30 VA: 0x18008E830
	// RVA: 0x18ED190 Offset: 0x18EB790 VA: 0x1818ED190
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeNameAttribute] // RVA: 0x8E8F0 Offset: 0x8DCF0 VA: 0x18008E8F0
	// RVA: 0x18ED3C0 Offset: 0x18EB9C0 VA: 0x1818ED3C0
	private void SetTextureImpl(int name, Texture value) { }

	[NativeNameAttribute] // RVA: 0x8E9B0 Offset: 0x8DDB0 VA: 0x18008E9B0
	// RVA: 0x18ECB90 Offset: 0x18EB190 VA: 0x1818ECB90
	private void SetBufferImpl(int name, ComputeBuffer value) { }

	[NativeNameAttribute] // RVA: 0x94960 Offset: 0x93D60 VA: 0x180094960
	// RVA: 0x18EC630 Offset: 0x18EAC30 VA: 0x1818EC630
	private float GetFloatImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x94A60 Offset: 0x93E60 VA: 0x180094A60
	// RVA: 0x18EC4A0 Offset: 0x18EAAA0 VA: 0x1818EC4A0
	private Color GetColorImpl(int name) { }

	[NativeNameAttribute] // RVA: 0x8E660 Offset: 0x8DA60 VA: 0x18008E660
	// RVA: 0x18EC900 Offset: 0x18EAF00 VA: 0x1818EC900
	private Texture GetTextureImpl(int name) { }

	[FreeFunctionAttribute] // RVA: 0x94B10 Offset: 0x93F10 VA: 0x180094B10
	// RVA: 0x18ECD90 Offset: 0x18EB390 VA: 0x1818ECD90
	private void SetFloatArrayImpl(int name, float[] values, int count) { }

	[NativeNameAttribute] // RVA: 0x94C40 Offset: 0x94040 VA: 0x180094C40
	// RVA: 0x18ED460 Offset: 0x18EBA60 VA: 0x1818ED460
	private void SetTextureOffsetImpl(int name, Vector2 offset) { }

	[NativeNameAttribute] // RVA: 0x94D10 Offset: 0x94110 VA: 0x180094D10
	// RVA: 0x18ED560 Offset: 0x18EBB60 VA: 0x1818ED560
	private void SetTextureScaleImpl(int name, Vector2 scale) { }

	// RVA: 0x18ECEF0 Offset: 0x18EB4F0 VA: 0x1818ECEF0
	private void SetFloatArray(int name, float[] values, int count) { }

	// RVA: 0x18ED070 Offset: 0x18EB670 VA: 0x1818ED070
	public void SetFloat(string name, float value) { }

	// RVA: 0x18ED020 Offset: 0x18EB620 VA: 0x1818ED020
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x18ED0D0 Offset: 0x18EB6D0 VA: 0x1818ED0D0
	public void SetInt(string name, int value) { }

	// RVA: 0x18ECD30 Offset: 0x18EB330 VA: 0x1818ECD30
	public void SetColor(string name, Color value) { }

	// RVA: 0x18ECCE0 Offset: 0x18EB2E0 VA: 0x1818ECCE0
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x18ED670 Offset: 0x18EBC70 VA: 0x1818ED670
	public void SetVector(string name, Vector4 value) { }

	// RVA: 0x18ED700 Offset: 0x18EBD00 VA: 0x1818ED700
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x18ED250 Offset: 0x18EB850 VA: 0x1818ED250
	public void SetMatrix(string name, Matrix4x4 value) { }

	// RVA: 0x18ED1E0 Offset: 0x18EB7E0 VA: 0x1818ED1E0
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x18ED610 Offset: 0x18EBC10 VA: 0x1818ED610
	public void SetTexture(string name, Texture value) { }

	// RVA: 0x18ED3C0 Offset: 0x18EB9C0 VA: 0x1818ED3C0
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x18ECBE0 Offset: 0x18EB1E0 VA: 0x1818ECBE0
	public void SetBuffer(string name, ComputeBuffer value) { }

	// RVA: 0x18ECDF0 Offset: 0x18EB3F0 VA: 0x1818ECDF0
	public void SetFloatArray(int nameID, float[] values) { }

	// RVA: 0x18EC670 Offset: 0x18EAC70 VA: 0x1818EC670
	public float GetFloat(string name) { }

	// RVA: 0x18EC630 Offset: 0x18EAC30 VA: 0x1818EC630
	public float GetFloat(int nameID) { }

	// RVA: 0x18EC570 Offset: 0x18EAB70 VA: 0x1818EC570
	public Color GetColor(string name) { }

	// RVA: 0x18EC500 Offset: 0x18EAB00 VA: 0x1818EC500
	public Color GetColor(int nameID) { }

	// RVA: 0x18EC990 Offset: 0x18EAF90 VA: 0x1818EC990
	public Vector4 GetVector(string name) { }

	// RVA: 0x18ECA20 Offset: 0x18EB020 VA: 0x1818ECA20
	public Vector4 GetVector(int nameID) { }

	// RVA: 0x18EC940 Offset: 0x18EAF40 VA: 0x1818EC940
	public Texture GetTexture(string name) { }

	// RVA: 0x18EC900 Offset: 0x18EAF00 VA: 0x1818EC900
	public Texture GetTexture(int nameID) { }

	// RVA: 0x18ED4B0 Offset: 0x18EBAB0 VA: 0x1818ED4B0
	public void SetTextureOffset(string name, Vector2 value) { }

	// RVA: 0x18ED5B0 Offset: 0x18EBBB0 VA: 0x1818ED5B0
	public void SetTextureScale(string name, Vector2 value) { }

	// RVA: 0x18ECC40 Offset: 0x18EB240 VA: 0x1818ECC40
	private void SetColorImpl_Injected(int name, ref Color value) { }

	// RVA: 0x18ED140 Offset: 0x18EB740 VA: 0x1818ED140
	private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value) { }

	// RVA: 0x18EC450 Offset: 0x18EAA50 VA: 0x1818EC450
	private void GetColorImpl_Injected(int name, out Color ret) { }

	// RVA: 0x18ED410 Offset: 0x18EBA10 VA: 0x1818ED410
	private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset) { }

	// RVA: 0x18ED510 Offset: 0x18EBB10 VA: 0x1818ED510
	private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale) { }

}

