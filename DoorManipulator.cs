public class DoorManipulator : IOEntity // TypeDefIndex: 11499
{
	public EntityRef entityRef; 
	public Door targetDoor; 
	public DoorManipulator.DoorEffect powerAction; 


	public virtual bool PairWithLockedDoors() { }

	public void .ctor() { }

}

public enum DoorManipulator.DoorEffect // TypeDefIndex: 11500
{
	public int value__; 
	public const DoorManipulator.DoorEffect Close = 0;
	public const DoorManipulator.DoorEffect Open = 1;
	public const DoorManipulator.DoorEffect Toggle = 2;

}

