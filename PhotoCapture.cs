public class PhotoCapture : IDisposable // TypeDefIndex: 3607
{	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x2179210 Offset: 0x2177810 VA: 0x182179210
	private static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178F90 Offset: 0x2177590 VA: 0x182178F90
	private static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x1829EC0 Offset: 0x18284C0 VA: 0x181829EC0
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179030 Offset: 0x2177630 VA: 0x182179030
	private static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179120 Offset: 0x2177720 VA: 0x182179120
	private static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178CA0 Offset: 0x21772A0 VA: 0x182178CA0
	private static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178D90 Offset: 0x2177390 VA: 0x182178D90
	private static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	// RVA: 0x2178B30 Offset: 0x2177130 VA: 0x182178B30 Slot: 4
	public void Dispose() { }

	[NativeConditionalAttribute] // RVA: 0xDAD60 Offset: 0xDA160 VA: 0x1800DAD60
	[NativeNameAttribute] // RVA: 0xDAD60 Offset: 0xDA160 VA: 0x1800DAD60
	// RVA: 0x2178AF0 Offset: 0x21770F0 VA: 0x182178AF0
	private void Dispose_Internal() { }

	// RVA: 0x2178BC0 Offset: 0x21771C0 VA: 0x182178BC0 Slot: 1
	protected override void Finalize() { }

	[NativeNameAttribute] // RVA: 0xDAF00 Offset: 0xDA300 VA: 0x1800DAF00
	[NativeConditionalAttribute] // RVA: 0xDAF00 Offset: 0xDA300 VA: 0x1800DAF00
	[ThreadAndSerializationSafeAttribute] // RVA: 0xDAF00 Offset: 0xDA300 VA: 0x1800DAF00
	// RVA: 0x2178AB0 Offset: 0x21770B0 VA: 0x182178AB0
	private void DisposeThreaded_Internal() { }

	// RVA: 0x21792B0 Offset: 0x21778B0 VA: 0x1821792B0
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

	// RVA: 0x21780F0 Offset: 0x21766F0 VA: 0x1821780F0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x2178430 Offset: 0x2176A30 VA: 0x182178430 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnPhotoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3612
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21780F0 Offset: 0x21766F0 VA: 0x1821780F0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x21784B0 Offset: 0x2176AB0 VA: 0x1821784B0 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToDiskCallback : MulticastDelegate // TypeDefIndex: 3613
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21780F0 Offset: 0x21766F0 VA: 0x1821780F0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x2178070 Offset: 0x2176670 VA: 0x182178070 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToMemoryCallback : MulticastDelegate // TypeDefIndex: 3614
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A47BE0 Offset: 0x1A461E0 VA: 0x181A47BE0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame) { }

	// RVA: 0x21783A0 Offset: 0x21769A0 VA: 0x1821783A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

