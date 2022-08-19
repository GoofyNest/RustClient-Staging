public class OccludeeState : OcclusionCulling.SmartListValue // TypeDefIndex: 11509
{	// Fields
	public int slot; // 0x18
	public bool isStatic; // 0x1C
	public int layer; // 0x20
	public OcclusionCulling.OnVisibilityChanged onVisibilityChanged; // 0x28
	public OcclusionCulling.Cell cell; // 0x30
	public OcclusionCulling.SimpleList<OccludeeState.State> states; // 0x38

	// Properties
	public bool isVisible { get; }

	// Methods

	// RVA: 0x9D7C70 Offset: 0x9D6270 VA: 0x1809D7C70
	public bool get_isVisible() { }

	// RVA: 0x9D7930 Offset: 0x9D5F30 VA: 0x1809D7930
	public OccludeeState Initialize(OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.BufferSet set, int slot, Vector4 sphereBounds, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged) { }

	// RVA: 0x9D7A80 Offset: 0x9D6080 VA: 0x1809D7A80
	public void Invalidate() { }

	// RVA: 0x9D7B50 Offset: 0x9D6150 VA: 0x1809D7B50
	public void MakeVisible() { }

	// RVA: 0x9D7C60 Offset: 0x9D6260 VA: 0x1809D7C60
	public void .ctor() { }

}

public struct OccludeeState.State // TypeDefIndex: 11510
{	// Fields
	public Vector4 sphereBounds; // 0x0
	public float minTimeVisible; // 0x10
	public float waitTime; // 0x14
	public uint waitFrame; // 0x18
	public byte isVisible; // 0x1C
	public byte active; // 0x1D
	public byte callback; // 0x1E
	public byte pad1; // 0x1F
	public static OccludeeState.State Unused; // 0x0

	// Methods

	// RVA: 0x9EB820 Offset: 0x9E9E20 VA: 0x1809EB820
	private static void .cctor() { }

}

