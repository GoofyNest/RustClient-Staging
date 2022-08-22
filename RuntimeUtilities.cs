public static class RuntimeUtilities // TypeDefIndex: 11867
{	// Fields
	private static Texture2D m_WhiteTexture; // 0x0
	private static Texture3D m_WhiteTexture3D; // 0x8
	private static Texture2D m_BlackTexture; // 0x10
	private static Texture3D m_BlackTexture3D; // 0x18
	private static Texture2D m_TransparentTexture; // 0x20
	private static Texture3D m_TransparentTexture3D; // 0x28
	private static Dictionary<int, Texture2D> m_LutStrips; // 0x30
	internal static PostProcessResources s_Resources; // 0x38
	private static Mesh s_FullscreenTriangle; // 0x40
	private static Material s_CopyStdMaterial; // 0x48
	private static Material s_CopyStdFromDoubleWideMaterial; // 0x50
	private static Material s_CopyMaterial; // 0x58
	private static Material s_CopyFromTexArrayMaterial; // 0x60
	private static PropertySheet s_CopySheet; // 0x68
	private static PropertySheet s_CopyFromTexArraySheet; // 0x70
	private static IEnumerable<Type> m_AssemblyTypes; // 0x78

	// Properties
	public static Texture2D whiteTexture { get; }
	public static Texture3D whiteTexture3D { get; }
	public static Texture2D blackTexture { get; }
	public static Texture3D blackTexture3D { get; }
	public static Texture2D transparentTexture { get; }
	public static Texture3D transparentTexture3D { get; }
	public static Mesh fullscreenTriangle { get; }
	public static Material copyStdMaterial { get; }
	public static Material copyStdFromDoubleWideMaterial { get; }
	public static Material copyMaterial { get; }
	public static Material copyFromTexArrayMaterial { get; }
	public static PropertySheet copySheet { get; }
	public static PropertySheet copyFromTexArraySheet { get; }
	public static bool scriptableRenderPipelineActive { get; }
	public static bool supportsDeferredShading { get; }
	public static bool supportsDepthNormals { get; }
	public static bool isSinglePassStereoEnabled { get; }
	public static bool isVREnabled { get; }
	public static bool isAndroidOpenGL { get; }
	public static RenderTextureFormat defaultHDRRenderTextureFormat { get; }
	public static bool isLinearColorSpace { get; }

	// Methods

	// RVA: 0x11DB270 Offset: 0x11D9870 VA: 0x1811DB270
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x11DB080 Offset: 0x11D9680 VA: 0x1811DB080
	public static Texture3D get_whiteTexture3D() { }

	// RVA: 0x11D9A40 Offset: 0x11D8040 VA: 0x1811D9A40
	public static Texture2D get_blackTexture() { }

	// RVA: 0x11D9850 Offset: 0x11D7E50 VA: 0x1811D9850
	public static Texture3D get_blackTexture3D() { }

	// RVA: 0x11DAEC0 Offset: 0x11D94C0 VA: 0x1811DAEC0
	public static Texture2D get_transparentTexture() { }

	// RVA: 0x11DACD0 Offset: 0x11D92D0 VA: 0x1811DACD0
	public static Texture3D get_transparentTexture3D() { }

	// RVA: 0x11D90F0 Offset: 0x11D76F0 VA: 0x1811D90F0
	public static Texture2D GetLutStrip(int size) { }

	// RVA: 0x11DA740 Offset: 0x11D8D40 VA: 0x1811DA740
	public static Mesh get_fullscreenTriangle() { }

	// RVA: 0x11DA560 Offset: 0x11D8B60 VA: 0x1811DA560
	public static Material get_copyStdMaterial() { }

	// RVA: 0x11DA380 Offset: 0x11D8980 VA: 0x1811DA380
	public static Material get_copyStdFromDoubleWideMaterial() { }

	// RVA: 0x11DA090 Offset: 0x11D8690 VA: 0x1811DA090
	public static Material get_copyMaterial() { }

	// RVA: 0x11D9C00 Offset: 0x11D8200 VA: 0x1811D9C00
	public static Material get_copyFromTexArrayMaterial() { }

	// RVA: 0x11DA270 Offset: 0x11D8870 VA: 0x1811DA270
	public static PropertySheet get_copySheet() { }

	// RVA: 0x11D9DE0 Offset: 0x11D83E0 VA: 0x1811D9DE0
	public static PropertySheet get_copyFromTexArraySheet() { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D9790 Offset: 0x11D7D90 VA: 0x1811D9790
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D9700 Offset: 0x11D7D00 VA: 0x1811D9700
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7D90 Offset: 0x11D6390 VA: 0x1811D7D90
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7B20 Offset: 0x11D6120 VA: 0x1811D7B20
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D76F0 Offset: 0x11D5CF0 VA: 0x1811D76F0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D6E80 Offset: 0x11D5480 VA: 0x1811D6E80
	public static void BlitFullscreenTriangleFromDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7290 Offset: 0x11D5890 VA: 0x1811D7290
	public static void BlitFullscreenTriangleToDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7060 Offset: 0x11D5660 VA: 0x1811D7060
	public static void BlitFullscreenTriangleFromTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D74D0 Offset: 0x11D5AD0 VA: 0x1811D74D0
	public static void BlitFullscreenTriangleToTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7820 Offset: 0x11D5E20 VA: 0x1811D7820
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D8030 Offset: 0x11D6630 VA: 0x1811D8030
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D8350 Offset: 0x11D6950 VA: 0x1811D8350
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D8250 Offset: 0x11D6850 VA: 0x1811D8250
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0) { }

	// RVA: 0x11D8430 Offset: 0x11D6A30 VA: 0x1811D8430
	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	// RVA: 0x11DAB10 Offset: 0x11D9110 VA: 0x1811DAB10
	public static bool get_scriptableRenderPipelineActive() { }

	// RVA: 0x11DAB70 Offset: 0x11D9170 VA: 0x1811DAB70
	public static bool get_supportsDeferredShading() { }

	// RVA: 0x11DAC20 Offset: 0x11D9220 VA: 0x1811DAC20
	public static bool get_supportsDepthNormals() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public static bool get_isSinglePassStereoEnabled() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public static bool get_isVREnabled() { }

	// RVA: 0x11DAAC0 Offset: 0x11D90C0 VA: 0x1811DAAC0
	public static bool get_isAndroidOpenGL() { }

	// RVA: 0xE665F0 Offset: 0xE64BF0 VA: 0x180E665F0
	public static RenderTextureFormat get_defaultHDRRenderTextureFormat() { }

	// RVA: 0x11DB420 Offset: 0x11D9A20 VA: 0x1811DB420
	public static bool isFloatingPointFormat(RenderTextureFormat format) { }

	// RVA: 0x11D8860 Offset: 0x11D6E60 VA: 0x1811D8860
	public static void Destroy(Object obj) { }

	// RVA: 0x11DAAF0 Offset: 0x11D90F0 VA: 0x1811DAAF0
	public static bool get_isLinearColorSpace() { }

	// RVA: 0x11D95A0 Offset: 0x11D7BA0 VA: 0x1811D95A0
	public static bool IsResolvedDepthAvailable(Camera camera) { }

	// RVA: 0x11D85A0 Offset: 0x11D6BA0 VA: 0x1811D85A0
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects) { }

	// RVA: 0x11D8710 Offset: 0x11D6D10 VA: 0x1811D8710
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = False) { }

	// RVA: 0x11D9520 Offset: 0x11D7B20 VA: 0x1811D9520
	public static bool IsPostProcessingActive(PostProcessLayer layer) { }

	// RVA: 0x11D9610 Offset: 0x11D7C10 VA: 0x1811D9610
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer) { }

	[IteratorStateMachineAttribute] // RVA: 0x7FE40 Offset: 0x7F240 VA: 0x18007FE40
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetAllSceneObjects<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD03230 Offset: 0xD01830 VA: 0x180D03230
	|-RuntimeUtilities.GetAllSceneObjects<object>
	*/

	// RVA: -1 Offset: -1
	public static void CreateIfNull<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3BB0 Offset: 0x5D21B0 VA: 0x1805D3BB0
	|-RuntimeUtilities.CreateIfNull<List<PostProcessLayer.SerializedBundleRef>>
	|-RuntimeUtilities.CreateIfNull<object>
	|-RuntimeUtilities.CreateIfNull<Dithering>
	|-RuntimeUtilities.CreateIfNull<FastApproximateAntialiasing>
	|-RuntimeUtilities.CreateIfNull<Fog>
	|-RuntimeUtilities.CreateIfNull<HistogramMonitor>
	|-RuntimeUtilities.CreateIfNull<LightMeterMonitor>
	|-RuntimeUtilities.CreateIfNull<PostProcessDebugLayer.OverlaySettings>
	|-RuntimeUtilities.CreateIfNull<PostProcessDebugLayer>
	|-RuntimeUtilities.CreateIfNull<SubpixelMorphologicalAntialiasing>
	|-RuntimeUtilities.CreateIfNull<TemporalAntialiasing>
	|-RuntimeUtilities.CreateIfNull<VectorscopeMonitor>
	|-RuntimeUtilities.CreateIfNull<WaveformMonitor>
	*/

	// RVA: 0x11D88F0 Offset: 0x11D6EF0 VA: 0x1811D88F0
	public static float Exp2(float x) { }

	// RVA: 0x11D8EF0 Offset: 0x11D74F0 VA: 0x1811D8EF0
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset) { }

	// RVA: 0x11D8D00 Offset: 0x11D7300 VA: 0x1811D8D00
	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset) { }

	// RVA: 0x11D8950 Offset: 0x11D6F50 VA: 0x1811D8950
	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter) { }

	// RVA: 0x11D8B30 Offset: 0x11D7130 VA: 0x1811D8B30
	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BAA30 Offset: 0x15B9030 VA: 0x1815BAA30
	|-RuntimeUtilities.GetAttribute<object>
	|-RuntimeUtilities.GetAttribute<PostProcessAttribute>
	*/

	// RVA: -1 Offset: -1
	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125ED70 Offset: 0x125D370 VA: 0x18125ED70
	|-RuntimeUtilities.GetMemberAttributes<object, object>
	*/

	// RVA: -1 Offset: -1
	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED81E0 Offset: 0xED67E0 VA: 0x180ED81E0
	|-RuntimeUtilities.GetFieldPath<object, object>
	*/

	// RVA: 0x11D97E0 Offset: 0x11D7DE0 VA: 0x1811D97E0
	private static void .cctor() { }

}

