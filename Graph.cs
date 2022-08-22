public abstract class Graph : MonoBehaviour // TypeDefIndex: 10933
{	// Fields
	public Material Material; // 0x18
	public int Resolution; // 0x20
	public Vector2 ScreenFill; // 0x24
	public Vector2 ScreenOrigin; // 0x2C
	public Vector2 Pivot; // 0x34
	public Rect Area; // 0x3C
	internal float CurrentValue; // 0x4C
	private int index; // 0x50
	private float[] values; // 0x58
	private float max; // 0x60

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract float GetValue();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract Color GetColor(float value);

	// RVA: 0xCA4A80 Offset: 0xCA3080 VA: 0x180CA4A80
	protected Vector3 GetVertex(float x, float y) { }

	// RVA: 0xCA4F20 Offset: 0xCA3520 VA: 0x180CA4F20
	protected void Update() { }

	// RVA: 0xCA4AB0 Offset: 0xCA30B0 VA: 0x180CA4AB0
	protected void OnGUI() { }

	// RVA: 0xCA5100 Offset: 0xCA3700 VA: 0x180CA5100
	protected void .ctor() { }

}

