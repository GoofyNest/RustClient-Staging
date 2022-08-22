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

	// RVA: 0x1342D70 Offset: 0x1341370 VA: 0x181342D70
	internal void .ctor(Uri uri, string method, WebConnectionData data, CookieContainer container) { }

	[ObsoleteAttribute] // RVA: 0xB6F50 Offset: 0xB6350 VA: 0x1800B6F50
	// RVA: 0x1342AC0 Offset: 0x13410C0 VA: 0x181342AC0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 11
	public override long get_ContentLength() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1342FC0 Offset: 0x13415C0 VA: 0x181342FC0 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440 Slot: 15
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x1342FE0 Offset: 0x13415E0 VA: 0x181342FE0 Slot: 16
	public virtual string get_StatusDescription() { }

	// RVA: 0x13429E0 Offset: 0x1340FE0 VA: 0x1813429E0
	internal void ReadAll() { }

	// RVA: 0x1342940 Offset: 0x1340F40 VA: 0x181342940 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x118D220 Offset: 0x118B820 VA: 0x18118D220 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1342830 Offset: 0x1340E30 VA: 0x181342830 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1342660 Offset: 0x1340C60 VA: 0x181342660 Slot: 9
	public override void Close() { }

	// RVA: 0x1342A70 Offset: 0x1341070 VA: 0x181342A70 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13426A0 Offset: 0x1340CA0 VA: 0x1813426A0 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x13425D0 Offset: 0x1340BD0 VA: 0x1813425D0
	private void CheckDisposed() { }

	// RVA: 0x13426B0 Offset: 0x1340CB0 VA: 0x1813426B0
	private void FillCookies() { }

	[ObsoleteAttribute] // RVA: 0xB8A40 Offset: 0xB7E40 VA: 0x1800B8A40
	[EditorBrowsableAttribute] // RVA: 0xB8A40 Offset: 0xB7E40 VA: 0x1800B8A40
	// RVA: 0x1342A90 Offset: 0x1341090 VA: 0x181342A90
	public void .ctor() { }

}

