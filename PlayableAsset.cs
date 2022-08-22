public abstract class PlayableAsset : ScriptableObject // TypeDefIndex: 3865
{	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

	// RVA: 0x18FA380 Offset: 0x18F8980 VA: 0x1818FA380 Slot: 5
	public virtual double get_duration() { }

	// RVA: 0x18FA3E0 Offset: 0x18F89E0 VA: 0x1818FA3E0 Slot: 6
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FA180 Offset: 0x18F8780 VA: 0x1818FA180
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18FA350 Offset: 0x18F8950 VA: 0x1818FA350
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	protected void .ctor() { }

}

