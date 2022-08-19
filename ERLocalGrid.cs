public class ERLocalGrid : ScriptableObject // TypeDefIndex: 7212
{	// Fields
	public int id; // 0x18
	public string name; // 0x20
	public bool gridActive; // 0x28
	public bool gridGUIActive; // 0x29
	public Color gridColor; // 0x2C
	public float gridSize; // 0x3C
	public float gridRadius; // 0x40
	public float gridRotation; // 0x44
	public Vector3 tl; // 0x48
	public Vector3 bl; // 0x54
	public Vector3 br; // 0x60
	public float xOffset; // 0x6C
	public float yOffset; // 0x70
	public Vector3 OOCDQCOOQC; // 0x74

	// Methods

	// RVA: 0x9BA9B0 Offset: 0x9B8FB0 VA: 0x1809BA9B0
	public void Init(ERModularBase scr) { }

	// RVA: 0x9BA6C0 Offset: 0x9B8CC0 VA: 0x1809BA6C0
	public static ERLocalGrid CreateInstance(ERModularBase scr) { }

	// RVA: 0x9BA7A0 Offset: 0x9B8DA0 VA: 0x1809BA7A0
	public static string[] GridNames(ERModularBase scr) { }

	// RVA: 0x9BAA50 Offset: 0x9B9050 VA: 0x1809BAA50
	public void SetOffsets(ERModularBase scr, Vector3 pos, Vector3 v) { }

	// RVA: 0x9BAAA0 Offset: 0x9B90A0 VA: 0x1809BAAA0
	public void .ctor() { }

}

