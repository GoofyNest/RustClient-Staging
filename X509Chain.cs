public class X509Chain : IDisposable // TypeDefIndex: 2822
{	// Fields
	private X509ChainImpl impl; // 0x10

	// Properties
	internal X509ChainImpl Impl { get; }
	public X509ChainPolicy ChainPolicy { get; set; }
	public X509ChainStatus[] ChainStatus { get; }

	// Methods

	// RVA: 0x14D8F60 Offset: 0x14D7560 VA: 0x1814D8F60
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x14D8CF0 Offset: 0x14D72F0 VA: 0x1814D8CF0
	public void .ctor() { }

	// RVA: 0x14D8BA0 Offset: 0x14D71A0 VA: 0x1814D8BA0
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x14D8E40 Offset: 0x14D7440 VA: 0x1814D8E40
	public X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x14D8FD0 Offset: 0x14D75D0 VA: 0x1814D8FD0
	public void set_ChainPolicy(X509ChainPolicy value) { }

	// RVA: 0x14D8ED0 Offset: 0x14D74D0 VA: 0x1814D8ED0
	public X509ChainStatus[] get_ChainStatus() { }

	[MonoTODOAttribute] // RVA: 0xB06A0 Offset: 0xAFAA0 VA: 0x1800B06A0
	// RVA: 0x14D8880 Offset: 0x14D6E80 VA: 0x1814D8880
	public bool Build(X509Certificate2 certificate) { }

	// RVA: 0x14D8920 Offset: 0x14D6F20 VA: 0x1814D8920
	public static X509Chain Create() { }

	// RVA: 0x14D8B30 Offset: 0x14D7130 VA: 0x1814D8B30 Slot: 4
	public void Dispose() { }

	// RVA: 0x14D8AA0 Offset: 0x14D70A0 VA: 0x1814D8AA0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x9E4D00 Offset: 0x9E3300 VA: 0x1809E4D00 Slot: 1
	protected override void Finalize() { }

}

