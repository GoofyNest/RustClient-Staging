public class HttpWebResponse : WebResponse, ISerializable, IDisposable // TypeDefIndex: 3010
{	// Fields
	private Uri uri; // 0x18
	private WebHeaderCollection webHeaders; // 0x20
	private CookieCollection cookieCollection; // 0x28
	private string method; // 0x30
	private Version version; // 0x38
	private HttpStatusCode statusCode; // 0x40
	private string statusDescription; // 0x48
	private long contentLength; // 0x50
	private string contentType; // 0x58
	private CookieContainer cookie_container; // 0x60
	private bool disposed; // 0x68
	private Stream stream; // 0x70

	// Properties
	public override long ContentLength { get; }
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public virtual HttpStatusCode StatusCode { get; }
	public virtual string StatusDescription { get; }

	// Methods

	// RVA: 0x1341E70 Offset: 0x1340470 VA: 0x181341E70
	internal void .ctor(Uri uri, string method, WebConnectionData data, CookieContainer container) { }

	[ObsoleteAttribute] // RVA: 0xB6F50 Offset: 0xB6350 VA: 0x1800B6F50
	// RVA: 0x1341BC0 Offset: 0x13401C0 VA: 0x181341BC0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800 Slot: 11
	public override long get_ContentLength() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x13420C0 Offset: 0x13406C0 VA: 0x1813420C0 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0 Slot: 15
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x13420E0 Offset: 0x13406E0 VA: 0x1813420E0 Slot: 16
	public virtual string get_StatusDescription() { }

	// RVA: 0x1341AE0 Offset: 0x13400E0 VA: 0x181341AE0
	internal void ReadAll() { }

	// RVA: 0x1341A40 Offset: 0x1340040 VA: 0x181341A40 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x1191B40 Offset: 0x1190140 VA: 0x181191B40 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1341930 Offset: 0x133FF30 VA: 0x181341930 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1341760 Offset: 0x133FD60 VA: 0x181341760 Slot: 9
	public override void Close() { }

	// RVA: 0x1341B70 Offset: 0x1340170 VA: 0x181341B70 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13417A0 Offset: 0x133FDA0 VA: 0x1813417A0 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13416D0 Offset: 0x133FCD0 VA: 0x1813416D0
	private void CheckDisposed() { }

	// RVA: 0x13417B0 Offset: 0x133FDB0 VA: 0x1813417B0
	private void FillCookies() { }

	[ObsoleteAttribute] // RVA: 0xB8A40 Offset: 0xB7E40 VA: 0x1800B8A40
	[EditorBrowsableAttribute] // RVA: 0xB8A40 Offset: 0xB7E40 VA: 0x1800B8A40
	// RVA: 0x1341B90 Offset: 0x1340190 VA: 0x181341B90
	public void .ctor() { }

}

