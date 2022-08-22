public abstract class PlayableAsset : ScriptableObject // TypeDefIndex: 3865
{	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

	// RVA: 0x18F9D60 Offset: 0x18F8360 VA: 0x1818F9D60 Slot: 5
	public virtual double get_duration() { }

	// RVA: 0x18F9DC0 Offset: 0x18F83C0 VA: 0x1818F9DC0 Slot: 6
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F9B60 Offset: 0x18F8160 VA: 0x1818F9B60
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F9D30 Offset: 0x18F8330 VA: 0x1818F9D30
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	protected void .ctor() { }

}

