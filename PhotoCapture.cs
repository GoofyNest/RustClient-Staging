public class PhotoCapture : IDisposable // TypeDefIndex: 3607
{	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0


	private static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	public void Dispose() { }

	[NativeNameAttribute] // RVA: 0xDAE10 Offset: 0xDA210 VA: 0x1800DAE10
	[NativeConditionalAttribute] // RVA: 0xDAE10 Offset: 0xDA210 VA: 0x1800DAE10
	private void Dispose_Internal() { }

	protected override void Finalize() { }

	[NativeConditionalAttribute] // RVA: 0xDAFF0 Offset: 0xDA3F0 VA: 0x1800DAFF0
	[NativeNameAttribute] // RVA: 0xDAFF0 Offset: 0xDA3F0 VA: 0x1800DAFF0
	[ThreadAndSerializationSafeAttribute] // RVA: 0xDAFF0 Offset: 0xDA3F0 VA: 0x1800DAFF0
	private void DisposeThreaded_Internal() { }

	private static void .cctor() { }

}

public enum PhotoCapture.CaptureResultType // TypeDefIndex: 3608
{	public int value__; // 0x0
	public const PhotoCapture.CaptureResultType Success = 0;
	public const PhotoCapture.CaptureResultType UnknownError = 1;

}

public struct PhotoCapture.PhotoCaptureResult // TypeDefIndex: 3609
{	public PhotoCapture.CaptureResultType resultType; // 0x0
	public long hResult; // 0x8

}

public sealed class PhotoCapture.OnCaptureResourceCreatedCallback : MulticastDelegate // TypeDefIndex: 3610
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(PhotoCapture captureObject) { }

	public virtual IAsyncResult BeginInvoke(PhotoCapture captureObject, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnPhotoModeStartedCallback : MulticastDelegate // TypeDefIndex: 3611
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnPhotoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3612
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToDiskCallback : MulticastDelegate // TypeDefIndex: 3613
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToMemoryCallback : MulticastDelegate // TypeDefIndex: 3614
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame) { }

	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

