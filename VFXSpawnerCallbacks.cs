public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 4762
{
// Namespace: UnityEngine.VFX
[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
[Serializable]
public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 4762
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	// RVA: 0x4C3A70 Offset: 0x4C2070 VA: 0x1804C3A70
	protected void .ctor() { }

}

