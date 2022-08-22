public class DoorManipulator : IOEntity // TypeDefIndex: 9796
{	// Fields
	public EntityRef entityRef; // 0x288
	public Door targetDoor; // 0x298
	public DoorManipulator.DoorEffect powerAction; // 0x2A0

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 159
	public virtual bool PairWithLockedDoors() { }

	// RVA: 0xAAD650 Offset: 0xAABC50 VA: 0x180AAD650
	public void .ctor() { }

}

public enum DoorManipulator.DoorEffect // TypeDefIndex: 9797
{	// Fields
	public int value__; // 0x0
	public const DoorManipulator.DoorEffect Close = 0;
	public const DoorManipulator.DoorEffect Open = 1;
	public const DoorManipulator.DoorEffect Toggle = 2;

}

