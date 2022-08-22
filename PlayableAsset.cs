public abstract class PlayableAsset : ScriptableObject // TypeDefIndex: 3865
{	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

	// RVA: 0x18FA640 Offset: 0x18F8C40 VA: 0x1818FA640 Slot: 5
	public virtual double get_duration() { }

	// RVA: 0x18FA6A0 Offset: 0x18F8CA0 VA: 0x1818FA6A0 Slot: 6
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FA440 Offset: 0x18F8A40 VA: 0x1818FA440
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FA610 Offset: 0x18F8C10 VA: 0x1818FA610
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	protected void .ctor() { }

}

