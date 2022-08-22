internal class FtpStatus // TypeDefIndex: 3001
{	// Fields
	private readonly FtpStatusCode statusCode; // 0x10
	private readonly string statusDescription; // 0x18

	// Properties
	public FtpStatusCode StatusCode { get; }
	public string StatusDescription { get; }

	// Methods

	// RVA: 0xC65380 Offset: 0xC63980 VA: 0x180C65380
	public void .ctor(FtpStatusCode statusCode, string statusDescription) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public FtpStatusCode get_StatusCode() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_StatusDescription() { }

}

