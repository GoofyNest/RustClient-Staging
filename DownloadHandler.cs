public class DownloadHandler : IDisposable // TypeDefIndex: 4132
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public byte[] data { get; }
	public string text { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x229F940 Offset: 0x229DF40 VA: 0x18229F940
	private void Release() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x229F560 Offset: 0x229DB60 VA: 0x18229F560 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x229F4F0 Offset: 0x229DAF0 VA: 0x18229F4F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x95F940 Offset: 0x95DF40 VA: 0x18095F940
	public byte[] get_data() { }

	// RVA: 0x95FA30 Offset: 0x95E030 VA: 0x18095FA30
	public string get_text() { }

	// RVA: 0xB3BDD0 Offset: 0xB3A3D0 VA: 0x180B3BDD0 Slot: 5
	protected virtual byte[] GetData() { }

	// RVA: 0x229F8A0 Offset: 0x229DEA0 VA: 0x18229F8A0 Slot: 6
	protected virtual string GetText() { }

	// RVA: 0x229F680 Offset: 0x229DC80 VA: 0x18229F680
	private Encoding GetTextEncoder() { }

	// RVA: 0x229F640 Offset: 0x229DC40 VA: 0x18229F640
	private string GetContentType() { }

	// RVA: -1 Offset: -1
	protected static T GetCheckedDownloader<T>(UnityWebRequest www) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159EF40 Offset: 0x159D540 VA: 0x18159EF40
	|-DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>
	|-DownloadHandler.GetCheckedDownloader<object>
	*/

	[NativeThrowsAttribute] // RVA: 0x91550 Offset: 0x90950 VA: 0x180091550
	[VisibleToOtherModulesAttribute] // RVA: 0x91550 Offset: 0x90950 VA: 0x180091550
	// RVA: 0x229F430 Offset: 0x229DA30 VA: 0x18229F430
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

}

