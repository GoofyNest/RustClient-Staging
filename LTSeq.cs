public class LTSeq // TypeDefIndex: 5574
{	// Fields
	public LTSeq previous; // 0x10
	public LTSeq current; // 0x18
	public LTDescr tween; // 0x20
	public float totalDelay; // 0x28
	public float timeScale; // 0x2C
	private int debugIter; // 0x30
	public uint counter; // 0x34
	public bool toggle; // 0x38
	private uint _id; // 0x3C

	// Properties
	public int id { get; }

	// Methods

	// RVA: 0x21AAB50 Offset: 0x21A9150 VA: 0x1821AAB50
	public int get_id() { }

	// RVA: 0x21AAC50 Offset: 0x21A9250 VA: 0x1821AAC50
	public void reset() { }

	// RVA: 0x21AAB60 Offset: 0x21A9160 VA: 0x1821AAB60
	public void init(uint id, uint global_counter) { }

	// RVA: 0x21AA200 Offset: 0x21A8800 VA: 0x1821AA200
	private LTSeq addOn() { }

	// RVA: 0x21AA2D0 Offset: 0x21A88D0 VA: 0x1821AA2D0
	private float addPreviousDelays() { }

	// RVA: 0x21AAB20 Offset: 0x21A9120 VA: 0x1821AAB20
	public LTSeq append(float delay) { }

	// RVA: 0x21AA310 Offset: 0x21A8910 VA: 0x1821AA310
	public LTSeq append(Action callback) { }

	// RVA: 0x21AA4E0 Offset: 0x21A8AE0 VA: 0x1821AA4E0
	public LTSeq append(Action<object> callback, object obj) { }

	// RVA: 0x21AA770 Offset: 0x21A8D70 VA: 0x1821AA770
	public LTSeq append(GameObject gameObject, Action callback) { }

	// RVA: 0x21AA930 Offset: 0x21A8F30 VA: 0x1821AA930
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj) { }

	// RVA: 0x21AA6E0 Offset: 0x21A8CE0 VA: 0x1821AA6E0
	public LTSeq append(LTDescr tween) { }

	// RVA: 0x21AABD0 Offset: 0x21A91D0 VA: 0x1821AABD0
	public LTSeq insert(LTDescr tween) { }

	// RVA: 0x21AAD60 Offset: 0x21A9360 VA: 0x1821AAD60
	public LTSeq setScale(float timeScale) { }

	// RVA: 0x21AACA0 Offset: 0x21A92A0 VA: 0x1821AACA0
	private void setScaleRecursive(LTSeq seq, float timeScale, int count) { }

	// RVA: 0x21AAC90 Offset: 0x21A9290 VA: 0x1821AAC90
	public LTSeq reverse() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

