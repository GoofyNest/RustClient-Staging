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

	// RVA: 0x1010C80 Offset: 0x100F280 VA: 0x181010C80
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x1010C40 Offset: 0x100F240 VA: 0x181010C40
	public void .ctor(HttpWebRequest request, AsyncCallback cb, object state) { }

	// RVA: 0x1010C00 Offset: 0x100F200 VA: 0x181010C00
	public void .ctor(AsyncCallback cb, object state, byte[] buffer, int offset, int size) { }

	// RVA: 0x1010B20 Offset: 0x100F120 VA: 0x181010B20
	internal void Reset() { }

	// RVA: 0x1010B70 Offset: 0x100F170 VA: 0x181010B70
	internal void SetCompleted(bool synch, int nbytes) { }

	// RVA: 0x1010B80 Offset: 0x100F180 VA: 0x181010B80
	internal void SetCompleted(bool synch, Stream writeStream) { }

	// RVA: 0x1010BC0 Offset: 0x100F1C0 VA: 0x181010BC0
	internal void SetCompleted(bool synch, HttpWebResponse response) { }

	// RVA: 0x1000550 Offset: 0xFFEB50 VA: 0x181000550
	internal void DoCallback() { }

	// RVA: 0x8D9520 Offset: 0x8D7B20 VA: 0x1808D9520
	internal int get_NBytes() { }

	// RVA: 0x8D9560 Offset: 0x8D7B60 VA: 0x1808D9560
	internal void set_NBytes(int value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	internal IAsyncResult get_InnerAsyncResult() { }

	// RVA: 0x4CF810 Offset: 0x4CDE10 VA: 0x1804CF810
	internal void set_InnerAsyncResult(IAsyncResult value) { }

	// RVA: 0x519BE0 Offset: 0x5181E0 VA: 0x180519BE0
	internal Stream get_WriteStream() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	internal HttpWebResponse get_Response() { }

	// RVA: 0x574360 Offset: 0x572960 VA: 0x180574360
	internal byte[] get_Buffer() { }

	// RVA: 0xAF64F0 Offset: 0xAF4AF0 VA: 0x180AF64F0
	internal int get_Offset() { }

	// RVA: 0x1010C90 Offset: 0x100F290 VA: 0x181010C90
	internal int get_Size() { }

}

