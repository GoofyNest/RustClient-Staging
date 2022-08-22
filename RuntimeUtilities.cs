public static class RuntimeUtilities // TypeDefIndex: 11867
{	private static Texture2D m_WhiteTexture; // 0x0
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


	public static Texture2D get_whiteTexture() { }

	public static Texture3D get_whiteTexture3D() { }

	public static Texture2D get_blackTexture() { }

	public static Texture3D get_blackTexture3D() { }

	public static Texture2D get_transparentTexture() { }

	public static Texture3D get_transparentTexture3D() { }

	public static Texture2D GetLutStrip(int size) { }

	public static Mesh get_fullscreenTriangle() { }

	public static Material get_copyStdMaterial() { }

	public static Material get_copyStdFromDoubleWideMaterial() { }

	public static Material get_copyMaterial() { }

	public static Material get_copyFromTexArrayMaterial() { }

	public static PropertySheet get_copySheet() { }

	public static PropertySheet get_copyFromTexArraySheet() { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BlitFullscreenTriangleFromDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BlitFullscreenTriangleToDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BlitFullscreenTriangleFromTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BlitFullscreenTriangleToTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0) { }

	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	public static bool get_scriptableRenderPipelineActive() { }

	public static bool get_supportsDeferredShading() { }

	public static bool get_supportsDepthNormals() { }

	public static bool get_isSinglePassStereoEnabled() { }

	public static bool get_isVREnabled() { }

	public static bool get_isAndroidOpenGL() { }

	public static RenderTextureFormat get_defaultHDRRenderTextureFormat() { }

	public static bool isFloatingPointFormat(RenderTextureFormat format) { }

	public static void Destroy(Object obj) { }

	public static bool get_isLinearColorSpace() { }

	public static bool IsResolvedDepthAvailable(Camera camera) { }

	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects) { }

	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = False) { }

	public static bool IsPostProcessingActive(PostProcessLayer layer) { }

	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer) { }

	[IteratorStateMachineAttribute] // RVA: 0x7FE40 Offset: 0x7F240 VA: 0x18007FE40
	public static IEnumerable<T> GetAllSceneObjects<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD03990 Offset: 0xD01F90 VA: 0x180D03990
	|-RuntimeUtilities.GetAllSceneObjects<object>
	*/

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

	public static float Exp2(float x) { }

	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset) { }

	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset) { }

	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter) { }

	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15B9DC0 Offset: 0x15B83C0 VA: 0x1815B9DC0
	|-RuntimeUtilities.GetAttribute<object>
	|-RuntimeUtilities.GetAttribute<PostProcessAttribute>
	*/

	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125F6D0 Offset: 0x125DCD0 VA: 0x18125F6D0
	|-RuntimeUtilities.GetMemberAttributes<object, object>
	*/

	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED8F50 Offset: 0xED7550 VA: 0x180ED8F50
	|-RuntimeUtilities.GetFieldPath<object, object>
	*/

	private static void .cctor() { }

}

private sealed class RuntimeUtilities.<GetAllSceneObjects>d__79<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 11868
{	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private Queue<Transform> <queue>5__2; // 0x0
	private GameObject[] <>7__wrap2; // 0x0
	private int <>7__wrap3; // 0x0
	private IEnumerator <>7__wrap4; // 0x0

	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144ABD0 Offset: 0x14491D0 VA: 0x18144ABD0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B45C0 Offset: 0x19B2BC0 VA: 0x1819B45C0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.IDisposable.Dispose
	*/

	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B40D0 Offset: 0x19B26D0 VA: 0x1819B40D0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.MoveNext
	*/

	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4640 Offset: 0x19B2C40 VA: 0x1819B4640
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.<>m__Finally1
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4570 Offset: 0x19B2B70 VA: 0x1819B4570
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B44A0 Offset: 0x19B2AA0 VA: 0x1819B44A0
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x19B4540 Offset: 0x19B2B40 VA: 0x1819B4540
	|-RuntimeUtilities.<GetAllSceneObjects>d__79<object>.System.Collections.IEnumerable.GetEnumerator
	*/

}

private sealed class RuntimeUtilities.<>c // TypeDefIndex: 11869
{	public static readonly RuntimeUtilities.<>c <>9; // 0x0
	public static Func<Assembly, IEnumerable<Type>> <>9__86_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal IEnumerable<Type> <GetAllAssemblyTypes>b__86_0(Assembly t) { }

}

