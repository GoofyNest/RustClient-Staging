public class VideoCapture : IDisposable // TypeDefIndex: 3616
{	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x2186A80 Offset: 0x2185080 VA: 0x182186A80
	private static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2186620 Offset: 0x2184C20 VA: 0x182186620
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x182A180 Offset: 0x1828780 VA: 0x18182A180
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21868A0 Offset: 0x2184EA0 VA: 0x1821868A0
	private static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2186990 Offset: 0x2184F90 VA: 0x182186990
	private static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21866C0 Offset: 0x2184CC0 VA: 0x1821866C0
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21867B0 Offset: 0x2184DB0 VA: 0x1821867B0
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult) { }

	// RVA: 0x21864B0 Offset: 0x2184AB0 VA: 0x1821864B0 Slot: 4
	public void Dispose() { }

	[NativeConditionalAttribute] // RVA: 0xDDA50 Offset: 0xDCE50 VA: 0x1800DDA50
	[NativeMethodAttribute] // RVA: 0xDDA50 Offset: 0xDCE50 VA: 0x1800DDA50
	// RVA: 0x2186470 Offset: 0x2184A70 VA: 0x182186470
	private void Dispose_Internal() { }

	// RVA: 0x2186540 Offset: 0x2184B40 VA: 0x182186540 Slot: 1
	protected override void Finalize() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0xDDBA0 Offset: 0xDCFA0 VA: 0x1800DDBA0
	[NativeMethodAttribute] // RVA: 0xDDBA0 Offset: 0xDCFA0 VA: 0x1800DDBA0
	[NativeConditionalAttribute] // RVA: 0xDDBA0 Offset: 0xDCFA0 VA: 0x1800DDBA0
	// RVA: 0x2186430 Offset: 0x2184A30 VA: 0x182186430
	private void DisposeThreaded_Internal() { }

	// RVA: 0x2186B20 Offset: 0x2185120 VA: 0x182186B20
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

	// RVA: 0x21783B0 Offset: 0x21769B0 VA: 0x1821783B0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x21788F0 Offset: 0x2176EF0 VA: 0x1821788F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnVideoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3621
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21783B0 Offset: 0x21769B0 VA: 0x1821783B0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x2178970 Offset: 0x2176F70 VA: 0x182178970 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStartedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3622
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21783B0 Offset: 0x21769B0 VA: 0x1821783B0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x21787F0 Offset: 0x2176DF0 VA: 0x1821787F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStoppedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3623
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21783B0 Offset: 0x21769B0 VA: 0x1821783B0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x2178870 Offset: 0x2176E70 VA: 0x182178870 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

