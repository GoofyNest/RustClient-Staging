public class PetCommandList : PrefabAttribute // TypeDefIndex: 9433
{	// Fields
	public List<PetCommandList.PetCommandDesc> Commands; // 0x98

	// Methods

	// RVA: 0x88A960 Offset: 0x888F60 VA: 0x18088A960 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x574310 Offset: 0x572910 VA: 0x180574310
	public List<PetCommandList.PetCommandDesc> GetCommandDescriptions() { }

	// RVA: 0x88A9C0 Offset: 0x888FC0 VA: 0x18088A9C0
	public void .ctor() { }

}

public struct PetCommandList.PetCommandDesc // TypeDefIndex: 9434
{	// Fields
	public PetCommandType CommandType; // 0x0
	public Translate.Phrase Title; // 0x8
	public Translate.Phrase Description; // 0x10
	public Sprite Icon; // 0x18
	public int CommandIndex; // 0x20
	public bool Raycast; // 0x24
	public int CommandWheelOrder; // 0x28

}

