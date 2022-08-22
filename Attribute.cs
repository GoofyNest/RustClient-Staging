public abstract class Attribute // TypeDefIndex: 174
{	// Properties
	public virtual object TypeId { get; }

	// Methods

	// RVA: 0x155DD50 Offset: 0x155C350 VA: 0x18155DD50
	private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit) { }

	// RVA: 0x155DCB0 Offset: 0x155C2B0 VA: 0x18155DCB0
	private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit) { }

	// RVA: 0x155DEF0 Offset: 0x155C4F0 VA: 0x18155DEF0
	private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit) { }

	// RVA: 0x155DDF0 Offset: 0x155C3F0 VA: 0x18155DDF0
	private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155DE70 Offset: 0x155C470 VA: 0x18155DE70
	private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155C9C0 Offset: 0x155AFC0 VA: 0x18155C9C0
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type) { }

	// RVA: 0x155CE50 Offset: 0x155B450 VA: 0x18155CE50
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit) { }

	// RVA: 0x155D130 Offset: 0x155B730 VA: 0x18155D130
	public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit) { }

	// RVA: 0x155E6A0 Offset: 0x155CCA0 VA: 0x18155E6A0
	public static bool IsDefined(MemberInfo element, Type attributeType) { }

	// RVA: 0x155E380 Offset: 0x155C980 VA: 0x18155E380
	public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155C850 Offset: 0x155AE50 VA: 0x18155C850
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	// RVA: 0x155C6E0 Offset: 0x155ACE0 VA: 0x18155C6E0
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155D460 Offset: 0x155BA60 VA: 0x18155D460
	public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit) { }

	// RVA: 0x155D940 Offset: 0x155BF40 VA: 0x18155D940
	public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit) { }

	// RVA: 0x155D810 Offset: 0x155BE10 VA: 0x18155D810
	public static Attribute[] GetCustomAttributes(Module element, bool inherit) { }

	// RVA: 0x155CC00 Offset: 0x155B200 VA: 0x18155CC00
	public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit) { }

	// RVA: 0x155DAE0 Offset: 0x155C0E0 VA: 0x18155DAE0
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType) { }

	// RVA: 0x155C9D0 Offset: 0x155AFD0 VA: 0x18155C9D0
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x155D710 Offset: 0x155BD10 VA: 0x18155D710
	public static Attribute[] GetCustomAttributes(Assembly element) { }

	// RVA: 0x155D350 Offset: 0x155B950 VA: 0x18155D350
	public static Attribute[] GetCustomAttributes(Assembly element, bool inherit) { }

	// RVA: 0x155C7A0 Offset: 0x155ADA0 VA: 0x18155C7A0
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	// RVA: 0x155C900 Offset: 0x155AF00 VA: 0x18155C900
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x155C3B0 Offset: 0x155A9B0 VA: 0x18155C3B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x155C1A0 Offset: 0x155A7A0 VA: 0x18155C1A0
	private static bool AreFieldValuesEqual(object thisValue, object thatValue) { }

	// RVA: 0x155DAF0 Offset: 0x155C0F0 VA: 0x18155DAF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10DC960 Offset: 0x10DAF60 VA: 0x1810DC960 Slot: 4
	public virtual object get_TypeId() { }

	// RVA: 0x155E6B0 Offset: 0x155CCB0 VA: 0x18155E6B0 Slot: 5
	public virtual bool Match(object obj) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 6
	public virtual bool IsDefaultAttribute() { }

}

public enum AttributeTargets // TypeDefIndex: 175
{	// Fields
	public int value__; // 0x0
	public const AttributeTargets Assembly = 1;
	public const AttributeTargets Module = 2;
	public const AttributeTargets Class = 4;
	public const AttributeTargets Struct = 8;
	public const AttributeTargets Enum = 16;
	public const AttributeTargets Constructor = 32;
	public const AttributeTargets Method = 64;
	public const AttributeTargets Property = 128;
	public const AttributeTargets Field = 256;
	public const AttributeTargets Event = 512;
	public const AttributeTargets Interface = 1024;
	public const AttributeTargets Parameter = 2048;
	public const AttributeTargets Delegate = 4096;
	public const AttributeTargets ReturnValue = 8192;
	public const AttributeTargets GenericParameter = 16384;
	public const AttributeTargets All = 32767;

}

public sealed class AttributeUsageAttribute : Attribute // TypeDefIndex: 176
{	// Fields
	internal AttributeTargets m_attributeTarget; // 0x10
	internal bool m_allowMultiple; // 0x14
	internal bool m_inherited; // 0x15
	internal static AttributeUsageAttribute Default; // 0x0

	// Properties
	public bool AllowMultiple { get; set; }
	public bool Inherited { get; set; }

	// Methods

	// RVA: 0x155C160 Offset: 0x155A760 VA: 0x18155C160
	public void .ctor(AttributeTargets validOn) { }

	// RVA: 0xA110C0 Offset: 0xA0F6C0 VA: 0x180A110C0
	public bool get_AllowMultiple() { }

	// RVA: 0xA110E0 Offset: 0xA0F6E0 VA: 0x180A110E0
	public void set_AllowMultiple(bool value) { }

