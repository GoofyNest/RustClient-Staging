public class MapLayerRenderer : SingletonComponent<MapLayerRenderer> // TypeDefIndex: 10949
{	// Fields
	private Nullable<int> _underwaterLabFloorCount; // 0x18
	public Camera renderCamera; // 0x20
	public CameraEvent cameraEvent; // 0x28
	public Material renderMaterial; // 0x30
	private Nullable<MapLayer> _currentlyRenderedLayer; // 0x38

	// Methods

	// RVA: 0x5663F0 Offset: 0x5649F0 VA: 0x1805663F0
	private void RenderTrainLayer() { }

	// RVA: 0x5657B0 Offset: 0x563DB0 VA: 0x1805657B0
	private CommandBuffer BuildCommandBufferTrainTunnels() { }

	// RVA: 0x5664D0 Offset: 0x564AD0 VA: 0x1805664D0
	private void RenderUnderwaterLabs(int floor) { }

	// RVA: 0x566170 Offset: 0x564770 VA: 0x180566170
	public int GetUnderwaterLabFloorCount() { }

	// RVA: 0x565AF0 Offset: 0x5640F0 VA: 0x180565AF0
	private CommandBuffer BuildCommandBufferUnderwaterLabs(int floor) { }

	// RVA: 0x5665B0 Offset: 0x564BB0 VA: 0x1805665B0
	public void Render(MapLayer layer) { }

	// RVA: 0x566320 Offset: 0x564920 VA: 0x180566320
	private void RenderImpl(CommandBuffer cb) { }

	// RVA: 0x565FA0 Offset: 0x5645A0 VA: 0x180565FA0
	public static MapLayerRenderer GetOrCreate() { }

	// RVA: 0x566650 Offset: 0x564C50 VA: 0x180566650
	public void .ctor() { }

}

private sealed class MapLayerRenderer.<>c // TypeDefIndex: 10950
{	// Fields
	public static readonly MapLayerRenderer.<>c <>9; // 0x0
	public static Func<DungeonBaseInfo, int> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x56FA30 Offset: 0x56E030 VA: 0x18056FA30
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x56EB70 Offset: 0x56D170 VA: 0x18056EB70
	internal int <GetUnderwaterLabFloorCount>b__4_0(DungeonBaseInfo l) { }

}

