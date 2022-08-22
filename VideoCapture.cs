public class VideoCapture : IDisposable // TypeDefIndex: 3616
{	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0


	private static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult) { }

	public void Dispose() { }

	[NativeConditionalAttribute] // RVA: 0xDDA50 Offset: 0xDCE50 VA: 0x1800DDA50
	[NativeMethodAttribute] // RVA: 0xDDA50 Offset: 0xDCE50 VA: 0x1800DDA50
	private void Dispose_Internal() { }

	protected override void Finalize() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0xDDBA0 Offset: 0xDCFA0 VA: 0x1800DDBA0
	[NativeMethodAttribute] // RVA: 0xDDBA0 Offset: 0xDCFA0 VA: 0x1800DDBA0
	[NativeConditionalAttribute] // RVA: 0xDDBA0 Offset: 0xDCFA0 VA: 0x1800DDBA0
	private void DisposeThreaded_Internal() { }

	private static void .cctor() { }

}

public enum VideoCapture.CaptureResultType // TypeDefIndex: 3617
{	public int value__; // 0x0
	public const VideoCapture.CaptureResultType Success = 0;
	public const VideoCapture.CaptureResultType UnknownError = 1;

}

public struct VideoCapture.VideoCaptureResult // TypeDefIndex: 3618
{	public VideoCapture.CaptureResultType resultType; // 0x0
	public long hResult; // 0x8

}

public sealed class VideoCapture.OnVideoCaptureResourceCreatedCallback : MulticastDelegate // TypeDefIndex: 3619
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoCapture captureObject) { }

	public virtual IAsyncResult BeginInvoke(VideoCapture captureObject, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnVideoModeStartedCallback : MulticastDelegate // TypeDefIndex: 3620
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnVideoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3621
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStartedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3622
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStoppedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3623
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

