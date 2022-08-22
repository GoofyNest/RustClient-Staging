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

	// RVA: 0x180FF60 Offset: 0x180E560 VA: 0x18180FF60
	public float get_nearClipPlane() { }

	// RVA: 0x1810A40 Offset: 0x180F040 VA: 0x181810A40
	public void set_nearClipPlane(float value) { }

	// RVA: 0x180FE70 Offset: 0x180E470 VA: 0x18180FE70
	public float get_farClipPlane() { }

	// RVA: 0x1810860 Offset: 0x180EE60 VA: 0x181810860
	public void set_farClipPlane(float value) { }

	// RVA: 0x180FEB0 Offset: 0x180E4B0 VA: 0x18180FEB0
	public float get_fieldOfView() { }

	// RVA: 0x18108B0 Offset: 0x180EEB0 VA: 0x1818108B0
	public void set_fieldOfView(float value) { }

	// RVA: 0x1810DB0 Offset: 0x180F3B0 VA: 0x181810DB0
	public void set_renderingPath(RenderingPath value) { }

	[NativeNameAttribute] // RVA: 0x76210 Offset: 0x75610 VA: 0x180076210
	// RVA: 0x180FB20 Offset: 0x180E120 VA: 0x18180FB20
	public RenderingPath get_actualRenderingPath() { }

	// RVA: 0x180FB60 Offset: 0x180E160 VA: 0x18180FB60
	public bool get_allowHDR() { }

	// RVA: 0x1810610 Offset: 0x180EC10 VA: 0x181810610
	public void set_allowHDR(bool value) { }

	// RVA: 0x180FBA0 Offset: 0x180E1A0 VA: 0x18180FBA0
	public bool get_allowMSAA() { }

	// RVA: 0x1810660 Offset: 0x180EC60 VA: 0x181810660
	public void set_allowMSAA(bool value) { }

	// RVA: 0x1810950 Offset: 0x180EF50 VA: 0x181810950
	public void set_forceIntoRenderTexture(bool value) { }

	// RVA: 0x1810050 Offset: 0x180E650 VA: 0x181810050
	public float get_orthographicSize() { }

	// RVA: 0x1810B30 Offset: 0x180F130 VA: 0x181810B30
	public void set_orthographicSize(float value) { }

	// RVA: 0x1810090 Offset: 0x180E690 VA: 0x181810090
	public bool get_orthographic() { }

	// RVA: 0x1810B80 Offset: 0x180F180 VA: 0x181810B80
	public void set_orthographic(bool value) { }

	// RVA: 0x180FDF0 Offset: 0x180E3F0 VA: 0x18180FDF0
	public float get_depth() { }

	// RVA: 0x180FBE0 Offset: 0x180E1E0 VA: 0x18180FBE0
	public float get_aspect() { }

	// RVA: 0x18106B0 Offset: 0x180ECB0 VA: 0x1818106B0
	public void set_aspect(float value) { }

	// RVA: 0x180FD40 Offset: 0x180E340 VA: 0x18180FD40
	public int get_cullingMask() { }

	// RVA: 0x18107E0 Offset: 0x180EDE0 VA: 0x1818107E0
	public void set_cullingMask(int value) { }

	// RVA: 0x180FE30 Offset: 0x180E430 VA: 0x18180FE30
	public int get_eventMask() { }

	// RVA: 0x180FCC0 Offset: 0x180E2C0 VA: 0x18180FCC0
	public CameraType get_cameraType() { }

	[FreeFunctionAttribute] // RVA: 0x76300 Offset: 0x75700 VA: 0x180076300
	// RVA: 0x180EA50 Offset: 0x180D050 VA: 0x18180EA50
	private float[] GetLayerCullDistances() { }

	[FreeFunctionAttribute] // RVA: 0x76420 Offset: 0x75820 VA: 0x180076420
	// RVA: 0x180F360 Offset: 0x180D960 VA: 0x18180F360
	private void SetLayerCullDistances(float[] d) { }

	// RVA: 0x180EA50 Offset: 0x180D050 VA: 0x18180EA50
	public float[] get_layerCullDistances() { }

	// RVA: 0x18109A0 Offset: 0x180EFA0 VA: 0x1818109A0
	public void set_layerCullDistances(float[] value) { }

	// RVA: 0x180FC70 Offset: 0x180E270 VA: 0x18180FC70
	public Color get_backgroundColor() { }

	// RVA: 0x1810750 Offset: 0x180ED50 VA: 0x181810750
	public void set_backgroundColor(Color value) { }

	// RVA: 0x180FD00 Offset: 0x180E300 VA: 0x18180FD00
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x18107A0 Offset: 0x180EDA0 VA: 0x1818107A0
	public void set_clearFlags(CameraClearFlags value) { }

	// RVA: 0x180FDB0 Offset: 0x180E3B0 VA: 0x18180FDB0
	public DepthTextureMode get_depthTextureMode() { }

	// RVA: 0x1810820 Offset: 0x180EE20 VA: 0x181810820
	public void set_depthTextureMode(DepthTextureMode value) { }

	// RVA: 0x180F3B0 Offset: 0x180D9B0 VA: 0x18180F3B0
	public void SetReplacementShader(Shader shader, string replacementTag) { }

	// RVA: 0x1810520 Offset: 0x180EB20 VA: 0x181810520
	public bool get_usePhysicalProperties() { }

	// RVA: 0x1810F20 Offset: 0x180F520 VA: 0x181810F20
	public void set_usePhysicalProperties(bool value) { }

	// RVA: 0x1810390 Offset: 0x180E990 VA: 0x181810390
	public Vector2 get_sensorSize() { }

	// RVA: 0x1810E40 Offset: 0x180F440 VA: 0x181810E40
	public void set_sensorSize(Vector2 value) { }

	// RVA: 0x180FEF0 Offset: 0x180E4F0 VA: 0x18180FEF0
	public float get_focalLength() { }

	// RVA: 0x1810900 Offset: 0x180EF00 VA: 0x181810900
	public void set_focalLength(float value) { }

	// RVA: 0x18102F0 Offset: 0x180E8F0 VA: 0x1818102F0
	public Rect get_rect() { }

	// RVA: 0x1810D60 Offset: 0x180F360 VA: 0x181810D60
	public void set_rect(Rect value) { }

	// RVA: 0x1810160 Offset: 0x180E760 VA: 0x181810160
	public Rect get_pixelRect() { }

	// RVA: 0x1810C20 Offset: 0x180F220 VA: 0x181810C20
	public void set_pixelRect(Rect value) { }

	[FreeFunctionAttribute] // RVA: 0x76590 Offset: 0x75990 VA: 0x180076590
	// RVA: 0x18101B0 Offset: 0x180E7B0 VA: 0x1818101B0
	public int get_pixelWidth() { }

	[FreeFunctionAttribute] // RVA: 0x76740 Offset: 0x75B40 VA: 0x180076740
	// RVA: 0x18100D0 Offset: 0x180E6D0 VA: 0x1818100D0
	public int get_pixelHeight() { }

	// RVA: 0x18104E0 Offset: 0x180EAE0 VA: 0x1818104E0
	public RenderTexture get_targetTexture() { }

	// RVA: 0x1810E80 Offset: 0x180F480 VA: 0x181810E80
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x18104A0 Offset: 0x180EAA0 VA: 0x1818104A0
	public int get_targetDisplay() { }

	// RVA: 0x18105B0 Offset: 0x180EBB0 VA: 0x1818105B0
	public Matrix4x4 get_worldToCameraMatrix() { }

	// RVA: 0x1810240 Offset: 0x180E840 VA: 0x181810240
	public Matrix4x4 get_projectionMatrix() { }

	// RVA: 0x1810CC0 Offset: 0x180F2C0 VA: 0x181810CC0
	public void set_projectionMatrix(Matrix4x4 value) { }

	// RVA: 0x180FFF0 Offset: 0x180E5F0 VA: 0x18180FFF0
	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	// RVA: 0x1810AE0 Offset: 0x180F0E0 VA: 0x181810AE0
	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	// RVA: 0x1810ED0 Offset: 0x180F4D0 VA: 0x181810ED0
	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	// RVA: 0x180EF50 Offset: 0x180D550 VA: 0x18180EF50
	public void ResetProjectionMatrix() { }

	// RVA: 0x180F8B0 Offset: 0x180DEB0 VA: 0x18180F8B0
	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x180FA20 Offset: 0x180E020 VA: 0x18180FA20
	public Vector3 WorldToViewportPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x180F920 Offset: 0x180DF20 VA: 0x18180F920
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x180FA90 Offset: 0x180E090 VA: 0x18180FA90
	public Vector3 WorldToViewportPoint(Vector3 position) { }

	// RVA: 0x180F300 Offset: 0x180D900 VA: 0x18180F300
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x180F7E0 Offset: 0x180DDE0 VA: 0x18180F7E0
	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	// RVA: 0x180F620 Offset: 0x180DC20 VA: 0x18180F620
	private Ray ViewportPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x180F520 Offset: 0x180DB20 VA: 0x18180F520
	public Ray ViewportPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x180F690 Offset: 0x180DC90 VA: 0x18180F690
	public Ray ViewportPointToRay(Vector3 pos) { }

	// RVA: 0x180F230 Offset: 0x180D830 VA: 0x18180F230
	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x180F130 Offset: 0x180D730 VA: 0x18180F130
	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x180F040 Offset: 0x180D640 VA: 0x18180F040
	public Ray ScreenPointToRay(Vector3 pos) { }

	[FreeFunctionAttribute] // RVA: 0x76840 Offset: 0x75C40 VA: 0x180076840
	// RVA: 0x180E590 Offset: 0x180CB90 VA: 0x18180E590
	private void CalculateFrustumCornersInternal(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x180E600 Offset: 0x180CC00 VA: 0x18180E600
	public void CalculateFrustumCorners(Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[FreeFunctionAttribute] // RVA: 0x76A00 Offset: 0x75E00 VA: 0x180076A00
	// RVA: 0x180FF30 Offset: 0x180E530 VA: 0x18180FF30
	public static Camera get_main() { }

	[FreeFunctionAttribute] // RVA: 0x76AC0 Offset: 0x75EC0 VA: 0x180076AC0
	// RVA: 0x180FD80 Offset: 0x180E380 VA: 0x18180FD80
	public static Camera get_current() { }

	// RVA: 0x1810420 Offset: 0x180EA20 VA: 0x181810420
	public bool get_stereoEnabled() { }

	// RVA: 0x1810460 Offset: 0x180EA60 VA: 0x181810460
	public StereoTargetEyeMask get_stereoTargetEye() { }

	[FreeFunctionAttribute] // RVA: 0x76C00 Offset: 0x76000 VA: 0x180076C00
	// RVA: 0x18103E0 Offset: 0x180E9E0 VA: 0x1818103E0
	public Camera.MonoOrStereoscopicEye get_stereoActiveEye() { }

	// RVA: 0x180EAE0 Offset: 0x180D0E0 VA: 0x18180EAE0
	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x180EC60 Offset: 0x180D260 VA: 0x18180EC60
	public Matrix4x4 GetStereoViewMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x180E770 Offset: 0x180CD70 VA: 0x18180E770
	public void CopyStereoDeviceProjectionMatrixToNonJittered(Camera.StereoscopicEye eye) { }

	// RVA: 0x180EBA0 Offset: 0x180D1A0 VA: 0x18180EBA0
	public Matrix4x4 GetStereoProjectionMatrix(Camera.StereoscopicEye eye) { }

	// RVA: 0x180F460 Offset: 0x180DA60 VA: 0x18180F460
	public void SetStereoProjectionMatrix(Camera.StereoscopicEye eye, Matrix4x4 matrix) { }

	// RVA: 0x180EF90 Offset: 0x180D590 VA: 0x18180EF90
	public void ResetStereoProjectionMatrices() { }

	[FreeFunctionAttribute] // RVA: 0x76E10 Offset: 0x76210 VA: 0x180076E10
	// RVA: 0x180E8C0 Offset: 0x180CEC0 VA: 0x18180E8C0
	private static int GetAllCamerasCount() { }

	[FreeFunctionAttribute] // RVA: 0x76F30 Offset: 0x76330 VA: 0x180076F30
	// RVA: 0x180E8F0 Offset: 0x180CEF0 VA: 0x18180E8F0
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x180E8C0 Offset: 0x180CEC0 VA: 0x18180E8C0
	public static int get_allCamerasCount() { }

	// RVA: 0x180E930 Offset: 0x180CF30 VA: 0x18180E930
	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunctionAttribute] // RVA: 0x771F0 Offset: 0x765F0 VA: 0x1800771F0
	// RVA: 0x180EF10 Offset: 0x180D510 VA: 0x18180EF10
	public void Render() { }

	[FreeFunctionAttribute] // RVA: 0x772D0 Offset: 0x766D0 VA: 0x1800772D0
	// RVA: 0x180EEB0 Offset: 0x180D4B0 VA: 0x18180EEB0
	public void RenderWithShader(Shader shader, string replacementTag) { }

	[FreeFunctionAttribute] // RVA: 0x77460 Offset: 0x76860 VA: 0x180077460
	// RVA: 0x180E720 Offset: 0x180CD20 VA: 0x18180E720
	public void CopyFrom(Camera other) { }

	// RVA: 0x180EE70 Offset: 0x180D470 VA: 0x18180EE70
	public void RemoveCommandBuffers(CameraEvent evt) { }

	// RVA: 0x180ECD0 Offset: 0x180D2D0 VA: 0x18180ECD0
	public void RemoveAllCommandBuffers() { }

	[NativeNameAttribute] // RVA: 0x77570 Offset: 0x76970 VA: 0x180077570
	// RVA: 0x180E3C0 Offset: 0x180C9C0 VA: 0x18180E3C0
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	[NativeNameAttribute] // RVA: 0x77730 Offset: 0x76B30 VA: 0x180077730
	// RVA: 0x180ED10 Offset: 0x180D310 VA: 0x18180ED10
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x180E410 Offset: 0x180CA10 VA: 0x18180E410
	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	// RVA: 0x180ED60 Offset: 0x180D360 VA: 0x18180ED60
	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[FreeFunctionAttribute] // RVA: 0x77980 Offset: 0x76D80 VA: 0x180077980
	// RVA: 0x180EA10 Offset: 0x180D010 VA: 0x18180EA10
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180E810 Offset: 0x180CE10 VA: 0x18180E810
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180E860 Offset: 0x180CE60 VA: 0x18180E860
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x180E7B0 Offset: 0x180CDB0 VA: 0x18180E7B0
	private static void FireOnPostRender(Camera cam) { }

	// RVA: 0x180D0A0 Offset: 0x180B6A0 VA: 0x18180D0A0
	public void .ctor() { }

	// RVA: 0x180FC20 Offset: 0x180E220 VA: 0x18180FC20
	private void get_backgroundColor_Injected(out Color ret) { }

	// RVA: 0x1810700 Offset: 0x180ED00 VA: 0x181810700
	private void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x1810340 Offset: 0x180E940 VA: 0x181810340
	private void get_sensorSize_Injected(out Vector2 ret) { }

	// RVA: 0x1810DF0 Offset: 0x180F3F0 VA: 0x181810DF0
	private void set_sensorSize_Injected(ref Vector2 value) { }

	// RVA: 0x18102A0 Offset: 0x180E8A0 VA: 0x1818102A0
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x1810D10 Offset: 0x180F310 VA: 0x181810D10
	private void set_rect_Injected(ref Rect value) { }

	// RVA: 0x1810110 Offset: 0x180E710 VA: 0x181810110
	private void get_pixelRect_Injected(out Rect ret) { }

	// RVA: 0x1810BD0 Offset: 0x180F1D0 VA: 0x181810BD0
	private void set_pixelRect_Injected(ref Rect value) { }

	// RVA: 0x1810560 Offset: 0x180EB60 VA: 0x181810560
	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x18101F0 Offset: 0x180E7F0 VA: 0x1818101F0
	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1810C70 Offset: 0x180F270 VA: 0x181810C70
	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x180FFA0 Offset: 0x180E5A0 VA: 0x18180FFA0
	private void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1810A90 Offset: 0x180F090 VA: 0x181810A90
	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	// RVA: 0x180F840 Offset: 0x180DE40 VA: 0x18180F840
	private void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x180F9B0 Offset: 0x180DFB0 VA: 0x18180F9B0
	private void WorldToViewportPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x180F2A0 Offset: 0x180D8A0 VA: 0x18180F2A0
	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x180F780 Offset: 0x180DD80 VA: 0x18180F780
	private void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x180F4B0 Offset: 0x180DAB0 VA: 0x18180F4B0
	private void ViewportPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x180EFD0 Offset: 0x180D5D0 VA: 0x18180EFD0
	private void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x180E520 Offset: 0x180CB20 VA: 0x18180E520
	private void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, Camera.MonoOrStereoscopicEye eye, [Out] Vector3[] outCorners) { }

	// RVA: 0x180EA90 Offset: 0x180D090 VA: 0x18180EA90
	private void GetStereoNonJitteredProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x180EC10 Offset: 0x180D210 VA: 0x18180EC10
	private void GetStereoViewMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x180EB50 Offset: 0x180D150 VA: 0x18180EB50
	private void GetStereoProjectionMatrix_Injected(Camera.StereoscopicEye eye, out Matrix4x4 ret) { }

	// RVA: 0x180F410 Offset: 0x180DA10 VA: 0x18180F410
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

