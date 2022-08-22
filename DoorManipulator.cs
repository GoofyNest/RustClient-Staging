public class DoorManipulator : IOEntity // TypeDefIndex: 9796
{	// Fields
	public EntityRef entityRef; // 0x288
	public Door targetDoor; // 0x298
	public DoorManipulator.DoorEffect powerAction; // 0x2A0

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 159
	public virtual bool PairWithLockedDoors() { }

	// RVA: 0xAADB20 Offset: 0xAAC120 VA: 0x180AADB20
	public void .ctor() { }

}

public enum DoorManipulator.DoorEffect // TypeDefIndex: 9797
{	// Fields
	public int value__; // 0x0
	public const DoorManipulator.DoorEffect Close = 0;
	public const DoorManipulator.DoorEffect Open = 1;
	public const DoorManipulator.DoorEffect Toggle = 2;

}

