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

	// RVA: 0x9D8420 Offset: 0x9D6A20 VA: 0x1809D8420
	public bool get_isVisible() { }

	// RVA: 0x9D80E0 Offset: 0x9D66E0 VA: 0x1809D80E0
	public OccludeeState Initialize(OcclusionCulling.SimpleList<OccludeeState.State> states, OcclusionCulling.BufferSet set, int slot, Vector4 sphereBounds, bool isVisible, float minTimeVisible, bool isStatic, int layer, OcclusionCulling.OnVisibilityChanged onVisibilityChanged) { }

	// RVA: 0x9D8230 Offset: 0x9D6830 VA: 0x1809D8230
	public void Invalidate() { }

	// RVA: 0x9D8300 Offset: 0x9D6900 VA: 0x1809D8300
	public void MakeVisible() { }

	// RVA: 0x9D8410 Offset: 0x9D6A10 VA: 0x1809D8410
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

	// RVA: 0x9EBFD0 Offset: 0x9EA5D0 VA: 0x1809EBFD0
	private static void .cctor() { }

}

