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

	// RVA: 0x11DB530 Offset: 0x11D9B30 VA: 0x1811DB530
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x11DB340 Offset: 0x11D9940 VA: 0x1811DB340
	public static Texture3D get_whiteTexture3D() { }

	// RVA: 0x11D9D00 Offset: 0x11D8300 VA: 0x1811D9D00
	public static Texture2D get_blackTexture() { }

	// RVA: 0x11D9B10 Offset: 0x11D8110 VA: 0x1811D9B10
	public static Texture3D get_blackTexture3D() { }

	// RVA: 0x11DB180 Offset: 0x11D9780 VA: 0x1811DB180
	public static Texture2D get_transparentTexture() { }

	// RVA: 0x11DAF90 Offset: 0x11D9590 VA: 0x1811DAF90
	public static Texture3D get_transparentTexture3D() { }

	// RVA: 0x11D93B0 Offset: 0x11D79B0 VA: 0x1811D93B0
	public static Texture2D GetLutStrip(int size) { }

	// RVA: 0x11DAA00 Offset: 0x11D9000 VA: 0x1811DAA00
	public static Mesh get_fullscreenTriangle() { }

	// RVA: 0x11DA820 Offset: 0x11D8E20 VA: 0x1811DA820
	public static Material get_copyStdMaterial() { }

	// RVA: 0x11DA640 Offset: 0x11D8C40 VA: 0x1811DA640
	public static Material get_copyStdFromDoubleWideMaterial() { }

	// RVA: 0x11DA350 Offset: 0x11D8950 VA: 0x1811DA350
	public static Material get_copyMaterial() { }

	// RVA: 0x11D9EC0 Offset: 0x11D84C0 VA: 0x1811D9EC0
	public static Material get_copyFromTexArrayMaterial() { }

	// RVA: 0x11DA530 Offset: 0x11D8B30 VA: 0x1811DA530
	public static PropertySheet get_copySheet() { }

	// RVA: 0x11DA0A0 Offset: 0x11D86A0 VA: 0x1811DA0A0
	public static PropertySheet get_copyFromTexArraySheet() { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D9A50 Offset: 0x11D8050 VA: 0x1811D9A50
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D99C0 Offset: 0x11D7FC0 VA: 0x1811D99C0
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D8050 Offset: 0x11D6650 VA: 0x1811D8050
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7DE0 Offset: 0x11D63E0 VA: 0x1811D7DE0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D79B0 Offset: 0x11D5FB0 VA: 0x1811D79B0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7140 Offset: 0x11D5740 VA: 0x1811D7140
	public static void BlitFullscreenTriangleFromDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7550 Offset: 0x11D5B50 VA: 0x1811D7550
	public static void BlitFullscreenTriangleToDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7320 Offset: 0x11D5920 VA: 0x1811D7320
	public static void BlitFullscreenTriangleFromTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7790 Offset: 0x11D5D90 VA: 0x1811D7790
	public static void BlitFullscreenTriangleToTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D7AE0 Offset: 0x11D60E0 VA: 0x1811D7AE0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D82F0 Offset: 0x11D68F0 VA: 0x1811D82F0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D8610 Offset: 0x11D6C10 VA: 0x1811D8610
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x11D8510 Offset: 0x11D6B10 VA: 0x1811D8510
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0) { }

	// RVA: 0x11D86F0 Offset: 0x11D6CF0 VA: 0x1811D86F0
	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	// RVA: 0x11DADD0 Offset: 0x11D93D0 VA: 0x1811DADD0
	public static bool get_scriptableRenderPipelineActive() { }

	// RVA: 0x11DAE30 Offset: 0x11D9430 VA: 0x1811DAE30
	public static bool get_supportsDeferredShading() { }

	// RVA: 0x11DAEE0 Offset: 0x11D94E0 VA: 0x1811DAEE0
	public static bool get_supportsDepthNormals() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public static bool get_isSinglePassStereoEnabled() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public static bool get_isVREnabled() { }

	// RVA: 0x11DAD80 Offset: 0x11D9380 VA: 0x1811DAD80
	public static bool get_isAndroidOpenGL() { }

	// RVA: 0xE668B0 Offset: 0xE64EB0 VA: 0x180E668B0
	public static RenderTextureFormat get_defaultHDRRenderTextureFormat() { }

	// RVA: 0x11DB6E0 Offset: 0x11D9CE0 VA: 0x1811DB6E0
	public static bool isFloatingPointFormat(RenderTextureFormat format) { }

	// RVA: 0x11D8B20 Offset: 0x11D7120 VA: 0x1811D8B20
	public static void Destroy(Object obj) { }

	// RVA: 0x11DADB0 Offset: 0x11D93B0 VA: 0x1811DADB0
	public static bool get_isLinearColorSpace() { }

	// RVA: 0x11D9860 Offset: 0x11D7E60 VA: 0x1811D9860
	public static bool IsResolvedDepthAvailable(Camera camera) { }

	// RVA: 0x11D8860 Offset: 0x11D6E60 VA: 0x1811D8860
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects) { }

	// RVA: 0x11D89D0 Offset: 0x11D6FD0 VA: 0x1811D89D0
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = False) { }

	// RVA: 0x11D97E0 Offset: 0x11D7DE0 VA: 0x1811D97E0
	public static bool IsPostProcessingActive(PostProcessLayer layer) { }

	// RVA: 0x11D98D0 Offset: 0x11D7ED0 VA: 0x1811D98D0
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer) { }

	[IteratorStateMachineAttribute] // RVA: 0x7FE40 Offset: 0x7F240 VA: 0x18007FE40
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetAllSceneObjects<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD034F0 Offset: 0xD01AF0 VA: 0x180D034F0
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

	// RVA: 0x11D8BB0 Offset: 0x11D71B0 VA: 0x1811D8BB0
	public static float Exp2(float x) { }

	// RVA: 0x11D91B0 Offset: 0x11D77B0 VA: 0x1811D91B0
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset) { }

	// RVA: 0x11D8FC0 Offset: 0x11D75C0 VA: 0x1811D8FC0
	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset) { }

	// RVA: 0x11D8C10 Offset: 0x11D7210 VA: 0x1811D8C10
	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter) { }

	// RVA: 0x11D8DF0 Offset: 0x11D73F0 VA: 0x1811D8DF0
	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15BACF0 Offset: 0x15B92F0 VA: 0x1815BACF0
	|-RuntimeUtilities.GetAttribute<object>
	|-RuntimeUtilities.GetAttribute<PostProcessAttribute>
	*/

	// RVA: -1 Offset: -1
	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F030 Offset: 0x125D630 VA: 0x18125F030
	|-RuntimeUtilities.GetMemberAttributes<object, object>
	*/

	// RVA: -1 Offset: -1
	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED84A0 Offset: 0xED6AA0 VA: 0x180ED84A0
	|-RuntimeUtilities.GetFieldPath<object, object>
	*/

	// RVA: 0x11D9AA0 Offset: 0x11D80A0 VA: 0x1811D9AA0
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
	|-RVA: 0x144BB00 Offset: 0x144A100 VA: 0x18144BB00
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C71C0 Offset: 0x19C57C0 VA: 0x1819C71C0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C6CD0 Offset: 0x19C52D0 VA: 0x1819C6CD0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C7240 Offset: 0x19C5840 VA: 0x1819C7240
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
	|-RVA: 0x19C7170 Offset: 0x19C5770 VA: 0x1819C7170
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
	|-RVA: 0x19C70A0 Offset: 0x19C56A0 VA: 0x1819C70A0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19C7140 Offset: 0x19C5740 VA: 0x1819C7140
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class RuntimeUtilities.<>c // TypeDefIndex: 11869
{	// Fields
	public static readonly RuntimeUtilities.<>c <>9; // 0x0
	public static Func<Assembly, IEnumerable<Type>> <>9__86_0; // 0x8

	// Methods

	// RVA: 0x11E7B70 Offset: 0x11E6170 VA: 0x1811E7B70
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x11E7A00 Offset: 0x11E6000 VA: 0x1811E7A00
	internal IEnumerable<Type> <GetAllAssemblyTypes>b__86_0(Assembly t) { }

}

