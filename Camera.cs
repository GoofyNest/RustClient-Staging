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

	// RVA: 0x1822860 Offset: 0x1820E60 VA: 0x181822860
	public float get_nearClipPlane() { }

	// RVA: 0x1823340 Offset: 0x1821940 VA: 0x181823340
	public void set_nearClipPlane(float value) { }

	// RVA: 0x1822770 Offset: 0x1820D70 VA: 0x181822770
	public float get_farClipPlane() { }

	// RVA: 0x1823160 Offset: 0x1821760 VA: 0x181823160
	public void set_farClipPlane(float value) { }

	// RVA: 0x18227B0 Offset: 0x1820DB0 VA: 0x1818227B0
	public float get_fieldOfView() { }

	// RVA: 0x18231B0 Offset: 0x18217B0 VA: 0x1818231B0
	public void set_fieldOfView(float value) { }

	// RVA: 0x18236B0 Offset: 0x1821CB0 VA: 0x1818236B0
	public void set_renderingPath(RenderingPath value) { }

	[NativeNameAttribute] // RVA: 0x76210 Offset: 0x75610 VA: 0x180076210
	// RVA: 0x1822420 Offset: 0x1820A20 VA: 0x181822420
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x1822460 Offset: 0x1820A60 VA: 0x181822460
	public bool get_allowHDR() { }

	// RVA: 0x1822F10 Offset: 0x1821510 VA: 0x181822F10
	public void set_allowHDR(bool value) { }

	// RVA: 0x18224A0 Offset: 0x1820AA0 VA: 0x1818224A0
	public bool get_allowMSAA() { }

	// RVA: 0x1822F60 Offset: 0x1821560 VA: 0x181822F60
	public void set_allowMSAA(bool value) { }

	// RVA: 0x1823250 Offset: 0x1821850 VA: 0x181823250
	public void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x1822950 Offset: 0x1820F50 VA: 0x181822950
	public float get_orthographicSize() { }

	// RVA: 0x1823430 Offset: 0x1821A30 VA: 0x181823430
	public void set_orthographicSize(float value) { }

	// RVA: 0x1822990 Offset: 0x1820F90 VA: 0x181822990
	public bool get_orthographic() { }

	// RVA: 0x1823480 Offset: 0x1821A80 VA: 0x181823480
	public void set_orthographic(bool value) { }

	// RVA: 0x18226F0 Offset: 0x1820CF0 VA: 0x1818226F0
	public float get_depth() { }

	// RVA: 0x18224E0 Offset: 0x1820AE0 VA: 0x1818224E0
	public float get_aspect() { }

	// RVA: 0x1822FB0 Offset: 0x18215B0 VA: 0x181822FB0
	public void set_aspect(float value) { }

	// RVA: 0x1822640 Offset: 0x1820C40 VA: 0x181822640
	public int get_cullingMask() { }

	// RVA: 0x18230E0 Offset: 0x18216E0 VA: 0x1818230E0
	public void set_cullingMask(int value) { }

	// RVA: 0x1822730 Offset: 0x1820D30 VA: 0x181822730
	public int get_eventMask() { }

	// RVA: 0x18225C0 Offset: 0x1820BC0 VA: 0x1818225C0
	public CameraType get_cameraType() { }

	[FreeFunctionAttribute] // RVA: 0x76300 Offset: 0x75700 VA: 0x180076300
	// RVA: 0x1821350 Offset: 0x181F950 VA: 0x181821350
	private float[] GetLayerCullDistances() { }

	[FreeFunctionAttribute] // RVA: 0x76420 Offset: 0x75820 VA: 0x180076420
	// RVA: 0x1821C60 Offset: 0x1820260 VA: 0x181821C60
	private void SetLayerCullDistances(float[] d) { }

	// RVA: 0x1821350 Offset: 0x181F950 VA: 0x181821350
	public float[] get_layerCullDistances() { }

	// RVA: 0x18232A0 Offset: 0x18218A0 VA: 0x1818232A0
	public void set_layerCullDistances(float[] value) { }

	// RVA: 0x1822570 Offset: 0x1820B70 VA: 0x181822570
	public Color get_backgroundColor() { }

	// RVA: 0x1823050 Offset: 0x1821650 VA: 0x181823050
	public void set_backgroundColor(Color value) { }

	// RVA: 0x1822600 Offset: 0x1820C00 VA: 0x181822600
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x18230A0 Offset: 0x18216A0 VA: 0x1818230A0
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x18226B0 Offset: 0x1820CB0 VA: 0x1818226B0
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x1823120 Offset: 0x1821720 VA: 0x181823120
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x1821CB0 Offset: 0x18202B0 VA: 0x181821CB0
	public void SetReplacementShader(Shader shader, string replacementTag) { }

	// RVA: 0x1822E20 Offset: 0x1821420 VA: 0x181822E20
	public bool get_usePhysicalProperties() { }

	// RVA: 0x1823820 Offset: 0x1821E20 VA: 0x181823820
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x1822C90 Offset: 0x1821290 VA: 0x181822C90
	public Vector2 get_sensorSize() { }

	// RVA: 0x1823740 Offset: 0x1821D40 VA: 0x181823740
	public void set_sensorSize(Vector2 value) { }

	// RVA: 0x18227F0 Offset: 0x1820DF0 VA: 0x1818227F0
	public float get_focalLength() { }

	// RVA: 0x1823200 Offset: 0x1821800 VA: 0x181823200
	public void set_focalLength(float value) { }

	// RVA: 0x1822BF0 Offset: 0x18211F0 VA: 0x181822BF0
	public Rect get_rect() { }

	// RVA: 0x1823660 Offset: 0x1821C60 VA: 0x181823660
	public void set_rect(Rect value) { }

	// RVA: 0x1822A60 Offset: 0x1821060 VA: 0x181822A60
	public Rect get_pixelRect() { }

	// RVA: 0x1823520 Offset: 0x1821B20 VA: 0x181823520
	public void set_pixelRect(Rect value) { }

	[FreeFunctionAttribute] // RVA: 0x76590 Offset: 0x75990 VA: 0x180076590
	// RVA: 0x1822AB0 Offset: 0x18210B0 VA: 0x181822AB0
	public int get_pixelWidth() { }

	[FreeFunctionAttribute] // RVA: 0x76740 Offset: 0x75B40 VA: 0x180076740
	// RVA: 0x18229D0 Offset: 0x1820FD0 VA: 0x1818229D0
	public int get_pixelHeight() { }

	// RVA: 0x1822DE0 Offset: 0x18213E0 VA: 0x181822DE0
	public RenderTexture get_targetTexture() { }

	// RVA: 0x1823780 Offset: 0x1821D80 VA: 0x181823780
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x1822DA0 Offset: 0x18213A0 VA: 0x181822DA0
	public int get_targetDisplay() { }

	// RVA: 0x1822EB0 Offset: 0x18214B0 VA: 0x181822EB0
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x1822B40 Offset: 0x1821140 VA: 0x181822B40
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x18235C0 Offset: 0x1821BC0 VA: 0x1818235C0
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x18228F0 Offset: 0x1820EF0 VA: 0x1818228F0
	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	// RVA: 0x18233E0 Offset: 0x18219E0 VA: 0x1818233E0
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x18237D0 Offset: 0x1821DD0 VA: 0x1818237D0
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x1821850 Offset: 0x181FE50 VA: 0x181821850
	public void ResetProjectionMatrix() { }

	// RVA: 0x18221B0 Offset: 0x18207B0 VA: 0x1818221B0
	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1822320 Offset: 0x1820920 VA: 0x181822320
	public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1822220 Offset: 0x1820820 VA: 0x181822220
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x1822390 Offset: 0x1820990 VA: 0x181822390
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x1821C00 Offset: 0x1820200 VA: 0x181821C00
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x18220E0 Offset: 0x18206E0 VA: 0x1818220E0
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	// RVA: 0x1821F20 Offset: 0x1820520 VA: 0x181821F20
	private Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1821E20 Offset: 0x1820420 VA: 0x181821E20
	public Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1821F90 Offset: 0x1820590 VA: 0x181821F90
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x1821B30 Offset: 0x1820130 VA: 0x181821B30
	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1821A30 Offset: 0x1820030 VA: 0x181821A30
	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1821940 Offset: 0x181FF40 VA: 0x181821940
	public Ray ScreenPointToRay(Vector3 pos) { }

	[FreeFunctionAttribute] // RVA: 0x76840 Offset: 0x75C40 VA: 0x180076840
	// RVA: 0x1820E90 Offset: 0x181F490 VA: 0x181820E90
	private void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x1820F00 Offset: 0x181F500 VA: 0x181820F00
	public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[FreeFunctionAttribute] // RVA: 0x76A00 Offset: 0x75E00 VA: 0x180076A00
	// RVA: 0x1822830 Offset: 0x1820E30 VA: 0x181822830
	public static Camera get_main() { }

	[FreeFunctionAttribute] // RVA: 0x76AC0 Offset: 0x75EC0 VA: 0x180076AC0
	// RVA: 0x1822680 Offset: 0x1820C80 VA: 0x181822680
	public static Camera get_current() { }

	// RVA: 0x1822D20 Offset: 0x1821320 VA: 0x181822D20
	public bool get_stereoEnabled() { }

	// RVA: 0x1822D60 Offset: 0x1821360 VA: 0x181822D60
	public StereoTargetEyeMask get_stereoTargetEye() { }

	[FreeFunctionAttribute] // RVA: 0x76C00 Offset: 0x76000 VA: 0x180076C00
	// RVA: 0x1822CE0 Offset: 0x18212E0 VA: 0x181822CE0
	public Camera.MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x18213E0 Offset: 0x181F9E0 VA: 0x1818213E0
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x1821560 Offset: 0x181FB60 VA: 0x181821560
	public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x1821070 Offset: 0x181F670 VA: 0x181821070
	public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye) { }

	// RVA: 0x18214A0 Offset: 0x181FAA0 VA: 0x1818214A0
	public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x1821D60 Offset: 0x1820360 VA: 0x181821D60
	public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x1821890 Offset: 0x181FE90 VA: 0x181821890
	public void ResetStereoProjectionMatrices() { }

	[FreeFunctionAttribute] // RVA: 0x76E10 Offset: 0x76210 VA: 0x180076E10
	// RVA: 0x18211C0 Offset: 0x181F7C0 VA: 0x1818211C0
	private static int GetAllCamerasCount() { }

	[FreeFunctionAttribute] // RVA: 0x76F30 Offset: 0x76330 VA: 0x180076F30
	// RVA: 0x18211F0 Offset: 0x181F7F0 VA: 0x1818211F0
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x18211C0 Offset: 0x181F7C0 VA: 0x1818211C0
	public static int get_allCamerasCount() { }

	// RVA: 0x1821230 Offset: 0x181F830 VA: 0x181821230
	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunctionAttribute] // RVA: 0x771F0 Offset: 0x765F0 VA: 0x1800771F0
	// RVA: 0x1821810 Offset: 0x181FE10 VA: 0x181821810
	public void Render() { }

	[FreeFunctionAttribute] // RVA: 0x772D0 Offset: 0x766D0 VA: 0x1800772D0
	// RVA: 0x18217B0 Offset: 0x181FDB0 VA: 0x1818217B0
	public void RenderWithShader(Shader shader, string replacementTag) { }

	[FreeFunctionAttribute] // RVA: 0x77460 Offset: 0x76860 VA: 0x180077460
	// RVA: 0x1821020 Offset: 0x181F620 VA: 0x181821020
	public void CopyFrom(Camera other) { }

	// RVA: 0x1821770 Offset: 0x181FD70 VA: 0x181821770
	public void RemoveCommandBuffers(CameraEvent evt) { }

	// RVA: 0x18215D0 Offset: 0x181FBD0 VA: 0x1818215D0
	public void RemoveAllCommandBuffers() { }

	[NativeNameAttribute] // RVA: 0x77570 Offset: 0x76970 VA: 0x180077570
	// RVA: 0x1820CC0 Offset: 0x181F2C0 VA: 0x181820CC0
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[NativeNameAttribute] // RVA: 0x77730 Offset: 0x76B30 VA: 0x180077730
	// RVA: 0x1821610 Offset: 0x181FC10 VA: 0x181821610
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x1820D10 Offset: 0x181F310 VA: 0x181820D10
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x1821660 Offset: 0x181FC60 VA: 0x181821660
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x77980 Offset: 0x76D80 VA: 0x180077980
	// RVA: 0x1821310 Offset: 0x181F910 VA: 0x181821310
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1821110 Offset: 0x181F710 VA: 0x181821110
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1821160 Offset: 0x181F760 VA: 0x181821160
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18210B0 Offset: 0x181F6B0 VA: 0x1818210B0
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x181F9A0 Offset: 0x181DFA0 VA: 0x18181F9A0
	public void .ctor() { }

	// RVA: 0x1822520 Offset: 0x1820B20 VA: 0x181822520
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x1823000 Offset: 0x1821600 VA: 0x181823000
	private void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x1822C40 Offset: 0x1821240 VA: 0x181822C40
	private void get_sensorSize_Injected(out Vector2 ret) { }

	// RVA: 0x18236F0 Offset: 0x1821CF0 VA: 0x1818236F0
	private void set_sensorSize_Injected(ref Vector2 value) { }

	// RVA: 0x1822BA0 Offset: 0x18211A0 VA: 0x181822BA0
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x1823610 Offset: 0x1821C10 VA: 0x181823610
	private void set_rect_Injected(ref Rect value) { }

	// RVA: 0x1822A10 Offset: 0x1821010 VA: 0x181822A10
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x18234D0 Offset: 0x1821AD0 VA: 0x1818234D0
	private void set_pixelRect_Injected(ref Rect value) { }

	// RVA: 0x1822E60 Offset: 0x1821460 VA: 0x181822E60
	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1822AF0 Offset: 0x18210F0 VA: 0x181822AF0
	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1823570 Offset: 0x1821B70 VA: 0x181823570
	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x18228A0 Offset: 0x1820EA0 VA: 0x1818228A0
	private void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1823390 Offset: 0x1821990 VA: 0x181823390
	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x1822140 Offset: 0x1820740 VA: 0x181822140
	private void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x18222B0 Offset: 0x18208B0 VA: 0x1818222B0
	private void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x1821BA0 Offset: 0x18201A0 VA: 0x181821BA0
	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x1822080 Offset: 0x1820680 VA: 0x181822080
	private void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x1821DB0 Offset: 0x18203B0 VA: 0x181821DB0
	private void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x18218D0 Offset: 0x181FED0 VA: 0x1818218D0
	private void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x1820E20 Offset: 0x181F420 VA: 0x181820E20
	private void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x1821390 Offset: 0x181F990 VA: 0x181821390
	private void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x1821510 Offset: 0x181FB10 VA: 0x181821510
	private void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x1821450 Offset: 0x181FA50 VA: 0x181821450
	private void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x1821D10 Offset: 0x1820310 VA: 0x181821D10
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

