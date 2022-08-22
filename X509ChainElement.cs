public class X509ChainElement // TypeDefIndex: 2823
{	// Fields
	private X509Certificate2 certificate; // 0x10
	private X509ChainStatus[] status; // 0x18
	private string info; // 0x20
	private X509ChainStatusFlags compressed_status_flags; // 0x28

	// Properties
	public X509Certificate2 Certificate { get; }
	public X509ChainStatus[] ChainElementStatus { get; }
	internal X509ChainStatusFlags StatusFlags { get; set; }

	// Methods

	// RVA: 0x14D5870 Offset: 0x14D3E70 VA: 0x1814D5870
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public X509Certificate2 get_Certificate() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x14D31D0 Offset: 0x14D17D0 VA: 0x1814D31D0
	private int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x14D3200 Offset: 0x14D1800 VA: 0x1814D3200
	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x14D32A0 Offset: 0x14D18A0 VA: 0x1814D32A0
	internal void UncompressFlags() { }

}

