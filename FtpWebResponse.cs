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

	// RVA: 0x1338B00 Offset: 0x1337100 VA: 0x181338B00
	internal void .ctor(FtpWebRequest request, Uri uri, string method, bool keepAlive) { }

	// RVA: 0x1338C20 Offset: 0x1337220 VA: 0x181338C20
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1338AC0 Offset: 0x13370C0 VA: 0x181338AC0
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatus status) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 11
	public override long get_ContentLength() { }

	// RVA: 0x1338D60 Offset: 0x1337360 VA: 0x181338D60 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0xC152F0 Offset: 0xC138F0 VA: 0x180C152F0
	internal void set_LastModified(DateTime value) { }

	// RVA: 0x6AD6C0 Offset: 0x6ABCC0 VA: 0x1806AD6C0
	internal void set_BannerMessage(string value) { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_WelcomeMessage(string value) { }

	// RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	internal void set_StatusCode(FtpStatusCode value) { }

	// RVA: 0x1338890 Offset: 0x1336E90 VA: 0x181338890 Slot: 9
	public override void Close() { }

	// RVA: 0x1338960 Offset: 0x1336F60 VA: 0x181338960 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_Stream(Stream value) { }

	// RVA: 0x1338A90 Offset: 0x1337090 VA: 0x181338A90
	internal void UpdateStatus(FtpStatus status) { }

	// RVA: 0x1338800 Offset: 0x1336E00 VA: 0x181338800
	private void CheckDisposed() { }

	// RVA: 0x1338A80 Offset: 0x1337080 VA: 0x181338A80
	internal bool IsFinal() { }

}

