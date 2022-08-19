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

	// RVA: 0x1342AB0 Offset: 0x13410B0 VA: 0x181342AB0
	internal void .ctor(Uri uri, string method, WebConnectionData data, CookieContainer container) { }

	[ObsoleteAttribute] // RVA: 0xB6F60 Offset: 0xB6360 VA: 0x1800B6F60
	// RVA: 0x1342800 Offset: 0x1340E00 VA: 0x181342800
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870 Slot: 11
	public override long get_ContentLength() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1342D00 Offset: 0x1341300 VA: 0x181342D00 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440 Slot: 15
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x1342D20 Offset: 0x1341320 VA: 0x181342D20 Slot: 16
	public virtual string get_StatusDescription() { }

	// RVA: 0x1342720 Offset: 0x1340D20 VA: 0x181342720
	internal void ReadAll() { }

	// RVA: 0x1342680 Offset: 0x1340C80 VA: 0x181342680 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x118CF60 Offset: 0x118B560 VA: 0x18118CF60 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1342570 Offset: 0x1340B70 VA: 0x181342570 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x13423A0 Offset: 0x13409A0 VA: 0x1813423A0 Slot: 9
	public override void Close() { }

	// RVA: 0x13427B0 Offset: 0x1340DB0 VA: 0x1813427B0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x13423E0 Offset: 0x13409E0 VA: 0x1813423E0 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1342310 Offset: 0x1340910 VA: 0x181342310
	private void CheckDisposed() { }

	// RVA: 0x13423F0 Offset: 0x13409F0 VA: 0x1813423F0
	private void FillCookies() { }

	[ObsoleteAttribute] // RVA: 0xB89D0 Offset: 0xB7DD0 VA: 0x1800B89D0
	[EditorBrowsableAttribute] // RVA: 0xB89D0 Offset: 0xB7DD0 VA: 0x1800B89D0
	// RVA: 0x13427D0 Offset: 0x1340DD0 VA: 0x1813427D0
	public void .ctor() { }

}

