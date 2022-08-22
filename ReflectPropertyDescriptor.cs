internal sealed class ReflectPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 2741
{	// Fields
	private static readonly Type[] argsNone; // 0x0
	private static readonly object noValue; // 0x8
	private static TraceSwitch PropDescCreateSwitch; // 0x10
	private static TraceSwitch PropDescUsageSwitch; // 0x18
	private static readonly int BitDefaultValueQueried; // 0x20
	private static readonly int BitGetQueried; // 0x24
	private static readonly int BitSetQueried; // 0x28
	private static readonly int BitShouldSerializeQueried; // 0x2C
	private static readonly int BitResetQueried; // 0x30
	private static readonly int BitChangedQueried; // 0x34
	private static readonly int BitIPropChangedQueried; // 0x38
	private static readonly int BitReadOnlyChecked; // 0x3C
	private static readonly int BitAmbientValueQueried; // 0x40
	private static readonly int BitSetOnDemand; // 0x44
	private BitVector32 state; // 0x88
	private Type componentClass; // 0x90
	private Type type; // 0x98
	private object defaultValue; // 0xA0
	private PropertyInfo propInfo; // 0xA8
	private MethodInfo getMethod; // 0xB0
	private MethodInfo setMethod; // 0xB8
	private MethodInfo shouldSerializeMethod; // 0xC0
	private EventDescriptor realChangedEvent; // 0xC8
	private Type receiverType; // 0xD0

	// Properties
	public override Type ComponentType { get; }
	private object DefaultValue { get; }
	private MethodInfo GetMethodValue { get; }
	private bool IsExtender { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	private MethodInfo SetMethodValue { get; }
	private MethodInfo ShouldSerializeMethodValue { get; }

	// Methods

	// RVA: 0x15D5C60 Offset: 0x15D4260 VA: 0x1815D5C60
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x15D5B00 Offset: 0x15D4100 VA: 0x1815D5B00
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x15D5E60 Offset: 0x15D4460 VA: 0x1815D5E60
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x4E4050 Offset: 0x4E2650 VA: 0x1804E4050 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x15D5F50 Offset: 0x15D4550 VA: 0x1815D5F50
	private object get_DefaultValue() { }

	// RVA: 0x15D62A0 Offset: 0x15D48A0 VA: 0x1815D62A0
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x15D6780 Offset: 0x15D4D80 VA: 0x1815D6780
	private bool get_IsExtender() { }

	// RVA: 0x15D67E0 Offset: 0x15D4DE0 VA: 0x1815D67E0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x15D68D0 Offset: 0x15D4ED0 VA: 0x1815D68D0
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x15D6F60 Offset: 0x15D5560 VA: 0x1815D6F60
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0xC73D40 Offset: 0xC72340 VA: 0x180C73D40
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x15D39F0 Offset: 0x15D1FF0 VA: 0x1815D39F0
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x15D3A10 Offset: 0x15D2010 VA: 0x1815D3A10
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x15D3B70 Offset: 0x15D2170 VA: 0x1815D3B70
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x15D3EB0 Offset: 0x15D24B0 VA: 0x1815D3EB0
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x15D42A0 Offset: 0x15D28A0 VA: 0x1815D42A0 Slot: 11
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x15D4D90 Offset: 0x15D3390 VA: 0x1815D4D90 Slot: 17
	public override object GetValue(object component) { }

	// RVA: 0x15D5080 Offset: 0x15D3680 VA: 0x1815D5080 Slot: 18
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x15D5180 Offset: 0x15D3780 VA: 0x1815D5180 Slot: 19
	public override void SetValue(object component, object value) { }

	// RVA: 0x15D5570 Offset: 0x15D3B70 VA: 0x1815D5570 Slot: 20
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x15D5850 Offset: 0x15D3E50 VA: 0x1815D5850
	private static void .cctor() { }

}

