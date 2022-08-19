public class DownloadHandler : IDisposable // TypeDefIndex: 4132
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public byte[] data { get; }
	public string text { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x90510 Offset: 0x8F910 VA: 0x180090510
	// RVA: 0x229F840 Offset: 0x229DE40 VA: 0x18229F840
	private void Release() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x229F460 Offset: 0x229DA60 VA: 0x18229F460 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x229F3F0 Offset: 0x229D9F0 VA: 0x18229F3F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x95F830 Offset: 0x95DE30 VA: 0x18095F830
	public byte[] get_data() { }

	// RVA: 0x95F920 Offset: 0x95DF20 VA: 0x18095F920
	public string get_text() { }

	// RVA: 0xB3BB10 Offset: 0xB3A110 VA: 0x180B3BB10 Slot: 5
	protected virtual byte[] GetData() { }

	// RVA: 0x229F7A0 Offset: 0x229DDA0 VA: 0x18229F7A0 Slot: 6
	protected virtual string GetText() { }

	// RVA: 0x229F580 Offset: 0x229DB80 VA: 0x18229F580
	private Encoding GetTextEncoder() { }

	// RVA: 0x229F540 Offset: 0x229DB40 VA: 0x18229F540
	private string GetContentType() { }

	// RVA: -1 Offset: -1
	protected static T GetCheckedDownloader<T>(UnityWebRequest www) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159EC80 Offset: 0x159D280 VA: 0x18159EC80
	|-DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>
	|-DownloadHandler.GetCheckedDownloader<object>
	*/

	[NativeThrowsAttribute] // RVA: 0x91510 Offset: 0x90910 VA: 0x180091510
	[VisibleToOtherModulesAttribute] // RVA: 0x91510 Offset: 0x90910 VA: 0x180091510
	// RVA: 0x229F330 Offset: 0x229D930 VA: 0x18229F330
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

}

