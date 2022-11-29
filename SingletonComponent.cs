public abstract class SingletonComponent : FacepunchBehaviour // TypeDefIndex: 5601
{

	public abstract void SingletonSetup();

	public abstract void SingletonClear();

	protected virtual void Awake() { }

	protected virtual void OnDestroy() { }

	public static void InitializeSingletons(GameObject go) { }

	protected void .ctor() { }

}

