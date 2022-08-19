internal class Function : AstNode // TypeDefIndex: 1792
{	// Fields
	private Function.FunctionType functionType; // 0x10
	private ArrayList argumentList; // 0x18
	private string name; // 0x20
	private string prefix; // 0x28
	internal static XPathResultType[] ReturnTypes; // 0x0

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x12F0470 Offset: 0x12EEA70 VA: 0x1812F0470
	public void .ctor(Function.FunctionType ftype, ArrayList argumentList) { }

	// RVA: 0x12F0590 Offset: 0x12EEB90 VA: 0x1812F0590
	public void .ctor(string prefix, string name, ArrayList argumentList) { }

	// RVA: 0x12F04F0 Offset: 0x12EEAF0 VA: 0x1812F04F0
	public void .ctor(Function.FunctionType ftype, AstNode arg) { }

	// RVA: 0xE37E50 Offset: 0xE36450 VA: 0x180E37E50 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x12F0640 Offset: 0x12EEC40 VA: 0x1812F0640 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x12F0400 Offset: 0x12EEA00 VA: 0x1812F0400
	private static void .cctor() { }

}

public enum Function.FunctionType // TypeDefIndex: 1793
{	// Fields
	public int value__; // 0x0
	public const Function.FunctionType FuncLast = 0;
	public const Function.FunctionType FuncPosition = 1;
	public const Function.FunctionType FuncCount = 2;
	public const Function.FunctionType FuncID = 3;
	public const Function.FunctionType FuncLocalName = 4;
	public const Function.FunctionType FuncNameSpaceUri = 5;
	public const Function.FunctionType FuncName = 6;
	public const Function.FunctionType FuncString = 7;
	public const Function.FunctionType FuncBoolean = 8;
	public const Function.FunctionType FuncNumber = 9;
	public const Function.FunctionType FuncTrue = 10;
	public const Function.FunctionType FuncFalse = 11;
	public const Function.FunctionType FuncNot = 12;
	public const Function.FunctionType FuncConcat = 13;
	public const Function.FunctionType FuncStartsWith = 14;
	public const Function.FunctionType FuncContains = 15;
	public const Function.FunctionType FuncSubstringBefore = 16;
	public const Function.FunctionType FuncSubstringAfter = 17;
	public const Function.FunctionType FuncSubstring = 18;
	public const Function.FunctionType FuncStringLength = 19;
	public const Function.FunctionType FuncNormalize = 20;
	public const Function.FunctionType FuncTranslate = 21;
	public const Function.FunctionType FuncLang = 22;
	public const Function.FunctionType FuncSum = 23;
	public const Function.FunctionType FuncFloor = 24;
	public const Function.FunctionType FuncCeiling = 25;
	public const Function.FunctionType FuncRound = 26;
	public const Function.FunctionType FuncUserDefined = 27;

}

internal sealed class Function // TypeDefIndex: 4261
{	// Fields
	internal readonly string _name; // 0x10
	internal readonly FunctionId _id; // 0x18
	internal readonly Type _result; // 0x20
	internal readonly bool _isValidateArguments; // 0x28
	internal readonly bool _isVariantArgumentList; // 0x29
	internal readonly int _argumentCount; // 0x2C
	internal readonly Type[] _parameters; // 0x30
	internal static string[] s_functionName; // 0x0

	// Methods

	// RVA: 0x13EED00 Offset: 0x13ED300 VA: 0x1813EED00
	internal void .ctor(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

	// RVA: 0x13EDD10 Offset: 0x13EC310 VA: 0x1813EDD10
	private static void .cctor() { }

}
