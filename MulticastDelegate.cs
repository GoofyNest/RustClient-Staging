public abstract class MulticastDelegate : Delegate // TypeDefIndex: 377
{
// Namespace: System
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
[Serializable]
public abstract class MulticastDelegate : Delegate // TypeDefIndex: 377
	// Fields
	private Delegate[] delegates; // 0x68

	// Methods

	// RVA: 0x1679630 Offset: 0x1677C30 VA: 0x181679630 Slot: 8
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1679360 Offset: 0x1677960 VA: 0x181679360 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x16794E0 Offset: 0x1677AE0 VA: 0x1816794E0 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: 0x16795E0 Offset: 0x1677BE0 VA: 0x1816795E0 Slot: 7
	protected override MethodInfo GetMethodImpl() { }

	// RVA: 0x16794F0 Offset: 0x1677AF0 VA: 0x1816794F0 Slot: 9
	public sealed override Delegate[] GetInvocationList() { }

	// RVA: 0x1678FA0 Offset: 0x16775A0 VA: 0x181678FA0 Slot: 10
	protected sealed override Delegate CombineImpl(Delegate follow) { }

	// RVA: 0x1679650 Offset: 0x1677C50 VA: 0x181679650
	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	// RVA: 0x16797C0 Offset: 0x1677DC0 VA: 0x1816797C0 Slot: 11
	protected sealed override Delegate RemoveImpl(Delegate value) { }

}

