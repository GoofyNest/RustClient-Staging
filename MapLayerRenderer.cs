public class MapLayerRenderer : SingletonComponent<MapLayerRenderer> // TypeDefIndex: 10949
{	// Fields
	private Nullable<int> _underwaterLabFloorCount; // 0x18
	public Camera renderCamera; // 0x20
	public CameraEvent cameraEvent; // 0x28
	public Material renderMaterial; // 0x30
	private Nullable<MapLayer> _currentlyRenderedLayer; // 0x38

	// Methods

	// RVA: 0x566380 Offset: 0x564980 VA: 0x180566380
	private void RenderTrainLayer() { }

	// RVA: 0x565740 Offset: 0x563D40 VA: 0x180565740
	private CommandBuffer BuildCommandBufferTrainTunnels() { }

	// RVA: 0x566460 Offset: 0x564A60 VA: 0x180566460
	private void RenderUnderwaterLabs(int floor) { }

	// RVA: 0x566100 Offset: 0x564700 VA: 0x180566100
	public int GetUnderwaterLabFloorCount() { }

	// RVA: 0x565A80 Offset: 0x564080 VA: 0x180565A80
	private CommandBuffer BuildCommandBufferUnderwaterLabs(int floor) { }

	// RVA: 0x566540 Offset: 0x564B40 VA: 0x180566540
	public void Render(MapLayer layer) { }

	// RVA: 0x5662B0 Offset: 0x5648B0 VA: 0x1805662B0
	private void RenderImpl(CommandBuffer cb) { }

	// RVA: 0x565F30 Offset: 0x564530 VA: 0x180565F30
	public static MapLayerRenderer GetOrCreate() { }

	// RVA: 0x5665E0 Offset: 0x564BE0 VA: 0x1805665E0
	public void .ctor() { }

}

private sealed class MapLayerRenderer.<>c // TypeDefIndex: 10950
{	// Fields
	public static readonly MapLayerRenderer.<>c <>9; // 0x0
	public static Func<DungeonBaseInfo, int> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x56F9C0 Offset: 0x56DFC0 VA: 0x18056F9C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x56EB00 Offset: 0x56D100 VA: 0x18056EB00
	internal int <GetUnderwaterLabFloorCount>b__4_0(DungeonBaseInfo l) { }

}

