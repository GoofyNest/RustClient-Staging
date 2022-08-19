public class Subscriber : Pool.IPooled // TypeDefIndex: 6707
{	// Fields
	internal Manager manager; // 0x10
	internal Connection connection; // 0x18
	public ListHashSet<Group> subscribed; // 0x20

	// Methods

	// RVA: 0x22149C0 Offset: 0x2212FC0 VA: 0x1822149C0
	public Group Subscribe(Group group) { }

	// RVA: 0x2214980 Offset: 0x2212F80 VA: 0x182214980
	public Group Subscribe(uint group) { }

	// RVA: 0x2214920 Offset: 0x2212F20 VA: 0x182214920
	public bool IsSubscribed(Group group) { }

	// RVA: 0x2214AB0 Offset: 0x22130B0 VA: 0x182214AB0
	public void UnsubscribeAll() { }

	// RVA: 0x2214C20 Offset: 0x2213220 VA: 0x182214C20
	public void Unsubscribe(Group group) { }

	// RVA: 0x22148D0 Offset: 0x2212ED0 VA: 0x1822148D0
	public void Destroy() { }

	// RVA: 0x22148E0 Offset: 0x2212EE0 VA: 0x1822148E0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2214CB0 Offset: 0x22132B0 VA: 0x182214CB0
	public void .ctor() { }

}

