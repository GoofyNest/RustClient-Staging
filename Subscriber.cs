public class Subscriber : Pool.IPooled // TypeDefIndex: 6707
{	// Fields
	internal Manager manager; // 0x10
	internal Connection connection; // 0x18
	public ListHashSet<Group> subscribed; // 0x20

	// Methods

	// RVA: 0x2214800 Offset: 0x2212E00 VA: 0x182214800
	public Group Subscribe(Group group) { }

	// RVA: 0x22147C0 Offset: 0x2212DC0 VA: 0x1822147C0
	public Group Subscribe(uint group) { }

	// RVA: 0x2214760 Offset: 0x2212D60 VA: 0x182214760
	public bool IsSubscribed(Group group) { }

	// RVA: 0x22148F0 Offset: 0x2212EF0 VA: 0x1822148F0
	public void UnsubscribeAll() { }

	// RVA: 0x2214A60 Offset: 0x2213060 VA: 0x182214A60
	public void Unsubscribe(Group group) { }

	// RVA: 0x2214710 Offset: 0x2212D10 VA: 0x182214710
	public void Destroy() { }

	// RVA: 0x2214720 Offset: 0x2212D20 VA: 0x182214720 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2214AF0 Offset: 0x22130F0 VA: 0x182214AF0
	public void .ctor() { }

}

