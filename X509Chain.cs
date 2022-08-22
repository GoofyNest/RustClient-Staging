public class X509Chain : IDisposable // TypeDefIndex: 2822
{	// Fields
	private X509ChainImpl impl; // 0x10

	// Properties
	internal X509ChainImpl Impl { get; }
	public X509ChainPolicy ChainPolicy { get; set; }
	public X509ChainStatus[] ChainStatus { get; }

	// Methods

	// RVA: 0x14D9E90 Offset: 0x14D8490 VA: 0x1814D9E90
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x14D9C20 Offset: 0x14D8220 VA: 0x1814D9C20
	public void .ctor() { }

	// RVA: 0x14D9AD0 Offset: 0x14D80D0 VA: 0x1814D9AD0
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x14D9D70 Offset: 0x14D8370 VA: 0x1814D9D70
	public X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x14D9F00 Offset: 0x14D8500 VA: 0x1814D9F00
	public void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x14D9E00 Offset: 0x14D8400 VA: 0x1814D9E00
	public X509ChainStatus[] get_ChainStatus() { }

	[MonoTODOAttribute] // RVA: 0xB06A0 Offset: 0xAFAA0 VA: 0x1800B06A0
	// RVA: 0x14D97B0 Offset: 0x14D7DB0 VA: 0x1814D97B0
	public bool Build(X509Certificate2 certificate) { }

	// RVA: 0x14D9850 Offset: 0x14D7E50 VA: 0x1814D9850
	public static X509Chain Create() { }

	// RVA: 0x14D9A60 Offset: 0x14D8060 VA: 0x1814D9A60 Slot: 4
	public void Dispose() { }

	// RVA: 0x14D99D0 Offset: 0x14D7FD0 VA: 0x1814D99D0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E4810 Offset: 0x9E2E10 VA: 0x1809E4810 Slot: 1
	protected override void Finalize() { }

}

