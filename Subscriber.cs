public class Subscriber : Pool.IPooled // TypeDefIndex: 6707
{	// Fields
	internal Manager manager; // 0x10
	internal Connection connection; // 0x18
	public ListHashSet<Group> subscribed; // 0x20

	// Methods

	// RVA: 0x2214AC0 Offset: 0x22130C0 VA: 0x182214AC0
	public Group Subscribe(Group group) { }

	// RVA: 0x2214A80 Offset: 0x2213080 VA: 0x182214A80
	public Group Subscribe(uint group) { }

	// RVA: 0x2214A20 Offset: 0x2213020 VA: 0x182214A20
	public bool IsSubscribed(Group group) { }

	// RVA: 0x2214BB0 Offset: 0x22131B0 VA: 0x182214BB0
	public void UnsubscribeAll() { }

	// RVA: 0x2214D20 Offset: 0x2213320 VA: 0x182214D20
	public void Unsubscribe(Group group) { }

	// RVA: 0x22149D0 Offset: 0x2212FD0 VA: 0x1822149D0
	public void Destroy() { }

	// RVA: 0x22149E0 Offset: 0x2212FE0 VA: 0x1822149E0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2214DB0 Offset: 0x22133B0 VA: 0x182214DB0
	public void .ctor() { }

}

