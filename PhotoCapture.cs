public class PhotoCapture : IDisposable // TypeDefIndex: 3607
{	// Fields
	internal IntPtr m_NativePtr; // 0x10
	private static readonly long HR_SUCCESS; // 0x0

	// Methods

	// RVA: 0x21794D0 Offset: 0x2177AD0 VA: 0x1821794D0
	private static PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179250 Offset: 0x2177850 VA: 0x182179250
	private static void InvokeOnCreatedResourceDelegate(PhotoCapture.OnCaptureResourceCreatedCallback callback, IntPtr nativePtr) { }

	// RVA: 0x182A180 Offset: 0x1828780 VA: 0x18182A180
	private void .ctor(IntPtr nativeCaptureObject) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21792F0 Offset: 0x21778F0 VA: 0x1821792F0
	private static void InvokeOnPhotoModeStartedDelegate(PhotoCapture.OnPhotoModeStartedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21793E0 Offset: 0x21779E0 VA: 0x1821793E0
	private static void InvokeOnPhotoModeStoppedDelegate(PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178F60 Offset: 0x2177560 VA: 0x182178F60
	private static void InvokeOnCapturedPhotoToDiskDelegate(PhotoCapture.OnCapturedToDiskCallback callback, long hResult) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179050 Offset: 0x2177650 VA: 0x182179050
	private static void InvokeOnCapturedPhotoToMemoryDelegate(PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, IntPtr photoCaptureFramePtr) { }

	// RVA: 0x2178DF0 Offset: 0x21773F0 VA: 0x182178DF0 Slot: 4
	public void Dispose() { }

	[NativeConditionalAttribute] // RVA: 0xDAD60 Offset: 0xDA160 VA: 0x1800DAD60
	[NativeNameAttribute] // RVA: 0xDAD60 Offset: 0xDA160 VA: 0x1800DAD60
	// RVA: 0x2178DB0 Offset: 0x21773B0 VA: 0x182178DB0
	private void Dispose_Internal() { }

	// RVA: 0x2178E80 Offset: 0x2177480 VA: 0x182178E80 Slot: 1
	protected override void Finalize() { }

	[NativeNameAttribute] // RVA: 0xDAF00 Offset: 0xDA300 VA: 0x1800DAF00
	[NativeConditionalAttribute] // RVA: 0xDAF00 Offset: 0xDA300 VA: 0x1800DAF00
	[ThreadAndSerializationSafeAttribute] // RVA: 0xDAF00 Offset: 0xDA300 VA: 0x1800DAF00
	// RVA: 0x2178D70 Offset: 0x2177370 VA: 0x182178D70
	private void DisposeThreaded_Internal() { }

	// RVA: 0x2179570 Offset: 0x2177B70 VA: 0x182179570
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

	// RVA: 0x21783B0 Offset: 0x21769B0 VA: 0x1821783B0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x21786F0 Offset: 0x2176CF0 VA: 0x1821786F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnPhotoModeStoppedCallback : MulticastDelegate // TypeDefIndex: 3612
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21783B0 Offset: 0x21769B0 VA: 0x1821783B0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x2178770 Offset: 0x2176D70 VA: 0x182178770 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToDiskCallback : MulticastDelegate // TypeDefIndex: 3613
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21783B0 Offset: 0x21769B0 VA: 0x1821783B0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result) { }

	// RVA: 0x2178330 Offset: 0x2176930 VA: 0x182178330 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class PhotoCapture.OnCapturedToMemoryCallback : MulticastDelegate // TypeDefIndex: 3614
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A47EA0 Offset: 0x1A464A0 VA: 0x181A47EA0 Slot: 12
	public virtual void Invoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame) { }

	// RVA: 0x2178660 Offset: 0x2176C60 VA: 0x182178660 Slot: 13
	public virtual IAsyncResult BeginInvoke(PhotoCapture.PhotoCaptureResult result, PhotoCaptureFrame photoCaptureFrame, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

