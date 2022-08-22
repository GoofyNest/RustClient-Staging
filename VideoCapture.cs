public class VideoCapture : IDisposable // TypeDefIndex: 3616
{	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x21867C0 Offset: 0x2184DC0 VA: 0x1821867C0
	private static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2186360 Offset: 0x2184960 VA: 0x182186360
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x1829EC0 Offset: 0x18284C0 VA: 0x181829EC0
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21865E0 Offset: 0x2184BE0 VA: 0x1821865E0
	private static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21866D0 Offset: 0x2184CD0 VA: 0x1821866D0
	private static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2186400 Offset: 0x2184A00 VA: 0x182186400
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21864F0 Offset: 0x2184AF0 VA: 0x1821864F0
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult) { }

	// RVA: 0x21861F0 Offset: 0x21847F0 VA: 0x1821861F0 Slot: 4
	public void Dispose() { }

	[NativeConditionalAttribute] // RVA: 0xDDA50 Offset: 0xDCE50 VA: 0x1800DDA50
	[NativeMethodAttribute] // RVA: 0xDDA50 Offset: 0xDCE50 VA: 0x1800DDA50
	// RVA: 0x21861B0 Offset: 0x21847B0 VA: 0x1821861B0
	private void Dispose_Internal() { }

	// RVA: 0x2186280 Offset: 0x2184880 VA: 0x182186280 Slot: 1
	protected override void Finalize() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0xDDBA0 Offset: 0xDCFA0 VA: 0x1800DDBA0
	[NativeMethodAttribute] // RVA: 0xDDBA0 Offset: 0xDCFA0 VA: 0x1800DDBA0
	[NativeConditionalAttribute] // RVA: 0xDDBA0 Offset: 0xDCFA0 VA: 0x1800DDBA0
	// RVA: 0x2186170 Offset: 0x2184770 VA: 0x182186170
	private void DisposeThreaded_Internal() { }

	// RVA: 0x2186860 Offset: 0x2184E60 VA: 0x182186860
	private static void .cctor() { }

}

public enum VideoCapture.CaptureResultType // TypeDefIndex: 3617
{	// Fields
	public int value__; // 0x0
	public const VideoCapture.CaptureResultType Success = 0;
	public const VideoCapture.CaptureResultType UnknownError = 1;

}

public struct VideoCapture.VideoCaptureResult // TypeDefIndex: 3618
{	// Fields
	public VideoCapture.CaptureResultType resultType; // 0x0
	public long hResult; // 0x8

}

public sealed class VideoCapture.OnVideoCaptureResourceCreatedCallback : MulticastDelegate // TypeDefIndex: 3619
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x49A3B0 Offset: 0x4989B0 VA: 0x18049A3B0 Slot: 12
	public virtual void Invoke(VideoCapture captureObject) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture captureObject, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnVideoModeStartedCallback : MulticastDelegate // TypeDefIndex: 3620
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21780F0 Offset: 0x21766F0 VA: 0x1821780F0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x2178630 Offset: 0x2176C30 VA: 0x182178630 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnVideoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3621
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21780F0 Offset: 0x21766F0 VA: 0x1821780F0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x21786B0 Offset: 0x2176CB0 VA: 0x1821786B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStartedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3622
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21780F0 Offset: 0x21766F0 VA: 0x1821780F0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x2178530 Offset: 0x2176B30 VA: 0x182178530 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStoppedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3623
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21780F0 Offset: 0x21766F0 VA: 0x1821780F0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x21785B0 Offset: 0x2176BB0 VA: 0x1821785B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