private sealed class RuntimeUtilities.<GetAllSceneObjects>d__79<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 11868
{	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Queue<Transform> <queue>5__2; // 0x0
	private GameObject[] <>7__wrap2; // 0x0
	private int <>7__wrap3; // 0x0
	private IEnumerator <>7__wrap4; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144B840 Offset: 0x1449E40 VA: 0x18144B840
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6F00 Offset: 0x19C5500 VA: 0x1819C6F00
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6A10 Offset: 0x19C5010 VA: 0x1819C6A10
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6F80 Offset: 0x19C5580 VA: 0x1819C6F80
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6EB0 Offset: 0x19C54B0 VA: 0x1819C6EB0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6DE0 Offset: 0x19C53E0 VA: 0x1819C6DE0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6E80 Offset: 0x19C5480 VA: 0x1819C6E80
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class RuntimeUtilities.<>c // TypeDefIndex: 11869
{	// Fields
	public static readonly RuntimeUtilities.<>c <>9; // 0x0
	public static Func<Assembly, IEnumerable<Type>> <>9__86_0; // 0x8

	// Methods

	// RVA: 0x11E78B0 Offset: 0x11E5EB0 VA: 0x1811E78B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11E7740 Offset: 0x11E5D40 VA: 0x1811E7740
	internal IEnumerable<Type> <GetAllAssemblyTypes>b__86_0(Assembly t) { }

}

