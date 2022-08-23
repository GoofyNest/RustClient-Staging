public class DownloadHandler : IDisposable // TypeDefIndex: 4132
{	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal IntPtr m_Ptr; // 0x10

	public byte[] data { get; }
	public string text { get; }


	[NativeMethodAttribute] // RVA: 0x90620 Offset: 0x8FA20 VA: 0x180090620
	private void Release() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	internal void .ctor() { }

	protected override void Finalize() { }

	public void Dispose() { }

	public byte[] get_data() { }

	public string get_text() { }

	protected virtual byte[] GetData() { }

	protected virtual string GetText() { }

	private Encoding GetTextEncoder() { }

	private string GetContentType() { }

	protected static T GetCheckedDownloader<T>(UnityWebRequest www) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E050 Offset: 0x159C650 VA: 0x18159E050
	|-DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>
	|-DownloadHandler.GetCheckedDownloader<object>
	*/

	[NativeThrowsAttribute] // RVA: 0x91550 Offset: 0x90950 VA: 0x180091550
	[VisibleToOtherModulesAttribute] // RVA: 0x91550 Offset: 0x90950 VA: 0x180091550
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

}

