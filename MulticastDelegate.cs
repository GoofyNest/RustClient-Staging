public abstract class MulticastDelegate : Delegate // TypeDefIndex: 377
{
[ComVisibleAttribute] // RVA: 0x760F0 Offset: 0x754F0 VA: 0x1800760F0
[Serializable]
public abstract class MulticastDelegate : Delegate // TypeDefIndex: 377
	private Delegate[] delegates; // 0x68


	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	public sealed override bool Equals(object obj) { }

	public sealed override int GetHashCode() { }

	protected override MethodInfo GetMethodImpl() { }

	public sealed override Delegate[] GetInvocationList() { }

	protected sealed override Delegate CombineImpl(Delegate follow) { }

	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	protected sealed override Delegate RemoveImpl(Delegate value) { }

}

