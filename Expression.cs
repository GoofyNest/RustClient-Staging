public abstract class Expression // TypeDefIndex: 3239
{	// Fields
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache; // 0x0
	private static ConditionalWeakTable<Expression, Expression.ExtensionInfo> s_legacyCtorSupportTable; // 0x8

	// Properties
	public virtual ExpressionType NodeType { get; }

	// Methods

	// RVA: 0x222A790 Offset: 0x2228D90 VA: 0x18222A790 Slot: 4
	public virtual ExpressionType get_NodeType() { }

	// RVA: 0x222A720 Offset: 0x2228D20 VA: 0x18222A720
	private static void .cctor() { }

}

private class Expression.ExtensionInfo // TypeDefIndex: 3242
{
// Namespace: 
internal class Expression.MemberExpressionProxy // TypeDefIndex: 3241

// Namespace: 
private class Expression.ExtensionInfo // TypeDefIndex: 3242
	// Fields
	internal readonly ExpressionType NodeType; // 0x10

}

