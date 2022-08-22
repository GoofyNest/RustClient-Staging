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

	// RVA: 0x9BB160 Offset: 0x9B9760 VA: 0x1809BB160
	public void Init(ERModularBase scr) { }

	// RVA: 0x9BAE70 Offset: 0x9B9470 VA: 0x1809BAE70
	public static ERLocalGrid CreateInstance(ERModularBase scr) { }

	// RVA: 0x9BAF50 Offset: 0x9B9550 VA: 0x1809BAF50
	public static string[] GridNames(ERModularBase scr) { }

	// RVA: 0x9BB200 Offset: 0x9B9800 VA: 0x1809BB200
	public void SetOffsets(ERModularBase scr, Vector3 pos, Vector3 v) { }

	// RVA: 0x9BB250 Offset: 0x9B9850 VA: 0x1809BB250
	public void .ctor() { }

}

