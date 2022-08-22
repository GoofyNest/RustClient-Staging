public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 4762
{
[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
[Serializable]
public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 4762

	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	protected void .ctor() { }

}

