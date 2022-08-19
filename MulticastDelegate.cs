public abstract class MulticastDelegate : Delegate // TypeDefIndex: 377
{
// Namespace: System
[ComVisibleAttribute] // RVA: 0x75F80 Offset: 0x75380 VA: 0x180075F80
[Serializable]
public abstract class MulticastDelegate : Delegate // TypeDefIndex: 377
	// Fields
	private Delegate[] delegates; // 0x68

	// Methods

	// RVA: 0x1679370 Offset: 0x1677970 VA: 0x181679370 Slot: 8
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x16790A0 Offset: 0x16776A0 VA: 0x1816790A0 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x1679220 Offset: 0x1677820 VA: 0x181679220 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: 0x1679320 Offset: 0x1677920 VA: 0x181679320 Slot: 7
	protected override MethodInfo GetMethodImpl() { }

	// RVA: 0x1679230 Offset: 0x1677830 VA: 0x181679230 Slot: 9
	public sealed override Delegate[] GetInvocationList() { }

	// RVA: 0x1678CE0 Offset: 0x16772E0 VA: 0x181678CE0 Slot: 10
	protected sealed override Delegate CombineImpl(Delegate follow) { }

	// RVA: 0x1679390 Offset: 0x1677990 VA: 0x181679390
	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	// RVA: 0x1679500 Offset: 0x1677B00 VA: 0x181679500 Slot: 11
	protected sealed override Delegate RemoveImpl(Delegate value) { }

}

