public class PhotoCapture : IDisposable // TypeDefIndex: 3607
{	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x2179CF0 Offset: 0x21782F0 VA: 0x182179CF0
	private static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179A70 Offset: 0x2178070 VA: 0x182179A70
	private static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x18175C0 Offset: 0x1815BC0 VA: 0x1818175C0
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179B10 Offset: 0x2178110 VA: 0x182179B10
	private static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179C00 Offset: 0x2178200 VA: 0x182179C00
	private static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179780 Offset: 0x2177D80 VA: 0x182179780
	private static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179870 Offset: 0x2177E70 VA: 0x182179870
	private static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	// RVA: 0x2179610 Offset: 0x2177C10 VA: 0x182179610 Slot: 4
	public void Dispose() { }

	[NativeConditionalAttribute] // RVA: 0xDAD60 Offset: 0xDA160 VA: 0x1800DAD60
	[NativeNameAttribute] // RVA: 0xDAD60 Offset: 0xDA160 VA: 0x1800DAD60
	// RVA: 0x21795D0 Offset: 0x2177BD0 VA: 0x1821795D0
	private void Dispose_Internal() { }

	// RVA: 0x21796A0 Offset: 0x2177CA0 VA: 0x1821796A0 Slot: 1
	protected override void Finalize() { }

	[NativeNameAttribute] // RVA: 0xDAF00 Offset: 0xDA300 VA: 0x1800DAF00
	[NativeConditionalAttribute] // RVA: 0xDAF00 Offset: 0xDA300 VA: 0x1800DAF00
	[ThreadAndSerializationSafeAttribute] // RVA: 0xDAF00 Offset: 0xDA300 VA: 0x1800DAF00
	// RVA: 0x2179590 Offset: 0x2177B90 VA: 0x182179590
	private void DisposeThreaded_Internal() { }

	// RVA: 0x2179D90 Offset: 0x2178390 VA: 0x182179D90
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

	// RVA: 0x2178BD0 Offset: 0x21771D0 VA: 0x182178BD0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x2178F10 Offset: 0x2177510 VA: 0x182178F10 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnPhotoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3612
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2178BD0 Offset: 0x21771D0 VA: 0x182178BD0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x2178F90 Offset: 0x2177590 VA: 0x182178F90 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToDiskCallback : MulticastDelegate // TypeDefIndex: 3613
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2178BD0 Offset: 0x21771D0 VA: 0x182178BD0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x2178B50 Offset: 0x2177150 VA: 0x182178B50 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToMemoryCallback : MulticastDelegate // TypeDefIndex: 3614
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1AA09C0 Offset: 0x1A9EFC0 VA: 0x181AA09C0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame) { }

	// RVA: 0x2178E80 Offset: 0x2177480 VA: 0x182178E80 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

