public class SkinSet : ScriptableObject // TypeDefIndex: 10763
{	public string Label; // 0x18
	public Gradient SkinColour; // 0x20
	public HairSetCollection HairCollection; // 0x28
	[HeaderAttribute] // RVA: 0x7A7E0 Offset: 0x79BE0 VA: 0x18007A7E0
	public GameObjectRef Head; // 0x30
	public GameObjectRef Torso; // 0x38
	public GameObjectRef Legs; // 0x40
	public GameObjectRef Feet; // 0x48
	public GameObjectRef Hands; // 0x50
	[HeaderAttribute] // RVA: 0x7A870 Offset: 0x79C70 VA: 0x18007A870
	public GameObjectRef CensoredTorso; // 0x58
	public GameObjectRef CensoredLegs; // 0x60
	[HeaderAttribute] // RVA: 0x7AA50 Offset: 0x79E50 VA: 0x18007AA50
	public Material HeadMaterial; // 0x68
	public Material BodyMaterial; // 0x70
	public Material EyeMaterial; // 0x78


	internal Color GetSkinColor(float skinNumber) { }

	public void .ctor() { }

}

