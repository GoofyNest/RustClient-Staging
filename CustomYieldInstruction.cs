public abstract class CustomYieldInstruction : IEnumerator // TypeDefIndex: 3511
{	// Properties
	public abstract bool keepWaiting { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_keepWaiting();

	// RVA: 0xB3BDD0 Offset: 0xB3A3D0 VA: 0x180B3BDD0 Slot: 5
	public object get_Current() { }

	// RVA: 0x82BDB0 Offset: 0x82A3B0 VA: 0x18082BDB0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 6
	public void Reset() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

