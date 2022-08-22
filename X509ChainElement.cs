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

	// RVA: 0x14D4940 Offset: 0x14D2F40 VA: 0x1814D4940
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public X509Certificate2 get_Certificate() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x79C680 Offset: 0x79AC80 VA: 0x18079C680
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x14D22A0 Offset: 0x14D08A0 VA: 0x1814D22A0
	private int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x14D22D0 Offset: 0x14D08D0 VA: 0x1814D22D0
	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x14D2370 Offset: 0x14D0970 VA: 0x1814D2370
	internal void UncompressFlags() { }

}

