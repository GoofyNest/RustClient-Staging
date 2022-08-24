public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 4762
{
[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
[Serializable]
public abstract class VFXSpawnerCallbacks : ScriptableObject // TypeDefIndex: 4762

	public abstract void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	public abstract void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	public abstract void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent);

	protected void .ctor() { }

}

