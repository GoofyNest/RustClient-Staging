public class SkinSet : ScriptableObject // TypeDefIndex: 10759
{	// Fields
	public string Label; // 0x18
	public Gradient SkinColour; // 0x20
	public HairSetCollection HairCollection; // 0x28
	[HeaderAttribute] // RVA: 0x7A510 Offset: 0x79910 VA: 0x18007A510
	public GameObjectRef Head; // 0x30
	public GameObjectRef Torso; // 0x38
	public GameObjectRef Legs; // 0x40
	public GameObjectRef Feet; // 0x48
	public GameObjectRef Hands; // 0x50
	[HeaderAttribute] // RVA: 0x7A6F0 Offset: 0x79AF0 VA: 0x18007A6F0
	public GameObjectRef CensoredTorso; // 0x58
	public GameObjectRef CensoredLegs; // 0x60
	[HeaderAttribute] // RVA: 0x7A790 Offset: 0x79B90 VA: 0x18007A790
	public Material HeadMaterial; // 0x68
	public Material BodyMaterial; // 0x70
	public Material EyeMaterial; // 0x78

	// Methods

	// RVA: 0x59E680 Offset: 0x59CC80 VA: 0x18059E680
	internal Color GetSkinColor(float skinNumber) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	public void .ctor() { }

}

