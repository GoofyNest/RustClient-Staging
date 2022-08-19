public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 1232
{	// Fields
	private IActivator _activator; // 0x68
	private object[] _activationAttributes; // 0x70
	private IList _contextProperties; // 0x78
	private Type _activationType; // 0x80
	private string _activationTypeName; // 0x88
	private bool _isContextOk; // 0x90
	private RemotingProxy _sourceProxy; // 0x98

	// Properties
	internal bool IsContextOk { get; set; }
	public Type ActivationType { get; }
	public string ActivationTypeName { get; }
	public IActivator Activator { get; set; }
	public object[] CallSiteActivationAttributes { get; }
	public IList ContextProperties { get; }
	public override IDictionary Properties { get; }
	internal RemotingProxy SourceProxy { get; set; }

	// Methods

	// RVA: 0x1473600 Offset: 0x1471C00 VA: 0x181473600
	internal void .ctor(Type type) { }

	// RVA: 0x1473670 Offset: 0x1471C70 VA: 0x181473670
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1473230 Offset: 0x1471830 VA: 0x181473230 Slot: 22
	internal override void InitDictionary() { }

	// RVA: 0x1188620 Offset: 0x1186C20 VA: 0x181188620
	internal bool get_IsContextOk() { }

	// RVA: 0x1188640 Offset: 0x1186C40 VA: 0x181188640
	internal void set_IsContextOk(bool value) { }

	// RVA: 0x1473720 Offset: 0x1471D20 VA: 0x181473720 Slot: 24
	public Type get_ActivationType() { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370 Slot: 25
	public string get_ActivationTypeName() { }

	// RVA: 0x519C50 Offset: 0x518250 VA: 0x180519C50 Slot: 26
	public IActivator get_Activator() { }

	// RVA: 0x519E50 Offset: 0x518450 VA: 0x180519E50 Slot: 27
	public void set_Activator(IActivator value) { }

	// RVA: 0x5743D0 Offset: 0x5729D0 VA: 0x1805743D0 Slot: 28
	public object[] get_CallSiteActivationAttributes() { }

	// RVA: 0x574460 Offset: 0x572A60 VA: 0x180574460
	internal void SetActivationAttributes(object[] attributes) { }

	// RVA: 0x14737F0 Offset: 0x1471DF0 VA: 0x1814737F0 Slot: 29
	public IList get_ContextProperties() { }

	// RVA: 0x1473340 Offset: 0x1471940 VA: 0x181473340 Slot: 19
	internal override void InitMethodProperty(string key, object value) { }

	// RVA: 0x1473130 Offset: 0x1471730 VA: 0x181473130 Slot: 20
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1473860 Offset: 0x1471E60 VA: 0x181473860 Slot: 21
	public override IDictionary get_Properties() { }

	// RVA: 0x574380 Offset: 0x572980 VA: 0x180574380
	internal RemotingProxy get_SourceProxy() { }

	// RVA: 0x574410 Offset: 0x572A10 VA: 0x180574410
	internal void set_SourceProxy(RemotingProxy value) { }

}

