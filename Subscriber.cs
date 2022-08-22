public class Subscriber : Pool.IPooled // TypeDefIndex: 6707
{	// Fields
	internal Manager manager; // 0x10
	internal Connection connection; // 0x18
	public ListHashSet<Group> subscribed; // 0x20

	// Methods

	// RVA: 0x22152E0 Offset: 0x22138E0 VA: 0x1822152E0
	public Group Subscribe(Group group) { }

	// RVA: 0x22152A0 Offset: 0x22138A0 VA: 0x1822152A0
	public Group Subscribe(uint group) { }

	// RVA: 0x2215240 Offset: 0x2213840 VA: 0x182215240
	public bool IsSubscribed(Group group) { }

	// RVA: 0x22153D0 Offset: 0x22139D0 VA: 0x1822153D0
	public void UnsubscribeAll() { }

	// RVA: 0x2215540 Offset: 0x2213B40 VA: 0x182215540
	public void Unsubscribe(Group group) { }

	// RVA: 0x22151F0 Offset: 0x22137F0 VA: 0x1822151F0
	public void Destroy() { }

	// RVA: 0x2215200 Offset: 0x2213800 VA: 0x182215200 Slot: 4
	public void EnterPool() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	public void LeavePool() { }

	// RVA: 0x22155D0 Offset: 0x2213BD0 VA: 0x1822155D0
	public void .ctor() { }

}

