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

	// RVA: 0x11DBBD0 Offset: 0x11DA1D0 VA: 0x1811DBBD0
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x11DB9E0 Offset: 0x11D9FE0 VA: 0x1811DB9E0
	public static Texture3D get_whiteTexture3D() { }

	// RVA: 0x11DA3A0 Offset: 0x11D89A0 VA: 0x1811DA3A0
	public static Texture2D get_blackTexture() { }

	// RVA: 0x11DA1B0 Offset: 0x11D87B0 VA: 0x1811DA1B0
	public static Texture3D get_blackTexture3D() { }

	// RVA: 0x11DB820 Offset: 0x11D9E20 VA: 0x1811DB820
	public static Texture2D get_transparentTexture() { }

	// RVA: 0x11DB630 Offset: 0x11D9C30 VA: 0x1811DB630
	public static Texture3D get_transparentTexture3D() { }

	// RVA: 0x11D9A50 Offset: 0x11D8050 VA: 0x1811D9A50
	public static Texture2D GetLutStrip(int size) { }

	// RVA: 0x11DB0A0 Offset: 0x11D96A0 VA: 0x1811DB0A0
	public static Mesh get_fullscreenTriangle() { }

	// RVA: 0x11DAEC0 Offset: 0x11D94C0 VA: 0x1811DAEC0
	public static Material get_copyStdMaterial() { }

	// RVA: 0x11DACE0 Offset: 0x11D92E0 VA: 0x1811DACE0
	public static Material get_copyStdFromDoubleWideMaterial() { }

	// RVA: 0x11DA9F0 Offset: 0x11D8FF0 VA: 0x1811DA9F0
	public static Material get_copyMaterial() { }

	// RVA: 0x11DA560 Offset: 0x11D8B60 VA: 0x1811DA560
	public static Material get_copyFromTexArrayMaterial() { }

	// RVA: 0x11DABD0 Offset: 0x11D91D0 VA: 0x1811DABD0
	public static PropertySheet get_copySheet() { }

	// RVA: 0x11DA740 Offset: 0x11D8D40 VA: 0x1811DA740
	public static PropertySheet get_copyFromTexArraySheet() { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11DA0F0 Offset: 0x11D86F0 VA: 0x1811DA0F0
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11DA060 Offset: 0x11D8660 VA: 0x1811DA060
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D86F0 Offset: 0x11D6CF0 VA: 0x1811D86F0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D8480 Offset: 0x11D6A80 VA: 0x1811D8480
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D8050 Offset: 0x11D6650 VA: 0x1811D8050
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D77E0 Offset: 0x11D5DE0 VA: 0x1811D77E0
	public static void BlitFullscreenTriangleFromDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7BF0 Offset: 0x11D61F0 VA: 0x1811D7BF0
	public static void BlitFullscreenTriangleToDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D79C0 Offset: 0x11D5FC0 VA: 0x1811D79C0
	public static void BlitFullscreenTriangleFromTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7E30 Offset: 0x11D6430 VA: 0x1811D7E30
	public static void BlitFullscreenTriangleToTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D8180 Offset: 0x11D6780 VA: 0x1811D8180
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D8990 Offset: 0x11D6F90 VA: 0x1811D8990
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D8CB0 Offset: 0x11D72B0 VA: 0x1811D8CB0
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D8BB0 Offset: 0x11D71B0 VA: 0x1811D8BB0
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0) { }

	// RVA: 0x11D8D90 Offset: 0x11D7390 VA: 0x1811D8D90
	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	// RVA: 0x11DB470 Offset: 0x11D9A70 VA: 0x1811DB470
	public static bool get_scriptableRenderPipelineActive() { }

	// RVA: 0x11DB4D0 Offset: 0x11D9AD0 VA: 0x1811DB4D0
	public static bool get_supportsDeferredShading() { }

	// RVA: 0x11DB580 Offset: 0x11D9B80 VA: 0x1811DB580
	public static bool get_supportsDepthNormals() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public static bool get_isSinglePassStereoEnabled() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public static bool get_isVREnabled() { }

	// RVA: 0x11DB420 Offset: 0x11D9A20 VA: 0x1811DB420
	public static bool get_isAndroidOpenGL() { }

	// RVA: 0xE67360 Offset: 0xE65960 VA: 0x180E67360
	public static RenderTextureFormat get_defaultHDRRenderTextureFormat() { }

	// RVA: 0x11DBD80 Offset: 0x11DA380 VA: 0x1811DBD80
	public static bool isFloatingPointFormat(RenderTextureFormat format) { }

	// RVA: 0x11D91C0 Offset: 0x11D77C0 VA: 0x1811D91C0
	public static void Destroy(Object obj) { }

	// RVA: 0x11DB450 Offset: 0x11D9A50 VA: 0x1811DB450
	public static bool get_isLinearColorSpace() { }

	// RVA: 0x11D9F00 Offset: 0x11D8500 VA: 0x1811D9F00
	public static bool IsResolvedDepthAvailable(Camera camera) { }

	// RVA: 0x11D8F00 Offset: 0x11D7500 VA: 0x1811D8F00
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects) { }

	// RVA: 0x11D9070 Offset: 0x11D7670 VA: 0x1811D9070
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = False) { }

	// RVA: 0x11D9E80 Offset: 0x11D8480 VA: 0x1811D9E80
	public static bool IsPostProcessingActive(PostProcessLayer layer) { }

	// RVA: 0x11D9F70 Offset: 0x11D8570 VA: 0x1811D9F70
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer) { }

	[IteratorStateMachineAttribute] // RVA: 0x7FE40 Offset: 0x7F240 VA: 0x18007FE40
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetAllSceneObjects<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD03990 Offset: 0xD01F90 VA: 0x180D03990
	|-RuntimeUtilities.GetAllSceneObjects<object>
	*/

	// RVA: -1 Offset: -1
	public static void CreateIfNull<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5D3B40 Offset: 0x5D2140 VA: 0x1805D3B40
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

	// RVA: 0x11D9250 Offset: 0x11D7850 VA: 0x1811D9250
	public static float Exp2(float x) { }

	// RVA: 0x11D9850 Offset: 0x11D7E50 VA: 0x1811D9850
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset) { }

	// RVA: 0x11D9660 Offset: 0x11D7C60 VA: 0x1811D9660
	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset) { }

	// RVA: 0x11D92B0 Offset: 0x11D78B0 VA: 0x1811D92B0
	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter) { }

	// RVA: 0x11D9490 Offset: 0x11D7A90 VA: 0x1811D9490
	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9DC0 Offset: 0x15B83C0 VA: 0x1815B9DC0
	|-RuntimeUtilities.GetAttribute<object>
	|-RuntimeUtilities.GetAttribute<PostProcessAttribute>
	*/

	// RVA: -1 Offset: -1
	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F6D0 Offset: 0x125DCD0 VA: 0x18125F6D0
	|-RuntimeUtilities.GetMemberAttributes<object, object>
	*/

	// RVA: -1 Offset: -1
	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED8F50 Offset: 0xED7550 VA: 0x180ED8F50
	|-RuntimeUtilities.GetFieldPath<object, object>
	*/

	// RVA: 0x11DA140 Offset: 0x11D8740 VA: 0x1811DA140
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
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B45C0 Offset: 0x19B2BC0 VA: 0x1819B45C0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B40D0 Offset: 0x19B26D0 VA: 0x1819B40D0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4640 Offset: 0x19B2C40 VA: 0x1819B4640
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
	|-RVA: 0x19B4570 Offset: 0x19B2B70 VA: 0x1819B4570
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
	|-RVA: 0x19B44A0 Offset: 0x19B2AA0 VA: 0x1819B44A0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4540 Offset: 0x19B2B40 VA: 0x1819B4540
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class RuntimeUtilities.<>c // TypeDefIndex: 11869
{	// Fields
	public static readonly RuntimeUtilities.<>c <>9; // 0x0
	public static Func<Assembly, IEnumerable<Type>> <>9__86_0; // 0x8

	// Methods

	// RVA: 0x11E8210 Offset: 0x11E6810 VA: 0x1811E8210
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11E80A0 Offset: 0x11E66A0 VA: 0x1811E80A0
	internal IEnumerable<Type> <GetAllAssemblyTypes>b__86_0(Assembly t) { }

}

