public class VideoCapture : IDisposable // TypeDefIndex: 3616
{	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x2186980 Offset: 0x2184F80 VA: 0x182186980
	private static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2186520 Offset: 0x2184B20 VA: 0x182186520
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x1829F00 Offset: 0x1828500 VA: 0x181829F00
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21867A0 Offset: 0x2184DA0 VA: 0x1821867A0
	private static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2186890 Offset: 0x2184E90 VA: 0x182186890
	private static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21865C0 Offset: 0x2184BC0 VA: 0x1821865C0
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21866B0 Offset: 0x2184CB0 VA: 0x1821866B0
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult) { }

	// RVA: 0x21863B0 Offset: 0x21849B0 VA: 0x1821863B0 Slot: 4
	public void Dispose() { }

	[NativeMethodAttribute] // RVA: 0xDD9F0 Offset: 0xDCDF0 VA: 0x1800DD9F0
	[NativeConditionalAttribute] // RVA: 0xDD9F0 Offset: 0xDCDF0 VA: 0x1800DD9F0
	// RVA: 0x2186370 Offset: 0x2184970 VA: 0x182186370
	private void Dispose_Internal() { }

	// RVA: 0x2186440 Offset: 0x2184A40 VA: 0x182186440 Slot: 1
	protected override void Finalize() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0xDDB40 Offset: 0xDCF40 VA: 0x1800DDB40
	[NativeConditionalAttribute] // RVA: 0xDDB40 Offset: 0xDCF40 VA: 0x1800DDB40
	[NativeMethodAttribute] // RVA: 0xDDB40 Offset: 0xDCF40 VA: 0x1800DDB40
	// RVA: 0x2186330 Offset: 0x2184930 VA: 0x182186330
	private void DisposeThreaded_Internal() { }

	// RVA: 0x2186A20 Offset: 0x2185020 VA: 0x182186A20
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

	// RVA: 0x21782B0 Offset: 0x21768B0 VA: 0x1821782B0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x21787F0 Offset: 0x2176DF0 VA: 0x1821787F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnVideoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3621
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21782B0 Offset: 0x21768B0 VA: 0x1821782B0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x2178870 Offset: 0x2176E70 VA: 0x182178870 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStartedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3622
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21782B0 Offset: 0x21768B0 VA: 0x1821782B0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x21786F0 Offset: 0x2176CF0 VA: 0x1821786F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStoppedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3623
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21782B0 Offset: 0x21768B0 VA: 0x1821782B0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x2178770 Offset: 0x2176D70 VA: 0x182178770 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

