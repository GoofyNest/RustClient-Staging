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

	// RVA: 0x10101E0 Offset: 0x100E7E0 VA: 0x1810101E0
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x10101A0 Offset: 0x100E7A0 VA: 0x1810101A0
	public void .ctor(HttpWebRequest request, AsyncCallback cb, object state) { }

	// RVA: 0x1010160 Offset: 0x100E760 VA: 0x181010160
	public void .ctor(AsyncCallback cb, object state, byte[] buffer, int offset, int size) { }

	// RVA: 0x1010080 Offset: 0x100E680 VA: 0x181010080
	internal void Reset() { }

	// RVA: 0x10100D0 Offset: 0x100E6D0 VA: 0x1810100D0
	internal void SetCompleted(bool synch, int nbytes) { }

	// RVA: 0x10100E0 Offset: 0x100E6E0 VA: 0x1810100E0
	internal void SetCompleted(bool synch, Stream writeStream) { }

	// RVA: 0x1010120 Offset: 0x100E720 VA: 0x181010120
	internal void SetCompleted(bool synch, HttpWebResponse response) { }

	// RVA: 0xFFFAB0 Offset: 0xFFE0B0 VA: 0x180FFFAB0
	internal void DoCallback() { }

	// RVA: 0x8D9010 Offset: 0x8D7610 VA: 0x1808D9010
	internal int get_NBytes() { }

	// RVA: 0x8D9050 Offset: 0x8D7650 VA: 0x1808D9050
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

	// RVA: 0xAF6020 Offset: 0xAF4620 VA: 0x180AF6020
	internal int get_Offset() { }

	// RVA: 0x10101F0 Offset: 0x100E7F0 VA: 0x1810101F0
	internal int get_Size() { }

}

