public class DownloadHandler : IDisposable // TypeDefIndex: 4132
{	[VisibleToOtherModulesAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	internal IntPtr m_Ptr; // 0x10

	public byte[] data { get; }
	public string text { get; }


	[NativeMethodAttribute] // RVA: 0x90660 Offset: 0x8FA60 VA: 0x180090660
	private void Release() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
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
	|-DownloadHandler.GetCheckedDownloader<DownloadHandlerTexture>
	|-DownloadHandler.GetCheckedDownloader<object>
	*/

	[NativeThrowsAttribute] // RVA: 0x91750 Offset: 0x90B50 VA: 0x180091750
	[VisibleToOtherModulesAttribute] // RVA: 0x91750 Offset: 0x90B50 VA: 0x180091750
	internal static byte[] InternalGetByteArray(DownloadHandler dh) { }

}

