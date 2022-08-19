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

	// RVA: 0x1338840 Offset: 0x1336E40 VA: 0x181338840
	internal void .ctor(FtpWebRequest request, Uri uri, string method, bool keepAlive) { }

	// RVA: 0x1338960 Offset: 0x1336F60 VA: 0x181338960
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x1338800 Offset: 0x1336E00 VA: 0x181338800
	internal void .ctor(FtpWebRequest request, Uri uri, string method, FtpStatus status) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 11
	public override long get_ContentLength() { }

	// RVA: 0x1338AA0 Offset: 0x13370A0 VA: 0x181338AA0 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0xC15030 Offset: 0xC13630 VA: 0x180C15030
	internal void set_LastModified(DateTime value) { }

	// RVA: 0x6AD5B0 Offset: 0x6ABBB0 VA: 0x1806AD5B0
	internal void set_BannerMessage(string value) { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_WelcomeMessage(string value) { }

	// RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
	internal void set_StatusCode(FtpStatusCode value) { }

	// RVA: 0x13385D0 Offset: 0x1336BD0 VA: 0x1813385D0 Slot: 9
	public override void Close() { }

	// RVA: 0x13386A0 Offset: 0x1336CA0 VA: 0x1813386A0 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_Stream(Stream value) { }

	// RVA: 0x13387D0 Offset: 0x1336DD0 VA: 0x1813387D0
	internal void UpdateStatus(FtpStatus status) { }

	// RVA: 0x1338540 Offset: 0x1336B40 VA: 0x181338540
	private void CheckDisposed() { }

	// RVA: 0x13387C0 Offset: 0x1336DC0 VA: 0x1813387C0
	internal bool IsFinal() { }

}

