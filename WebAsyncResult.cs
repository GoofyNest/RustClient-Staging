internal class WebAsyncResult : SimpleAsyncResult // TypeDefIndex: 3025
{	// Fields
	private int nbytes; // 0x50
	private IAsyncResult innerAsyncResult; // 0x58
	private HttpWebResponse response; // 0x60
	private Stream writeStream; // 0x68
	private byte[] buffer; // 0x70
	private int offset; // 0x78
	private int size; // 0x7C
	public bool EndCalled; // 0x80
	public bool AsyncWriteAll; // 0x81
	public HttpWebRequest AsyncObject; // 0x88

	// Properties
	internal int NBytes { get; set; }
	internal IAsyncResult InnerAsyncResult { get; set; }
	internal Stream WriteStream { get; }
	internal HttpWebResponse Response { get; }
	internal byte[] Buffer { get; }
	internal int Offset { get; }
	internal int Size { get; }

	// Methods

	// RVA: 0x100FF20 Offset: 0x100E520 VA: 0x18100FF20
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x100FEE0 Offset: 0x100E4E0 VA: 0x18100FEE0
	public void .ctor(HttpWebRequest request, AsyncCallback cb, object state) { }

	// RVA: 0x100FEA0 Offset: 0x100E4A0 VA: 0x18100FEA0
	public void .ctor(AsyncCallback cb, object state, byte[] buffer, int offset, int size) { }

	// RVA: 0x100FDC0 Offset: 0x100E3C0 VA: 0x18100FDC0
	internal void Reset() { }

	// RVA: 0x100FE10 Offset: 0x100E410 VA: 0x18100FE10
	internal void SetCompleted(bool synch, int nbytes) { }

	// RVA: 0x100FE20 Offset: 0x100E420 VA: 0x18100FE20
	internal void SetCompleted(bool synch, Stream writeStream) { }

	// RVA: 0x100FE60 Offset: 0x100E460 VA: 0x18100FE60
	internal void SetCompleted(bool synch, HttpWebResponse response) { }

	// RVA: 0xFFF7F0 Offset: 0xFFDDF0 VA: 0x180FFF7F0
	internal void DoCallback() { }

	// RVA: 0x8D8F00 Offset: 0x8D7500 VA: 0x1808D8F00
	internal int get_NBytes() { }

	// RVA: 0x8D8F40 Offset: 0x8D7540 VA: 0x1808D8F40
	internal void set_NBytes(int value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal IAsyncResult get_InnerAsyncResult() { }

	// RVA: 0x4CF880 Offset: 0x4CDE80 VA: 0x1804CF880
	internal void set_InnerAsyncResult(IAsyncResult value) { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50
	internal Stream get_WriteStream() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal HttpWebResponse get_Response() { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0
	internal byte[] get_Buffer() { }

	// RVA: 0xAF5D60 Offset: 0xAF4360 VA: 0x180AF5D60
	internal int get_Offset() { }

	// RVA: 0x100FF30 Offset: 0x100E530 VA: 0x18100FF30
	internal int get_Size() { }

}

