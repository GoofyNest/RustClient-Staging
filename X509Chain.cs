public class X509Chain : IDisposable // TypeDefIndex: 2822
{	// Fields
	private X509ChainImpl impl; // 0x10

	// Properties
	internal X509ChainImpl Impl { get; }
	public X509ChainPolicy ChainPolicy { get; set; }
	public X509ChainStatus[] ChainStatus { get; }

	// Methods

	// RVA: 0x14D9BD0 Offset: 0x14D81D0 VA: 0x1814D9BD0
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x14D9960 Offset: 0x14D7F60 VA: 0x1814D9960
	public void .ctor() { }

	// RVA: 0x14D9810 Offset: 0x14D7E10 VA: 0x1814D9810
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x14D9AB0 Offset: 0x14D80B0 VA: 0x1814D9AB0
	public X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x14D9C40 Offset: 0x14D8240 VA: 0x1814D9C40
	public void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x14D9B40 Offset: 0x14D8140 VA: 0x1814D9B40
	public X509ChainStatus[] get_ChainStatus() { }

	[MonoTODOAttribute] // RVA: 0xB06B0 Offset: 0xAFAB0 VA: 0x1800B06B0
	// RVA: 0x14D94F0 Offset: 0x14D7AF0 VA: 0x1814D94F0
	public bool Build(X509Certificate2 certificate) { }

	// RVA: 0x14D9590 Offset: 0x14D7B90 VA: 0x1814D9590
	public static X509Chain Create() { }

	// RVA: 0x14D97A0 Offset: 0x14D7DA0 VA: 0x1814D97A0 Slot: 4
	public void Dispose() { }

	// RVA: 0x14D9710 Offset: 0x14D7D10 VA: 0x1814D9710 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E4550 Offset: 0x9E2B50 VA: 0x1809E4550 Slot: 1
	protected override void Finalize() { }

}

