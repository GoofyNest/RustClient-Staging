public class DownloadHandler : IDisposable // TypeDefIndex: 4132
{	// Fields
	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public byte[] data { get; }
	public string text { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	// RVA: 0x22A0160 Offset: 0x229E760 VA: 0x1822A0160
	private void Release() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x229FD80 Offset: 0x229E380 VA: 0x18229FD80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x229FD10 Offset: 0x229E310 VA: 0x18229FD10 Slot: 4
	public void Dispose() { }

	// RVA: 0x95FE40 Offset: 0x95E440 VA: 0x18095FE40
	public byte[] get_data() { }

	// RVA: 0x95FF30 Offset: 0x95E530 VA: 0x18095FF30
	public string get_text() { }

	// RVA: 0xB3C2A0 Offset: 0xB3A8A0 VA: 0x180B3C2A0 Slot: 5
	protected virtual byte[] GetData() { }

	// RVA: 0x22A00C0 Offset: 0x229E6C0 VA: 0x1822A00C0 Slot: 6
	protected virtual string GetText() { }

	// RVA: 0x229FEA0 Offset: 0x229E4A0 VA: 0x18229FEA0
	private Encoding GetTextEncoder() { }

	// RVA: 0x229FE60 Offset: 0x229E460 VA: 0x18229FE60
	private string GetContentType() { }

	// RVA: -1 Offset: -1
	protected static T GetCheckedDownloader<T>(UnityWebRequest www) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E010 Offset: 0x159C610 VA: 0x18159E010
	|-DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>
	|-DownloadHandler.GetCheckedDownloader<object>
	*/

	[NativeThrowsAttribute] // RVA: 0x91550 Offset: 0x90950 VA: 0x180091550
	[VisibleToOtherModulesAttribute] // RVA: 0x91550 Offset: 0x90950 VA: 0x180091550
	// RVA: 0x229FC50 Offset: 0x229E250 VA: 0x18229FC50
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

}