	// RVA: 0x13A5690 Offset: 0x13A3C90 VA: 0x1813A5690
	public bool get_Inherited() { }

	// RVA: 0x155C190 Offset: 0x155A790 VA: 0x18155C190
	public void set_Inherited(bool value) { }

	// RVA: 0x155C0F0 Offset: 0x155A6F0 VA: 0x18155C0F0
	private static void .cctor() { }

}

internal enum AttributeProperties // TypeDefIndex: 1863
{	// Fields
	public uint value__; // 0x0
	public const AttributeProperties DEFAULT = 0;
	public const AttributeProperties URI = 1;
	public const AttributeProperties BOOLEAN = 2;
	public const AttributeProperties NAME = 4;

}

internal class AttributePSVIInfo // TypeDefIndex: 1943
{	// Fields
	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal object typedAttributeValue; // 0x20
	internal XmlSchemaInfo attributeSchemaInfo; // 0x28

	// Methods

	// RVA: 0x12DD820 Offset: 0x12DBE20 VA: 0x1812DD820
	internal void .ctor() { }

	// RVA: 0x12DD790 Offset: 0x12DBD90 VA: 0x1812DD790
	internal void Reset() { }

}

internal enum AttributeMatchState // TypeDefIndex: 2279
{	// Fields
	public int value__; // 0x0
	public const AttributeMatchState AttributeFound = 0;
	public const AttributeMatchState AnyIdAttributeFound = 1;
	public const AttributeMatchState UndeclaredElementAndAttribute = 2;
	public const AttributeMatchState UndeclaredAttribute = 3;
	public const AttributeMatchState AnyAttributeLax = 4;
	public const AttributeMatchState AnyAttributeSkip = 5;
	public const AttributeMatchState ProhibitedAnyAttribute = 6;
	public const AttributeMatchState ProhibitedAttribute = 7;
	public const AttributeMatchState AttributeNameMismatch = 8;
	public const AttributeMatchState ValidateAttributeInvalidCall = 9;

}

public class AttributeCollection : ICollection, IEnumerable // TypeDefIndex: 2666
{	// Fields
	public static readonly AttributeCollection Empty; // 0x0
	private static Hashtable _defaultAttributes; // 0x8
	private Attribute[] _attributes; // 0x10
	private static object internalSyncObject; // 0x10
	private AttributeCollection.AttributeEntry[] _foundAttributeTypes; // 0x18
	private int _index; // 0x20

	// Properties
	protected virtual Attribute[] Attributes { get; }
	public int Count { get; }
	public virtual Attribute Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x15BD990 Offset: 0x15BBF90 VA: 0x1815BD990
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 8
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x15BD8C0 Offset: 0x15BBEC0 VA: 0x1815BD8C0
	public int get_Count() { }

	// RVA: 0x15BDA70 Offset: 0x15BC070 VA: 0x1815BDA70 Slot: 9
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x15BD260 Offset: 0x15BB860 VA: 0x1815BD260
	public bool Contains(Attribute attribute) { }

	// RVA: 0x15BD370 Offset: 0x15BB970 VA: 0x1815BD370
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x15BD890 Offset: 0x15BBE90 VA: 0x1815BD890
	public IEnumerator GetEnumerator() { }

	// RVA: 0x15BD8C0 Offset: 0x15BBEC0 VA: 0x1815BD8C0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x15BD2E0 Offset: 0x15BB8E0 VA: 0x1815BD2E0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x15BD890 Offset: 0x15BBE90 VA: 0x1815BD890 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15BD8F0 Offset: 0x15BBEF0 VA: 0x1815BD8F0
	private static void .cctor() { }

}

private struct AttributeCollection.AttributeEntry // TypeDefIndex: 2667
{	// Fields
	public Type type; // 0x0
	public int index; // 0x8

}

public class AttributeProviderAttribute : Attribute // TypeDefIndex: 2668
{	// Fields
	private string _typeName; // 0x10
	private string _propertyName; // 0x18

	// Properties
	public string TypeName { get; }
	public string PropertyName { get; }

	// Methods

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_TypeName() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_PropertyName() { }

}

internal class AttributeHelperEngine // TypeDefIndex: 3492
{	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181F390 Offset: 0x181D990 VA: 0x18181F390
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181F470 Offset: 0x181DA70 VA: 0x18181F470
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x181F290 Offset: 0x181D890 VA: 0x18181F290
	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181F160 Offset: 0x181D760 VA: 0x18181F160
	private static int CheckIsEditorScript(Type klass) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x181F220 Offset: 0x181D820 VA: 0x18181F220
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: -1 Offset: -1
	private static T GetCustomAttributeOfType<T>(Type klass) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x159E770 Offset: 0x159CD70 VA: 0x18159E770
	|-AttributeHelperEngine.GetCustomAttributeOfType<object>
	|-AttributeHelperEngine.GetCustomAttributeOfType<DefaultExecutionOrder>
	*/

	// RVA: 0x181F830 Offset: 0x181DE30 VA: 0x18181F830
	private static void .cctor() { }

}

