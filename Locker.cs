public class Locker : StorageContainer // TypeDefIndex: 8598
{	// Fields
	public GameObjectRef equipSound; // 0x3D0
	private const int maxGearSets = 3;
	private const int attireSize = 7;
	private const int beltSize = 6;
	private const int columnSize = 2;
	private Item[] clothingBuffer; // 0x3D8
	private const int setSize = 13;

	// Methods

	// RVA: 0x4FF740 Offset: 0x4FDD40 VA: 0x1804FF740 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool IsEquipping() { }

	// RVA: 0x4FF710 Offset: 0x4FDD10 VA: 0x1804FF710
	private Locker.RowType GetRowType(int slot) { }

	// RVA: 0x4FF580 Offset: 0x4FDB80 VA: 0x1804FF580 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x4FF520 Offset: 0x4FDB20 VA: 0x1804FF520
	public void EquipFromIndex(int index) { }

	// RVA: 0x4FF830 Offset: 0x4FDE30 VA: 0x1804FF830
	public void .ctor() { }

}

private enum Locker.RowType // TypeDefIndex: 8599
{	// Fields
	public int value__; // 0x0
	public const Locker.RowType Clothing = 0;
	public const Locker.RowType Belt = 1;

}

public static class Locker.LockerFlags // TypeDefIndex: 8600
{	// Fields
	public const BaseEntity.Flags IsEquipping = 128;

}

