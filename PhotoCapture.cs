public class PhotoCapture : IDisposable // TypeDefIndex: 3607
{	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x21793D0 Offset: 0x21779D0 VA: 0x1821793D0
	private static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2179150 Offset: 0x2177750 VA: 0x182179150
	private static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x1829F00 Offset: 0x1828500 VA: 0x181829F00
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21791F0 Offset: 0x21777F0 VA: 0x1821791F0
	private static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x21792E0 Offset: 0x21778E0 VA: 0x1821792E0
	private static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2178E60 Offset: 0x2177460 VA: 0x182178E60
	private static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2178F50 Offset: 0x2177550 VA: 0x182178F50
	private static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	// RVA: 0x2178CF0 Offset: 0x21772F0 VA: 0x182178CF0 Slot: 4
	public void Dispose() { }

	[NativeConditionalAttribute] // RVA: 0xDAD30 Offset: 0xDA130 VA: 0x1800DAD30
	[NativeNameAttribute] // RVA: 0xDAD30 Offset: 0xDA130 VA: 0x1800DAD30
	// RVA: 0x2178CB0 Offset: 0x21772B0 VA: 0x182178CB0
	private void Dispose_Internal() { }

	// RVA: 0x2178D80 Offset: 0x2177380 VA: 0x182178D80 Slot: 1
	protected override void Finalize() { }

	[NativeNameAttribute] // RVA: 0xDAF10 Offset: 0xDA310 VA: 0x1800DAF10
	[ThreadAndSerializationSafeAttribute] // RVA: 0xDAF10 Offset: 0xDA310 VA: 0x1800DAF10
	[NativeConditionalAttribute] // RVA: 0xDAF10 Offset: 0xDA310 VA: 0x1800DAF10
	// RVA: 0x2178C70 Offset: 0x2177270 VA: 0x182178C70
	private void DisposeThreaded_Internal() { }

	// RVA: 0x2179470 Offset: 0x2177A70 VA: 0x182179470
	private static void .cctor() { }

}

public enum PhotoCapture.CaptureResultType // TypeDefIndex: 3608
{	// Fields
	public int value__; // 0x0
	public const PhotoCapture.CaptureResultType Success = 0;
	public const PhotoCapture.CaptureResultType UnknownError = 1;

}

public struct PhotoCapture.PhotoCaptureResult // TypeDefIndex: 3609
{	// Fields
	public PhotoCapture.CaptureResultType resultType; // 0x0
	public long hResult; // 0x8

}

public sealed class PhotoCapture.OnCaptureResourceCreatedCallback : MulticastDelegate // TypeDefIndex: 3610
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x49A3B0 Offset: 0x4989B0 VA: 0x18049A3B0 Slot: 12
	public virtual void Invoke(PhotoCapture captureObject) { }

	// RVA: 0x49A380 Offset: 0x498980 VA: 0x18049A380 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture captureObject, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnPhotoModeStartedCallback : MulticastDelegate // TypeDefIndex: 3611
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21782B0 Offset: 0x21768B0 VA: 0x1821782B0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x21785F0 Offset: 0x2176BF0 VA: 0x1821785F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnPhotoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3612
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21782B0 Offset: 0x21768B0 VA: 0x1821782B0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x2178670 Offset: 0x2176C70 VA: 0x182178670 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToDiskCallback : MulticastDelegate // TypeDefIndex: 3613
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21782B0 Offset: 0x21768B0 VA: 0x1821782B0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x2178230 Offset: 0x2176830 VA: 0x182178230 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToMemoryCallback : MulticastDelegate // TypeDefIndex: 3614
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A47C20 Offset: 0x1A46220 VA: 0x181A47C20 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame) { }

	// RVA: 0x2178560 Offset: 0x2176B60 VA: 0x182178560 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

