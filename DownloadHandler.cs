public class DownloadHandler : IDisposable // TypeDefIndex: 4132
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public byte[] data { get; }
	public string text { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x229F680 Offset: 0x229DC80 VA: 0x18229F680
	private void Release() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x229F2A0 Offset: 0x229D8A0 VA: 0x18229F2A0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x229F230 Offset: 0x229D830 VA: 0x18229F230 Slot: 4
	public void Dispose() { }

	// RVA: 0x95F830 Offset: 0x95DE30 VA: 0x18095F830
	public byte[] get_data() { }

	// RVA: 0x95F920 Offset: 0x95DF20 VA: 0x18095F920
	public string get_text() { }

	// RVA: 0xB3BB10 Offset: 0xB3A110 VA: 0x180B3BB10 Slot: 5
	protected virtual byte[] GetData() { }

	// RVA: 0x229F5E0 Offset: 0x229DBE0 VA: 0x18229F5E0 Slot: 6
	protected virtual string GetText() { }

	// RVA: 0x229F3C0 Offset: 0x229D9C0 VA: 0x18229F3C0
	private Encoding GetTextEncoder() { }

	// RVA: 0x229F380 Offset: 0x229D980 VA: 0x18229F380
	private string GetContentType() { }

	// RVA: -1 Offset: -1
	protected static T GetCheckedDownloader<T>(UnityWebRequest www) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159EC80 Offset: 0x159D280 VA: 0x18159EC80
	|-DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>
	|-DownloadHandler.GetCheckedDownloader<object>
	*/

	[NativeThrowsAttribute] // RVA: 0x91550 Offset: 0x90950 VA: 0x180091550
	[VisibleToOtherModulesAttribute] // RVA: 0x91550 Offset: 0x90950 VA: 0x180091550
	// RVA: 0x229F170 Offset: 0x229D770 VA: 0x18229F170
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

}

