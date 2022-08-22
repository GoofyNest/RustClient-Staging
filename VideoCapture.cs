public class VideoCapture : IDisposable // TypeDefIndex: 3616
{	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x21872A0 Offset: 0x21858A0 VA: 0x1821872A0
	private static VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2186E40 Offset: 0x2185440 VA: 0x182186E40
	private static void InvokeOnCreatedVideoCaptureResourceDelegate(VideoCapture.OnVideoCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x18175C0 Offset: 0x1815BC0 VA: 0x1818175C0
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21870C0 Offset: 0x21856C0 VA: 0x1821870C0
	private static void InvokeOnVideoModeStartedDelegate(VideoCapture.OnVideoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21871B0 Offset: 0x21857B0 VA: 0x1821871B0
	private static void InvokeOnVideoModeStoppedDelegate(VideoCapture.OnVideoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2186EE0 Offset: 0x21854E0 VA: 0x182186EE0
	private static void InvokeOnStartedRecordingVideoToDiskDelegate(VideoCapture.OnStartedRecordingVideoCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2186FD0 Offset: 0x21855D0 VA: 0x182186FD0
	private static void InvokeOnStoppedRecordingVideoToDiskDelegate(VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult) { }

	// RVA: 0x2186CD0 Offset: 0x21852D0 VA: 0x182186CD0 Slot: 4
	public void Dispose() { }

	[NativeConditionalAttribute] // RVA: 0xDDA50 Offset: 0xDCE50 VA: 0x1800DDA50
	[NativeMethodAttribute] // RVA: 0xDDA50 Offset: 0xDCE50 VA: 0x1800DDA50
	// RVA: 0x2186C90 Offset: 0x2185290 VA: 0x182186C90
	private void Dispose_Internal() { }

	// RVA: 0x2186D60 Offset: 0x2185360 VA: 0x182186D60 Slot: 1
	protected override void Finalize() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0xDDBA0 Offset: 0xDCFA0 VA: 0x1800DDBA0
	[NativeMethodAttribute] // RVA: 0xDDBA0 Offset: 0xDCFA0 VA: 0x1800DDBA0
	[NativeConditionalAttribute] // RVA: 0xDDBA0 Offset: 0xDCFA0 VA: 0x1800DDBA0
	// RVA: 0x2186C50 Offset: 0x2185250 VA: 0x182186C50
	private void DisposeThreaded_Internal() { }

	// RVA: 0x2187340 Offset: 0x2185940 VA: 0x182187340
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

	// RVA: 0x2178BD0 Offset: 0x21771D0 VA: 0x182178BD0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x2179110 Offset: 0x2177710 VA: 0x182179110 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnVideoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3621
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2178BD0 Offset: 0x21771D0 VA: 0x182178BD0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x2179190 Offset: 0x2177790 VA: 0x182179190 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStartedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3622
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2178BD0 Offset: 0x21771D0 VA: 0x182178BD0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x2179010 Offset: 0x2177610 VA: 0x182179010 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class VideoCapture.OnStoppedRecordingVideoCallback : MulticastDelegate // TypeDefIndex: 3623
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2178BD0 Offset: 0x21771D0 VA: 0x182178BD0 Slot: 12
	public virtual void Invoke(VideoCapture.VideoCaptureResult result) { }

	// RVA: 0x2179090 Offset: 0x2177690 VA: 0x182179090 Slot: 13
	public virtual IAsyncResult BeginInvoke(VideoCapture.VideoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

