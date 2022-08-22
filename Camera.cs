public sealed class Camera : Behaviour // TypeDefIndex: 3360
{	// Fields
	public static Camera.CameraCallback onPreCull; // 0x0
	public static Camera.CameraCallback onPreRender; // 0x8
	public static Camera.CameraCallback onPostRender; // 0x10

	// Properties
	[NativePropertyAttribute] // RVA: 0x77C70 Offset: 0x77070 VA: 0x180077C70
	public float nearClipPlane { get; set; }
	[NativePropertyAttribute] // RVA: 0x77E00 Offset: 0x77200 VA: 0x180077E00
	public float farClipPlane { get; set; }
	[NativePropertyAttribute] // RVA: 0x77F10 Offset: 0x77310 VA: 0x180077F10
	public float fieldOfView { get; set; }
	public RenderingPath renderingPath { set; }
	public RenderingPath actualRenderingPath { get; }
	public bool allowHDR { get; set; }
	public bool allowMSAA { get; set; }
	[NativePropertyAttribute] // RVA: 0x78110 Offset: 0x77510 VA: 0x180078110
	public bool forceIntoRenderTexture { set; }
	public float orthographicSize { get; set; }
	public bool orthographic { get; set; }
	public float depth { get; }
	public float aspect { get; set; }
	public int cullingMask { get; set; }
	public int eventMask { get; }
	public CameraType cameraType { get; }
	public float[] layerCullDistances { get; set; }
	public Color backgroundColor { get; set; }
	public CameraClearFlags clearFlags { get; set; }
	public DepthTextureMode depthTextureMode { get; set; }
	public bool usePhysicalProperties { get; set; }
	public Vector2 sensorSize { get; set; }
	public float focalLength { get; set; }
	[NativePropertyAttribute] // RVA: 0x78220 Offset: 0x77620 VA: 0x180078220
	public Rect rect { get; set; }
	[NativePropertyAttribute] // RVA: 0x78350 Offset: 0x77750 VA: 0x180078350
	public Rect pixelRect { get; set; }
	public int pixelWidth { get; }
	public int pixelHeight { get; }
	public RenderTexture targetTexture { get; set; }
	public int targetDisplay { get; }
	public Matrix4x4 worldToCameraMatrix { get; }
	public Matrix4x4 projectionMatrix { get; set; }
	public Matrix4x4 nonJitteredProjectionMatrix { get; set; }
	[NativePropertyAttribute] // RVA: 0x784B0 Offset: 0x778B0 VA: 0x1800784B0
	public bool useJitteredProjectionMatrixForTransparentRendering { set; }
	public static Camera main { get; }
	public static Camera current { get; }
	public bool stereoEnabled { get; }
	public StereoTargetEyeMask stereoTargetEye { get; }
	public Camera.MonoOrStereoscopicEye stereoActiveEye { get; }
	public static int allCamerasCount { get; }

	// Methods

	// RVA: 0x1822B20 Offset: 0x1821120 VA: 0x181822B20
	public float get_nearClipPlane() { }

	// RVA: 0x1823600 Offset: 0x1821C00 VA: 0x181823600
	public void set_nearClipPlane(float value) { }

	// RVA: 0x1822A30 Offset: 0x1821030 VA: 0x181822A30
	public float get_farClipPlane() { }

	// RVA: 0x1823420 Offset: 0x1821A20 VA: 0x181823420
	public void set_farClipPlane(float value) { }

	// RVA: 0x1822A70 Offset: 0x1821070 VA: 0x181822A70
	public float get_fieldOfView() { }

	// RVA: 0x1823470 Offset: 0x1821A70 VA: 0x181823470
	public void set_fieldOfView(float value) { }

	// RVA: 0x1823970 Offset: 0x1821F70 VA: 0x181823970
	public void set_renderingPath(RenderingPath value) { }

	[NativeNameAttribute] // RVA: 0x76210 Offset: 0x75610 VA: 0x180076210
	// RVA: 0x18226E0 Offset: 0x1820CE0 VA: 0x1818226E0
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x1822720 Offset: 0x1820D20 VA: 0x181822720
	public bool get_allowHDR() { }

	// RVA: 0x18231D0 Offset: 0x18217D0 VA: 0x1818231D0
	public void set_allowHDR(bool value) { }

	// RVA: 0x1822760 Offset: 0x1820D60 VA: 0x181822760
	public bool get_allowMSAA() { }

	// RVA: 0x1823220 Offset: 0x1821820 VA: 0x181823220
	public void set_allowMSAA(bool value) { }

	// RVA: 0x1823510 Offset: 0x1821B10 VA: 0x181823510
	public void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x1822C10 Offset: 0x1821210 VA: 0x181822C10
	public float get_orthographicSize() { }

	// RVA: 0x18236F0 Offset: 0x1821CF0 VA: 0x1818236F0
	public void set_orthographicSize(float value) { }

	// RVA: 0x1822C50 Offset: 0x1821250 VA: 0x181822C50
	public bool get_orthographic() { }

	// RVA: 0x1823740 Offset: 0x1821D40 VA: 0x181823740
	public void set_orthographic(bool value) { }

	// RVA: 0x18229B0 Offset: 0x1820FB0 VA: 0x1818229B0
	public float get_depth() { }

	// RVA: 0x18227A0 Offset: 0x1820DA0 VA: 0x1818227A0
	public float get_aspect() { }

	// RVA: 0x1823270 Offset: 0x1821870 VA: 0x181823270
	public void set_aspect(float value) { }

	// RVA: 0x1822900 Offset: 0x1820F00 VA: 0x181822900
	public int get_cullingMask() { }

	// RVA: 0x18233A0 Offset: 0x18219A0 VA: 0x1818233A0
	public void set_cullingMask(int value) { }

	// RVA: 0x18229F0 Offset: 0x1820FF0 VA: 0x1818229F0
	public int get_eventMask() { }

	// RVA: 0x1822880 Offset: 0x1820E80 VA: 0x181822880
	public CameraType get_cameraType() { }

	[FreeFunctionAttribute] // RVA: 0x76300 Offset: 0x75700 VA: 0x180076300
	// RVA: 0x1821610 Offset: 0x181FC10 VA: 0x181821610
	private float[] GetLayerCullDistances() { }

	[FreeFunctionAttribute] // RVA: 0x76420 Offset: 0x75820 VA: 0x180076420
	// RVA: 0x1821F20 Offset: 0x1820520 VA: 0x181821F20
	private void SetLayerCullDistances(float[] d) { }

	// RVA: 0x1821610 Offset: 0x181FC10 VA: 0x181821610
	public float[] get_layerCullDistances() { }

	// RVA: 0x1823560 Offset: 0x1821B60 VA: 0x181823560
	public void set_layerCullDistances(float[] value) { }

	// RVA: 0x1822830 Offset: 0x1820E30 VA: 0x181822830
	public Color get_backgroundColor() { }

	// RVA: 0x1823310 Offset: 0x1821910 VA: 0x181823310
	public void set_backgroundColor(Color value) { }

	// RVA: 0x18228C0 Offset: 0x1820EC0 VA: 0x1818228C0
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x1823360 Offset: 0x1821960 VA: 0x181823360
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x1822970 Offset: 0x1820F70 VA: 0x181822970
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x18233E0 Offset: 0x18219E0 VA: 0x1818233E0
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x1821F70 Offset: 0x1820570 VA: 0x181821F70
	public void SetReplacementShader(Shader shader, string replacementTag) { }

	// RVA: 0x18230E0 Offset: 0x18216E0 VA: 0x1818230E0
	public bool get_usePhysicalProperties() { }

	// RVA: 0x1823AE0 Offset: 0x18220E0 VA: 0x181823AE0
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x1822F50 Offset: 0x1821550 VA: 0x181822F50
	public Vector2 get_sensorSize() { }

	// RVA: 0x1823A00 Offset: 0x1822000 VA: 0x181823A00
	public void set_sensorSize(Vector2 value) { }

	// RVA: 0x1822AB0 Offset: 0x18210B0 VA: 0x181822AB0
	public float get_focalLength() { }

	// RVA: 0x18234C0 Offset: 0x1821AC0 VA: 0x1818234C0
	public void set_focalLength(float value) { }

	// RVA: 0x1822EB0 Offset: 0x18214B0 VA: 0x181822EB0
	public Rect get_rect() { }

	// RVA: 0x1823920 Offset: 0x1821F20 VA: 0x181823920
	public void set_rect(Rect value) { }

	// RVA: 0x1822D20 Offset: 0x1821320 VA: 0x181822D20
	public Rect get_pixelRect() { }

	// RVA: 0x18237E0 Offset: 0x1821DE0 VA: 0x1818237E0
	public void set_pixelRect(Rect value) { }

	[FreeFunctionAttribute] // RVA: 0x76590 Offset: 0x75990 VA: 0x180076590
	// RVA: 0x1822D70 Offset: 0x1821370 VA: 0x181822D70
	public int get_pixelWidth() { }

	[FreeFunctionAttribute] // RVA: 0x76740 Offset: 0x75B40 VA: 0x180076740
	// RVA: 0x1822C90 Offset: 0x1821290 VA: 0x181822C90
	public int get_pixelHeight() { }

	// RVA: 0x18230A0 Offset: 0x18216A0 VA: 0x1818230A0
	public RenderTexture get_targetTexture() { }

	// RVA: 0x1823A40 Offset: 0x1822040 VA: 0x181823A40
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x1823060 Offset: 0x1821660 VA: 0x181823060
	public int get_targetDisplay() { }

	// RVA: 0x1823170 Offset: 0x1821770 VA: 0x181823170
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x1822E00 Offset: 0x1821400 VA: 0x181822E00
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x1823880 Offset: 0x1821E80 VA: 0x181823880
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x1822BB0 Offset: 0x18211B0 VA: 0x181822BB0
	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	// RVA: 0x18236A0 Offset: 0x1821CA0 VA: 0x1818236A0
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x1823A90 Offset: 0x1822090 VA: 0x181823A90
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x1821B10 Offset: 0x1820110 VA: 0x181821B10
	public void ResetProjectionMatrix() { }

	// RVA: 0x1822470 Offset: 0x1820A70 VA: 0x181822470
	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x18225E0 Offset: 0x1820BE0 VA: 0x1818225E0
	public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x18224E0 Offset: 0x1820AE0 VA: 0x1818224E0
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x1822650 Offset: 0x1820C50 VA: 0x181822650
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x1821EC0 Offset: 0x18204C0 VA: 0x181821EC0
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x18223A0 Offset: 0x18209A0 VA: 0x1818223A0
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	// RVA: 0x18221E0 Offset: 0x18207E0 VA: 0x1818221E0
	private Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x18220E0 Offset: 0x18206E0 VA: 0x1818220E0
	public Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1822250 Offset: 0x1820850 VA: 0x181822250
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x1821DF0 Offset: 0x18203F0 VA: 0x181821DF0
	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1821CF0 Offset: 0x18202F0 VA: 0x181821CF0
	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1821C00 Offset: 0x1820200 VA: 0x181821C00
	public Ray ScreenPointToRay(Vector3 pos) { }

	[FreeFunctionAttribute] // RVA: 0x76840 Offset: 0x75C40 VA: 0x180076840
	// RVA: 0x1821150 Offset: 0x181F750 VA: 0x181821150
	private void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x18211C0 Offset: 0x181F7C0 VA: 0x1818211C0
	public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[FreeFunctionAttribute] // RVA: 0x76A00 Offset: 0x75E00 VA: 0x180076A00
	// RVA: 0x1822AF0 Offset: 0x18210F0 VA: 0x181822AF0
	public static Camera get_main() { }

	[FreeFunctionAttribute] // RVA: 0x76AC0 Offset: 0x75EC0 VA: 0x180076AC0
	// RVA: 0x1822940 Offset: 0x1820F40 VA: 0x181822940
	public static Camera get_current() { }

	// RVA: 0x1822FE0 Offset: 0x18215E0 VA: 0x181822FE0
	public bool get_stereoEnabled() { }

	// RVA: 0x1823020 Offset: 0x1821620 VA: 0x181823020
	public StereoTargetEyeMask get_stereoTargetEye() { }

	[FreeFunctionAttribute] // RVA: 0x76C00 Offset: 0x76000 VA: 0x180076C00
	// RVA: 0x1822FA0 Offset: 0x18215A0 VA: 0x181822FA0
	public Camera.MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x18216A0 Offset: 0x181FCA0 VA: 0x1818216A0
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x1821820 Offset: 0x181FE20 VA: 0x181821820
	public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x1821330 Offset: 0x181F930 VA: 0x181821330
	public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye) { }

	// RVA: 0x1821760 Offset: 0x181FD60 VA: 0x181821760
	public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x1822020 Offset: 0x1820620 VA: 0x181822020
	public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x1821B50 Offset: 0x1820150 VA: 0x181821B50
	public void ResetStereoProjectionMatrices() { }

	[FreeFunctionAttribute] // RVA: 0x76E10 Offset: 0x76210 VA: 0x180076E10
	// RVA: 0x1821480 Offset: 0x181FA80 VA: 0x181821480
	private static int GetAllCamerasCount() { }

	[FreeFunctionAttribute] // RVA: 0x76F30 Offset: 0x76330 VA: 0x180076F30
	// RVA: 0x18214B0 Offset: 0x181FAB0 VA: 0x1818214B0
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x1821480 Offset: 0x181FA80 VA: 0x181821480
	public static int get_allCamerasCount() { }

	// RVA: 0x18214F0 Offset: 0x181FAF0 VA: 0x1818214F0
	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunctionAttribute] // RVA: 0x771F0 Offset: 0x765F0 VA: 0x1800771F0
	// RVA: 0x1821AD0 Offset: 0x18200D0 VA: 0x181821AD0
	public void Render() { }

	[FreeFunctionAttribute] // RVA: 0x772D0 Offset: 0x766D0 VA: 0x1800772D0
	// RVA: 0x1821A70 Offset: 0x1820070 VA: 0x181821A70
	public void RenderWithShader(Shader shader, string replacementTag) { }

	[FreeFunctionAttribute] // RVA: 0x77460 Offset: 0x76860 VA: 0x180077460
	// RVA: 0x18212E0 Offset: 0x181F8E0 VA: 0x1818212E0
	public void CopyFrom(Camera other) { }

	// RVA: 0x1821A30 Offset: 0x1820030 VA: 0x181821A30
	public void RemoveCommandBuffers(CameraEvent evt) { }

	// RVA: 0x1821890 Offset: 0x181FE90 VA: 0x181821890
	public void RemoveAllCommandBuffers() { }

	[NativeNameAttribute] // RVA: 0x77570 Offset: 0x76970 VA: 0x180077570
	// RVA: 0x1820F80 Offset: 0x181F580 VA: 0x181820F80
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[NativeNameAttribute] // RVA: 0x77730 Offset: 0x76B30 VA: 0x180077730
	// RVA: 0x18218D0 Offset: 0x181FED0 VA: 0x1818218D0
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x1820FD0 Offset: 0x181F5D0 VA: 0x181820FD0
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x1821920 Offset: 0x181FF20 VA: 0x181821920
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x77980 Offset: 0x76D80 VA: 0x180077980
	// RVA: 0x18215D0 Offset: 0x181FBD0 VA: 0x1818215D0
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18213D0 Offset: 0x181F9D0 VA: 0x1818213D0
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1821420 Offset: 0x181FA20 VA: 0x181821420
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1821370 Offset: 0x181F970 VA: 0x181821370
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x181FC60 Offset: 0x181E260 VA: 0x18181FC60
	public void .ctor() { }

	// RVA: 0x18227E0 Offset: 0x1820DE0 VA: 0x1818227E0
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x18232C0 Offset: 0x18218C0 VA: 0x1818232C0
	private void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x1822F00 Offset: 0x1821500 VA: 0x181822F00
	private void get_sensorSize_Injected(out Vector2 ret) { }

	// RVA: 0x18239B0 Offset: 0x1821FB0 VA: 0x1818239B0
	private void set_sensorSize_Injected(ref Vector2 value) { }

	// RVA: 0x1822E60 Offset: 0x1821460 VA: 0x181822E60
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x18238D0 Offset: 0x1821ED0 VA: 0x1818238D0
	private void set_rect_Injected(ref Rect value) { }

	// RVA: 0x1822CD0 Offset: 0x18212D0 VA: 0x181822CD0
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x1823790 Offset: 0x1821D90 VA: 0x181823790
	private void set_pixelRect_Injected(ref Rect value) { }

	// RVA: 0x1823120 Offset: 0x1821720 VA: 0x181823120
	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1822DB0 Offset: 0x18213B0 VA: 0x181822DB0
	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1823830 Offset: 0x1821E30 VA: 0x181823830
	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x1822B60 Offset: 0x1821160 VA: 0x181822B60
	private void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1823650 Offset: 0x1821C50 VA: 0x181823650
	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x1822400 Offset: 0x1820A00 VA: 0x181822400
	private void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x1822570 Offset: 0x1820B70 VA: 0x181822570
	private void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x1821E60 Offset: 0x1820460 VA: 0x181821E60
	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x1822340 Offset: 0x1820940 VA: 0x181822340
	private void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x1822070 Offset: 0x1820670 VA: 0x181822070
	private void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x1821B90 Offset: 0x1820190 VA: 0x181821B90
	private void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x18210E0 Offset: 0x181F6E0 VA: 0x1818210E0
	private void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x1821650 Offset: 0x181FC50 VA: 0x181821650
	private void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x18217D0 Offset: 0x181FDD0 VA: 0x1818217D0
	private void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x1821710 Offset: 0x181FD10 VA: 0x181821710
	private void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x1821FD0 Offset: 0x18205D0 VA: 0x181821FD0
	private void SetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, ref Matrix4x4 matrix) { }

}

public enum Camera.StereoscopicEye // TypeDefIndex: 3361
{	// Fields
	public int value__; // 0x0
	public const Camera.StereoscopicEye Left = 0;
	public const Camera.StereoscopicEye Right = 1;

}

public enum Camera.MonoOrStereoscopicEye // TypeDefIndex: 3362
{	// Fields
	public int value__; // 0x0
	public const Camera.MonoOrStereoscopicEye Left = 0;
	public const Camera.MonoOrStereoscopicEye Right = 1;
	public const Camera.MonoOrStereoscopicEye Mono = 2;

}

public sealed class Camera.CameraCallback : MulticastDelegate // TypeDefIndex: 3363
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x49A3B0 Offset: 0x4989B0 VA: 0x18049A3B0 Slot: 12
	public virtual void Invoke(Camera cam) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

