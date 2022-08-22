public abstract class MulticastDelegate : Delegate // TypeDefIndex: 377
{
// Namespace: System
[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
[Serializable]
public abstract class MulticastDelegate : Delegate // TypeDefIndex: 377
	// Fields
	private Delegate[] delegates; // 0x68

	// Methods

	// RVA: 0x1677220 Offset: 0x1675820 VA: 0x181677220 Slot: 8
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1676F50 Offset: 0x1675550 VA: 0x181676F50 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x16770D0 Offset: 0x16756D0 VA: 0x1816770D0 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: 0x16771D0 Offset: 0x16757D0 VA: 0x1816771D0 Slot: 7
	protected override MethodInfo GetMethodImpl() { }

	// RVA: 0x16770E0 Offset: 0x16756E0 VA: 0x1816770E0 Slot: 9
	public sealed override Delegate[] GetInvocationList() { }

	// RVA: 0x1676B90 Offset: 0x1675190 VA: 0x181676B90 Slot: 10
	protected sealed override Delegate CombineImpl(Delegate follow) { }

	// RVA: 0x1677240 Offset: 0x1675840 VA: 0x181677240
	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	// RVA: 0x16773B0 Offset: 0x16759B0 VA: 0x1816773B0 Slot: 11
	protected sealed override Delegate RemoveImpl(Delegate value) { }

}

