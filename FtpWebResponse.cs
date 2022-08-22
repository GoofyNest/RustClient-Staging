public class FtpWebResponse : WebResponse // TypeDefIndex: 3004
{	// Fields
	private Stream stream; // 0x18
	private Uri uri; // 0x20
	private FtpStatusCode statusCode; // 0x28
	private DateTime lastModified; // 0x30
	private string bannerMessage; // 0x38
	private string welcomeMessage; // 0x40
	private string exitMessage; // 0x48
	private string statusDescription; // 0x50
	private string method; // 0x58
	private bool disposed; // 0x60
	private FtpWebRequest request; // 0x68
	internal long contentLength; // 0x70

	// Properties
	public override long ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	internal DateTime LastModified { set; }
	internal string BannerMessage { set; }
	internal string WelcomeMessage { set; }
	internal FtpStatusCode StatusCode { set; }
	internal Stream Stream { set; }

	// Methods

	// RVA: 0x1337C00 Offset: 0x1336200 VA: 0x181337C00
	internal void .ctor(FtpWebRequest request, Uri uri, string method, bool keepAlive) { }

	// RVA: 0x1337D20 Offset: 0x1336320 VA: 0x181337D20
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1337BC0 Offset: 0x13361C0 VA: 0x181337BC0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatus status) { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360 Slot: 11
	public override long get_ContentLength() { }

	// RVA: 0x1337E60 Offset: 0x1336460 VA: 0x181337E60 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0xC157C0 Offset: 0xC13DC0 VA: 0x180C157C0
	internal void set_LastModified(DateTime value) { }

	// RVA: 0x6AD650 Offset: 0x6ABC50 VA: 0x1806AD650
	internal void set_BannerMessage(string value) { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void set_WelcomeMessage(string value) { }

	// RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	internal void set_StatusCode(FtpStatusCode value) { }

	// RVA: 0x1337990 Offset: 0x1335F90 VA: 0x181337990 Slot: 9
	public override void Close() { }

	// RVA: 0x1337A60 Offset: 0x1336060 VA: 0x181337A60 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_Stream(Stream value) { }

	// RVA: 0x1337B90 Offset: 0x1336190 VA: 0x181337B90
	internal void UpdateStatus(FtpStatus status) { }

	// RVA: 0x1337900 Offset: 0x1335F00 VA: 0x181337900
	private void CheckDisposed() { }

	// RVA: 0x1337B80 Offset: 0x1336180 VA: 0x181337B80
	internal bool IsFinal() { }

}

